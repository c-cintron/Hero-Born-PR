using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehavior : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);

            if (this.name == "Health_Pickup")
            {
                Debug.Log("Health Item collected!");
            }
            else if (this.name == "Strength_Pickup")
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
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
