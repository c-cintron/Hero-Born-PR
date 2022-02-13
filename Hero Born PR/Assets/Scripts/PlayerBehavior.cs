using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;

    private float vInput;
    private float hInput;

    public float speedMultiplier = 2f;
    public float totalSeconds = 5f;

    private bool pogoEffect = false;

    private Rigidbody _rb;

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.name)
        {
            case "Health_Pickup":
            {
                Debug.Log("Health Item collected!");
                Destroy(collision.gameObject.transform.parent.gameObject);
                break;
            }
                /*else if (this.name == "Strength_Pickup")
                {
                    Debug.Log("Strength Item collected!");
                }
                else if (this.name == "Speed_Pickup")
                {
                    Debug.Log("Speed Item collected!");
                }
                else if (this.name == "Pogo_Pickup")
                {
                    Debug.Log("Pogo Item collected!");
                }*/
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;
        /*
        this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
        this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
        */ 
    }

    void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * hInput;

        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position + this.transform.forward * vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot);
    }
}
