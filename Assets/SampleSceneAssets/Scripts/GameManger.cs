using UnityEngine;
using UnityEngine.SceneManagement;
//Use this is you need to change to a different scene/level or reload/restart a scene/level 

public class GameManger : MonoBehaviour
{
    bool gameHasEnded = false;
    private float restartDelay = 2f;

    public GameObject completeLevelUI;


    public void EndGame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("Game Over");
            //Invoke will help you create a small delay without worrying
            Invoke("Restart", restartDelay);
        }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void CompleteLevel(){
        completeLevelUI.SetActive(true);
        Debug.Log("Level Won");
        Invoke("Restart", 6f) ;
    }
}
