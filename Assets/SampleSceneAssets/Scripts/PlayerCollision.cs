using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    //we wish to stop player movement when the player collides with an object with the object tag
    public PlayerMovement movement;

    //this is a specific function provided by unity for collisions
        //This will be called whenever the parent that the script is on colides with something
    void OnCollisionEnter(Collision collisionInfo) {

        switch (collisionInfo.collider.tag){
            case "Obsticale":
                //Debug.Log(collisionInfo.collider.name);

                //This is a reference to a script
                    //this turns the sript off
                movement.enabled = false;
                break;

        }
    }
}
