using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Activates next level buttons in Level Scene if the player is successful

public class UnlockLevels : MonoBehaviour
{

	public Button[] buttons;
	public Image[] lockImages;
    public Text[] text;
	public Image star;

    void Start()
    {
    	int levelPassed = PlayerPrefs.GetInt("LevelPassed", 3);
    	star.enabled = false;

    	//iterate through each button in the aray
    	//if its index matches levelPassed make it active
    	for (int i = 0; i < buttons.Length; i++)
        {
        	//iterate through each image in the array
        	for (int j = 0; j < lockImages.Length; j++)
        	{
        		if (i + 3> levelPassed) 
        		{
        			buttons[i].interactable = false;

        			//if an index of a button in the array matches index of 
        			//an image in the array dissable lockImage and set text to 0
        			if(buttons[j].interactable == false){
        				lockImages[j].enabled = false;
                        text[j].rectTransform.sizeDelta = new Vector2(0, 0);
        			}
        		}
        	}

        }

        //if the player passes 4 level the star is displayed
        if(buttons[3].interactable == true) star.enabled = true;
    }

    //method for changing scenes 
    public void levelToload(int level) 
    {
    	SceneManager.LoadScene(level);
    }

    //reset button
    public void reset(){
    	PlayerPrefs.DeleteAll();
    }
}
