using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Displays the list of the words

public class WordList : MonoBehaviour
{
    public Text text;
    public Image image;
    public Sprite down;
    public Sprite up;

    // open the word's meaning on button click
    public void changeFont()
    {
        // if the font size is 1 - increase it to 25
        // else  decrease it to 1
    	if(text.fontSize == 1)
    	{
    		text.fontSize = 25;
    		text.rectTransform.sizeDelta = new Vector2(390, 300);
    		image.sprite = up;
    	} else {
    		text.fontSize = 1;
    		text.rectTransform.sizeDelta = new Vector2(390, 0);
    		image.sprite = down; 
    	}
    }
}
