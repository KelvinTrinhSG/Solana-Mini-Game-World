using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class MainMenuManager : MonoBehaviour
{
     public GameObject firstScene;
    public GameObject quizScene;
    public GameObject flappyBirdScene;
    public GameObject bossFightingScene;

    public GameObject firstSceneNextButton;
    public GameObject quizSceneNextButton;
    public GameObject quizSceneBackButton;
    public GameObject flappyBirdSceneNextButton;
    public GameObject flappyBirdSceneBackButton;
    public GameObject bossFightingSceneBackButton;

    public void MoveToQuizScene()
    {
        firstScene.SetActive(false);
        quizScene.SetActive(true);
        flappyBirdScene.SetActive(false);
        bossFightingScene.SetActive(false);
    }
    public void MoveToFlappyBirdScene()
    {
        firstScene.SetActive(false);
        quizScene.SetActive(false);
        flappyBirdScene.SetActive(true);
        bossFightingScene.SetActive(false);
    }
    public void MoveToBossFightingScene()
    {
        firstScene.SetActive(false);
        quizScene.SetActive(false);
        flappyBirdScene.SetActive(false);
        bossFightingScene.SetActive(true);

    }
    public void MoveBackToFirstScene()
    {
        firstScene.SetActive(true);
        quizScene.SetActive(false);
        flappyBirdScene.SetActive(false);
        bossFightingScene.SetActive(false);
    }
    public void MoveBackToQuizScene()
    {
        firstScene.SetActive(false);
        quizScene.SetActive(true);
        flappyBirdScene.SetActive(false);
        bossFightingScene.SetActive(false);
    }
    public void MoveBackToflappyBirdScene()
    {
        firstScene.SetActive(false);
        quizScene.SetActive(false);
        flappyBirdScene.SetActive(true);
        bossFightingScene.SetActive(false);
    }
    public void QuizGame()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void FlappyBirdGame()
    {
        SceneManager.LoadSceneAsync(4);
    }
}
