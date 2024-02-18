using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// using Thirdweb;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public GameObject QuizPanel;
    public GameObject GOPanel;
    public Text QuestionTxt;
    public Text ScoreTxt;
    int TotalQuestions = 0;
    public int score;
    public Text btnTxt;

    private void Start()
    {
        Debug.Log("StartQuiz");
        TotalQuestions = QnA.Count;
        GOPanel.SetActive(false);
        generateQuestion();
        StaticData.valueToKeep = "NotYet";
    }

    void GameOver()
    {
        QuizPanel.SetActive(false);
        GOPanel.SetActive(true);
        ScoreTxt.text = score + "/" + TotalQuestions;
        if (score >= 10)
        {
            StaticData.valueToKeep = "Correct";
            SceneManager.LoadScene(2);
        }
    }

    public void correct()
    {
        score += 1;
        generateQuestion();
    }

    public void wrong()
    {
        generateQuestion();
    }
    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswersScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswersScript>().isCorrect = true;
            }
        }
    }
    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].Questions;
            SetAnswers();
            QnA.RemoveAt(currentQuestion);
        }
        else
        {
            Debug.Log("Out of Question");
            GameOver();
        }
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MoveToMainMenu(){
        SceneManager.LoadScene(0);
    }

}
