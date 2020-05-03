using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    
	public int sceneIndex;

    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void changeLevel()
    {

    	SceneManager.LoadScene(sceneIndex);

    	if (sceneIndex > PlayerPrefs.GetInt("LevelPassed")) 
    	{
    		PlayerPrefs.SetInt("LevelPassed", sceneIndex);
    	}
    }

    
}
