using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Counts missed words

public class MissedWords : MonoBehaviour
{
	public static MissedWords instance;

	public int missedObject;
	public Text missedText;
	public GameObject gameOverPanel;
	public Button menuButton;

	public int timer = 10;
	public bool gameOver;
	public Text timerText;
	public Text conclusion;

	public GameObject missedImage;
	public GameObject missedImage2;
	public GameObject missedImage3;

	public void Awake()
	{
		instance = this;
	}

	public void Start() 
	{
		gameOverPanel.SetActive(false);
		menuButton.gameObject.SetActive(false);
		missedObject = 0;
		StartCoroutine(waitForThreeSec());
	}

	// when the object touches the border count it as missed
    public void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "word") 
		{
			// destroy the object on collision
			Destroy(col.gameObject);
			// count missed objects
			missedObject += 1;

			//remove stars if the user misses objects
			switch(missedObject)
			{
				case 1:
					missedImage.SetActive(false);
					break;
				case 2:
					missedImage2.SetActive(false);
					break;
				case 3:
					missedImage3.SetActive(false);
					break;
			}

			// if the user misses 3 objects - display the screen
			if(missedObject >= 3)
			{
				gameOverPanel.SetActive(true);
				conclusion.text = "Sorry! You lost.";
				menuButton.gameObject.SetActive(true);
			}
			
		}
	}

	// set timer text
    public void SetTimerText() 
    {
    	timerText.text = timer.ToString();
    }

    // set count down time
    public void Count()
    {
    	// if timer equals 0 - stop the game
    	// else minus 1 from count down
    	if(timer == 0)
    	{
    		gameOver = true;
    	} else {
    		timer--;
    		SetTimerText();
    	}

    }

    // wait for 3 seconds before starting to count down the time
    IEnumerator waitForThreeSec()
    {
    	yield return new WaitForSeconds(4);
    	InvokeRepeating("Count", 0.0f, 1.0f);
    }
}
