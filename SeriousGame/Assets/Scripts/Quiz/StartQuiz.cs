using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Changes screens between the quiz and the list

public class StartQuiz : MonoBehaviour
{
    
	public GameObject panel;

    public void Start()
    {
        // set panel inactive by default
        panel.SetActive(false);
    }

    // start the quix
    public void startQuiz()
    {
        panel.SetActive(true);
    }

    // return to the list
    public void returnToList()
    {
    	panel.SetActive(false);
    }

    // start the quiz
    public void moveToQuiz()
    {
    	SceneManager.LoadScene(4);
    }

}
