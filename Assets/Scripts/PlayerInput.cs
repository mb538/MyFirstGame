using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
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
            canvas.enabled = false;
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
    }
}
