using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UnlockLevels : MonoBehaviour
{

	//public Button levelOne, levelTwo, levelThree, levelFour;
	public Button[] buttons;
    
    void Start()
    {
    	int levelPassed = PlayerPrefs.GetInt("LevelPassed", 2);
    	for (int i = 0; i < buttons.Length; i++)
        {
        	if (i + 2 > levelPassed) buttons[i].interactable = false;
        }
        // levelTwo.interactable = false;
        // levelThree.interactable = false;
        // levelFour.interactable = false;

        // switch(levelPassed) 
        // {
        // 	case 1:
        // 		levelTwo.interactable = true;
        // 		break;
        // 	case 2:
        // 		levelTwo.interactable = true;
        // 		levelThree.interactable = true;
        // 	 	break;
        	// case 3:
        	// 	levelTwo.interactable = true;
        	// 	levelThree.interactable = true;
        	// 	levelFour.interactable = true;
        	// 	break;
        //}

        
    }

    public void levelToload(int level) 
    {
    	SceneManager.LoadScene(level);
    }

}
