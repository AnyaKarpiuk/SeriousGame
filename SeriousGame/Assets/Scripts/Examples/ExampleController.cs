using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Navigation between examples

public class ExampleController : MonoBehaviour
{
    
	public Button changeLevel;
	public Button nextButton;
	public Button backButton;
	public Button nextButton2;
	public Button backButton2;

	public Text exampleTitle;
	public Text example;
	public Text exampleTitle2;
	public Text example2;
	public Text exampleTitle3;
	public Text example3;

    //set first example to be displayed first, disable buttons that won't be needed
    void Start()
    {
        changeLevel.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
        backButton2.gameObject.SetActive(false);
        nextButton2.gameObject.SetActive(false);
        example2.rectTransform.sizeDelta = new Vector2(0, 0);
    	exampleTitle2.rectTransform.sizeDelta = new Vector2(0, 0);
    	example3.rectTransform.sizeDelta = new Vector2(0, 0);
    	exampleTitle3.rectTransform.sizeDelta = new Vector2(0, 0);
    }

    // desplay first example when the button is clicked
    public void changeToFirst()
    {
    	example.rectTransform.sizeDelta = new Vector2(400, 340);
    	exampleTitle.rectTransform.sizeDelta = new Vector2(400, 30);
    	example2.rectTransform.sizeDelta = new Vector2(0, 0);
    	exampleTitle2.rectTransform.sizeDelta = new Vector2(0, 0);
    	example3.rectTransform.sizeDelta = new Vector2(0, 0);
    	exampleTitle3.rectTransform.sizeDelta = new Vector2(0, 0);
    	backButton.gameObject.SetActive(false);
    	nextButton.gameObject.SetActive(true);
    	backButton2.gameObject.SetActive(false);
    	nextButton2.gameObject.SetActive(false);
    }

    // desplay second example when the button is clicked
    public void changeToSecond()
    {
    	backButton.gameObject.SetActive(true);
    	backButton2.gameObject.SetActive(false);
    	nextButton.gameObject.SetActive(false);
    	nextButton2.gameObject.SetActive(true);
    	example.rectTransform.sizeDelta = new Vector2(0, 0);
    	exampleTitle.rectTransform.sizeDelta = new Vector2(0, 0);
    	example3.rectTransform.sizeDelta = new Vector2(0, 0);
    	exampleTitle3.rectTransform.sizeDelta = new Vector2(0, 0);
    	example2.rectTransform.sizeDelta = new Vector2(400, 340);
    	exampleTitle2.rectTransform.sizeDelta = new Vector2(400, 30);
    }

    // desplay third example when the button is clicked
    public void changeToThird()
    {
    	backButton.gameObject.SetActive(false);
    	nextButton.gameObject.SetActive(false);
    	nextButton2.gameObject.SetActive(false);
    	backButton2.gameObject.SetActive(true);
    	changeLevel.gameObject.SetActive(true);
    	example.rectTransform.sizeDelta = new Vector2(0, 0);
    	exampleTitle.rectTransform.sizeDelta = new Vector2(0, 0);
    	example3.rectTransform.sizeDelta = new Vector2(400, 340);
    	exampleTitle3.rectTransform.sizeDelta = new Vector2(400, 30);
    	example2.rectTransform.sizeDelta = new Vector2(0, 0);
    	exampleTitle2.rectTransform.sizeDelta = new Vector2(0, 0);
    }

}
