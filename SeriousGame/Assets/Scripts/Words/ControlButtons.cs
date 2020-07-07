using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Controls buttons in Vocabulary scene

public class ControlButtons : MonoBehaviour
{
    public GameObject wordsListPanel;
    public GameObject startPanel;
    public GameObject gamePanel;
    public Button nextButton;
    public Button backButton;

    void Start()
    {
        gamePanel.SetActive(false);
    }

    //disactivate the panel with the list of words
    public void disactivateWordsPanel()
    {
        wordsListPanel.SetActive(false);
        nextButton.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
    }

    //activate the panel with the list of words
    public void activateWordsPanel()
    {
        wordsListPanel.SetActive(true);
        nextButton.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
    }

    //disactivate the start panel 
    public void startGame()
    {
        SceneManager.LoadScene(7);
    }
}
