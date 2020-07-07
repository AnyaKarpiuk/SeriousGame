using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Destroys objects on click

public class DestroyWord : MonoBehaviour
{

	//when mouse is clicked find the object with the tag "word" and destroy it
	public void OnMouseDown()
	{
		if(gameObject.tag == "word") 
		{
			Destroy(gameObject);
		}
	}
	
}
