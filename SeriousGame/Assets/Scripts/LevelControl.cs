using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Moves from one level to the next

public class LevelControl : MonoBehaviour
{
    
	public int sceneIndex;

    void Start()
    {
    	//assign a next level's index to sceneIndex variable
        sceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
    }

    //method for changing levels
    public void changeLevel()
    {
    	//when a button pressed move to a next scene
    	SceneManager.LoadScene(sceneIndex);

    	//if the player passes a level set sceneIndex to LevelPasses
    	//so that acctivated a level button in Level Scene
    	if (sceneIndex > PlayerPrefs.GetInt("LevelPassed")) 
    	{
    		PlayerPrefs.SetInt("LevelPassed", sceneIndex);
    	}
    }

    
}
