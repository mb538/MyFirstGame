using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private bool gamePaused = false;
    public Canvas canvas;
    
    void Start()
    {
        canvas.enabled = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && gamePaused == true){
            resume();
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && gamePaused == false){
            gamePaused = true;
            Debug.Log("gamePaused = " + gamePaused);
            Time.timeScale = 0;
            canvas.enabled = true;
        }
        
    }

    public void resume(){
        gamePaused = false;
        Debug.Log("gamePaused = " + gamePaused);
        Time.timeScale = 1;
        canvas.enabled = false;
    }

    public void playGame()
    {
        Debug.Log("You have loaded next Scene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void exitGame()
    {
        Debug.Log("You have quit the game");
        Application.Quit();
    }

    public void retryGame()
    {
        
    }

}
