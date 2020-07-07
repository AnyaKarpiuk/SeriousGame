using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Displays the game's tutorial on button clicked

public class TutorialController : MonoBehaviour
{
    public Image talkContainer;
    public Button tutorialButton;
    public Text tutorialText;

    public Button nextButton;
    public Button nextButton2;
    public Button nextButton3;
    public Button nextButton4;

    // set all components inactive by default
    public void Start()
    {
    	talkContainer.enabled = false;
    	nextButton.gameObject.SetActive(false);
    	nextButton2.gameObject.SetActive(false);
    	nextButton3.gameObject.SetActive(false);
    	nextButton4.gameObject.SetActive(false);
    	tutorialText.rectTransform.sizeDelta = new Vector2(0, 0);
    }

    public void startTutorial()
    {
    	tutorialButton.gameObject.SetActive(false);
    	talkContainer.enabled = true;

    	nextButton.gameObject.SetActive(true);

    	tutorialText.rectTransform.sizeDelta = new Vector2(230, 250);
    	
    	tutorialText.text = "Hello! Welcome to UInterview. I'm here to help you.The rules are quite simple.";
    }

    // display the first slide
    public void first()
    {
    	nextButton.gameObject.SetActive(false);
    	nextButton2.gameObject.SetActive(true);
    	tutorialText.text = "Press Start to start. Choose a question from the list. You have to unlock all steps.";
    }

     // display the second slide
    public void second()
    {
    	nextButton.gameObject.SetActive(false);
    	nextButton2.gameObject.SetActive(false);
    	nextButton3.gameObject.SetActive(true);
    	tutorialText.text = "First step - learn vocabulary. Second - read advices. Third - read examples.";
    }

     // display the third slide
    public void third()
    {
    	nextButton.gameObject.SetActive(false);
    	nextButton2.gameObject.SetActive(false);
    	nextButton3.gameObject.SetActive(false);
    	nextButton4.gameObject.SetActive(true);
    	tutorialText.text = "Forth - answer the question. Have fun!";
    }

     // display the last slide
    public void endTutorial()
    {
    	nextButton.gameObject.SetActive(false);
    	nextButton2.gameObject.SetActive(false);
    	nextButton3.gameObject.SetActive(false);
    	nextButton4.gameObject.SetActive(false);
    	tutorialText.rectTransform.sizeDelta = new Vector2(0, 0);
    	talkContainer.enabled = false;
    	tutorialButton.gameObject.SetActive(true);
	}
}
