using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

//Controls dropdown menu on each page of the game

public class DropdownMenu : MonoBehaviour
{

	public GameObject panel;
	public GameObject border;

	//method for openening dropdown menu
    public void openMenu()
    {
    	
    	if (panel != null)
    	{
    		Animator animator = panel.GetComponent<Animator>();
    		Animator animator2 = border.GetComponent<Animator>();

    		if (animator != null) 
    		{
    			bool isOpened = animator.GetBool("Opened");
    			bool isOpened2 = animator2.GetBool("Opened");
    			animator.SetBool("Opened", !isOpened);
    			animator2.SetBool("Opened", !isOpened2);
    		} 
    		
    	} 
    }
 
}
