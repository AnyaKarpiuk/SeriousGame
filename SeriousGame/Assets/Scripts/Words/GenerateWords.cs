using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Generate random words

public class GenerateWords : MonoBehaviour
{

    public GameObject[] wordList;
    public float spawnWait;
    public float maxWaitTime;
    public float leastWaitTime;
    public bool stop;
    public Transform wordCanvas;
    private int random;
    private int random2;

    public int countDown;
    public Text countDownText;

    public Button pause;

    void Start() 
    {
        // start count down
    	StartCoroutine(CountDownToStart());
    }

    void Update()
    {
        // instantiate random time between generated objects
    	spawnWait = Random.Range(leastWaitTime, maxWaitTime);
    }

    // start the game
    IEnumerator startGame() 
    {

        // while the timer is bigger 0 - generate objects
        while(MissedWords.instance.timer > 0)
    	{
            // choose the object randomly from the array
    		random = Random.Range(0, wordList.Length);

    		Vector3 position = new Vector3(Random.Range(-1f, 1f), 5f);

    		Instantiate(wordList[random], position, Quaternion.identity, wordCanvas);

    		yield return new WaitForSeconds(spawnWait);
    	}

        // if the timer is equal 0 - stop the game
        if(MissedWords.instance.timer == 0){
            MissedWords.instance.gameOverPanel.SetActive(true);
            MissedWords.instance.menuButton.gameObject.SetActive(true);
        }
    }

    // count down to the game's start
    public IEnumerator CountDownToStart()
    {
        //while count down is bigger 0 - minus 1 from count down
    	while(countDown > 0)
    	{
            // display count down on the screen
    		countDownText.text = countDown.ToString();

    		yield return new WaitForSeconds(1f);

    		countDown--;    	
    	}

       	countDownText.text = "";

        // start the game after count down is finished
       	StartCoroutine(startGame());

       	yield return new WaitForSeconds(1f);

        // set count down inactive
       	countDownText.gameObject.SetActive(false);
    }

}
