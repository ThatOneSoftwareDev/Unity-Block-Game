using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    //This is a fuction given from unity
    void OnTriggerEnter(){
        FindAnyObjectByType<GameManger>().CompleteLevel();
    }
}
