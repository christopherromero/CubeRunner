using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement; // A reference to our PlayerMovement script 


    // This fucntion runs when we hit another object
    // We get information about the collision and call it "collisionInfo"

    public void OnCollisionEnter(Collision collisionInfo)
    {
        // Check if the object we collided with has a tag called "Obstacle"
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; // Disable player movement when hit
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
