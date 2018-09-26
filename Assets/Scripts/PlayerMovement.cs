using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Ref to Rigid body field 
    public Rigidbody rb;
    
    // Forward Force applied to the player
    public float forwardForce = 2000f;

    public float sidewaysForce = 700f;

    // We changed Update --> FixedUpdate
    // Unity performs better when calculating physics with FixedUpdate
	void FixedUpdate ()
    {
        // Adds a forward force and time-frame consideration on the z-axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
