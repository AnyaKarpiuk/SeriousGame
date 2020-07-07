using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

// Responsible for the logic of the quiz - displays the questions,
// counts wrongly and correctly answered questions and so on.

public class QuizManager : MonoBehaviour
{
    
    public Questions[] questions;
    private static List<Questions> notAnswered;

    private Questions current;

    [SerializeField]
    private Text questionText;

    [SerializeField]
    private float time = 3f;

    [SerializeField]
    private static int score;
    [SerializeField]
    private static int wrongAnswer;

    public Text finalScore;
    public Text finalWrongAnswers;
    public Text conclusion;

    public GameObject panel;
    public Button nextLevelButton;

    public Image correctImage;
    public Image wrongImage;

    void Start()
    {
        // set elements that isn't used from the start of the quiz inactive 
        panel.SetActive(false);
        nextLevelButton.gameObject.SetActive(false);
        correctImage.enabled = false;
        wrongImage.enabled = false;

        if(notAnswered == null || notAnswered.Count == 0) 
        {
        	notAnswered = questions.ToList<Questions>();
        }

        GetRandomQuestion();

        // if the player answered 7 question correctly he can move to the next step
        if(score >= 7)
        {
            panel.SetActive(true);
            nextLevelButton.gameObject.SetActive(true);
            finalScore.text = score.ToString() + " - correct answers";
            finalWrongAnswers.text = wrongAnswer.ToString() + " -  wrong answers";
            conclusion.text = "Good job! Now you can move to the next step.";
        }

        // if the player answer 3 questions wrongly he has to attemp the quiz again
        if(wrongAnswer >= 3)
        {
            panel.SetActive(true);
            finalScore.text = score.ToString() + " - correct answers";
            finalWrongAnswers.text = wrongAnswer.ToString() + " - wrong answers";
            conclusion.text = "Sorry. You didn't pass. Try again.";
        }
    }

    // get random question from the array
    void GetRandomQuestion()
    {
    	int index = Random.Range(0, notAnswered.Count());
    	current = notAnswered[index];

    	questionText.text = current.question;
    }

    // move to the next question
    IEnumerator moveToNextQuestion()
    {
    	notAnswered.Remove(current);

    	yield return new WaitForSeconds(time);

    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // when True button is pressed
    public void selectTrue()
    {
        // if the user answers correctly - count correctly answered questions and
        // enable correct image
        // else count wrongly answered questions and enable wrong image
    	if(current.isTrue)
    	{
            correctImage.enabled = true;
            wrongImage.enabled = false;
            countScore();
    	}else 
    	{
            correctImage.enabled = false;
            wrongImage.enabled = true;
            countWrongAnswers();
    	}

        // move to the next question
    	StartCoroutine(moveToNextQuestion());
    }

    // when False button is pressed
    public void selectFalse()
    {

    	if(!current.isTrue)
    	{
            correctImage.enabled = true;
            wrongImage.enabled = false;
            countScore();
    	}else 
    	{
            correctImage.enabled = false;
            wrongImage.enabled = true;
            countWrongAnswers();
    	}

        // move to the next question
    	StartCoroutine(moveToNextQuestion());
    }

    // if the player answers correctly add one to the score
    public void countScore()
    {
    	   score += 1;
    }

    // if the player answers wrongly add one to the wrongAnswer
    public void countWrongAnswers()
    {
           wrongAnswer += 1;
    }

    // set score and wrongAnswer to 0 when the user wants to attemp the quiz again
    public void tryAgain()
    {
        wrongAnswer = 0;
        score = 0;
        panel.SetActive(false);
        nextLevelButton.gameObject.SetActive(false);
    }

}
