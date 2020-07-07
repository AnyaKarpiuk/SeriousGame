using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Circle's animation. When the user changesbetween examples - 
// the size of the circles changes respectively 

public class CirclesController : MonoBehaviour
{
    
	public Image image;
	public Image image2;
	public Image image3;

    // set the first circle big by default
    public void Start()
    {
        image.rectTransform.sizeDelta = new Vector2(25, 25);
        image2.rectTransform.sizeDelta = new Vector2(15, 15);
        image3.rectTransform.sizeDelta = new Vector2(15, 15);
    }

    // set the first circle big
    public void firstCircle()
    {
    	image.rectTransform.sizeDelta = new Vector2(25, 25);
        image2.rectTransform.sizeDelta = new Vector2(15, 15);
        image3.rectTransform.sizeDelta = new Vector2(15, 15);
    }

    // set the second circle big
    public void secondCircle()
    {
    	image.rectTransform.sizeDelta = new Vector2(15, 15);
        image2.rectTransform.sizeDelta = new Vector2(25, 25);
        image3.rectTransform.sizeDelta = new Vector2(15, 15);
    }

    // set the third circle big
    public void thirdCircle()
    {
    	image.rectTransform.sizeDelta = new Vector2(15, 15);
        image2.rectTransform.sizeDelta = new Vector2(15, 15);
        image3.rectTransform.sizeDelta = new Vector2(25, 25);
    }
    
}
