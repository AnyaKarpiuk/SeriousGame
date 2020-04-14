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

    //when a button is pressed - go to start of the game
    public void startButton() {
    	SceneManager.LoadScene(1);
    }

    //back to the main menu
    public void backToMenuButton() {
    	SceneManager.LoadScene(0);
    }

    //when the button is pressed - open a progress screen
    public void progressButton() {
    	SceneManager.LoadScene(2);
    }

    //when the button is pressed - start to practise first question
    public void questionOneButton() {
    	SceneManager.LoadScene(3);
    }

    // Question 1
    public void step11Button() {
    	SceneManager.LoadScene(4);
    }

    public void step12Button() {
    	SceneManager.LoadScene(5);
    }

    public void step13Button() {
    	SceneManager.LoadScene(6);
    }

    public void step14Button() {
    	SceneManager.LoadScene(7);
    }

    //quit the game
    public void quitButton () {
        Application.Quit();
    }
}
