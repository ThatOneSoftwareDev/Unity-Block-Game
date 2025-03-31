using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    //The type you give each property will show up as that in unity
        //example transform will always give you a space to put an objects transform
        //Vector will always give a place to store x,y,z values
    public Transform player;
    public Vector3 offest;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position);

        //When you call transform like this it means the transform property attached to this game object
        transform.position = player.position + offest;
    }
}
