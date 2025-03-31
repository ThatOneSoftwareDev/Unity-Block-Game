using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //a test to disable gravity https://www.youtube.com/watch?v=9ZEu_I-ido4&list=PLPV2KyIb3jR5QFsefuO2RlAgWEz6EvVi6&index=3
    //3:40

    public Rigidbody rb;
    //unity editor always keep the value in unity first before the script so 
        // you can use [System.NonSerialized] to get around this but it wont be in the inspector
        // see : https://stackoverflow.com/a/46938228 for more details
    public float forwardForce = 8000f;
    public float sidewaysForce = 120f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //this is excecuted when you start the game
    void Start()
    {
        //add small force
        //rb.AddForce(0,200,500);
    }

    // Update is called once per frame
    //This function was called update before
    //You can call it fixed update if you are working with pyhsics
        //unity likes it better that was
    void FixedUpdate()
    {
        //the original was bellow
            //rb.AddForce(0,0,200);
            //this is bad because it updates every seccond and computers will vary in frame rate!
            //instead of a fixed value that can make the cube slower or faster depending on the computer use the below instead
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        //basic controls
        //ForceMode.VelocityChange was added later
            // it helps the object to increase in speed as it is still going and helps to not be as slow
        if(Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }else if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0 ,ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f){
            FindAnyObjectByType<GameManger>().EndGame();
        }
    }
}
