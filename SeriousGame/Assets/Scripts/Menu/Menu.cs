using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Controls menu buttons and buttons on each screen,
// navigates through the game 

public class Menu : MonoBehaviour
{

    void Start()
    {
    }

    //go to start of the game
    public void startButton() {
    	SceneManager.LoadScene(1);
    }

    //back to the main menu
    public void backToMenuButton() {
    	SceneManager.LoadScene(0);
    }

    //start to practise first question
    public void questionOneButton() {
    	SceneManager.LoadScene(2);
    }

    // Question 1
    public void step11Button() {
    	SceneManager.LoadScene(3);
    }

    public void step12Button() {
    	SceneManager.LoadScene(8);
    }

    public void step13Button() {
    	SceneManager.LoadScene(5);
    }

    public void step14Button() {
    	SceneManager.LoadScene(6);
    }

    // quit the game
    public void quitButton () {
        Application.Quit();
    }

    // move to the list
    public void moveToList()
    {
        SceneManager.LoadScene(8);
    }
    
}
