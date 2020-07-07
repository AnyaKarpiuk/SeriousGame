using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Pauses the game on click and returns it to normal

public class Pause : MonoBehaviour
{
    bool isPaused = false;
    public Text pauseText;

    public void pauseGame()
    {
    	if(isPaused)
    	{
    		Time.timeScale = 1;
    		isPaused = false;
    		pauseText.text = "||";
    	} else {
    		Time.timeScale = 0;
    		isPaused = true;
    		pauseText.text = "►";
    	}
    }
}
