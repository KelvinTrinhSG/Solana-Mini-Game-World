using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class MainMenuManager : MonoBehaviour
{
    public GameObject firstScene;
    public GameObject quizScene;
    public GameObject flappyBirdScene;
    public GameObject bossFightingScene;
    public GameObject instructionScene;

    public GameObject firstSceneNextButton;
    public GameObject quizSceneNextButton;
    public GameObject quizSceneBackButton;
    public GameObject flappyBirdSceneNextButton;
    public GameObject flappyBirdSceneBackButton;
    public GameObject bossFightingSceneBackButton;

    public GameObject instructionSceneNextButton;
    public GameObject firstSceneBackButton;

    public void MoveToInstructionScene()
    {
        instructionScene.SetActive(true);
        firstScene.SetActive(false);
        quizScene.SetActive(false);
        flappyBirdScene.SetActive(false);
        bossFightingScene.SetActive(false);
    }

    public void MoveBackToFirstScene()
    {
        instructionScene.SetActive(false);
        firstScene.SetActive(true);
        quizScene.SetActive(false);
        flappyBirdScene.SetActive(false);
        bossFightingScene.SetActive(false);
    }

    public void MoveToQuizScene()
    {
        instructionScene.SetActive(false);
        firstScene.SetActive(false);
        quizScene.SetActive(true);
        flappyBirdScene.SetActive(false);
        bossFightingScene.SetActive(false);
    }
    public void MoveToFlappyBirdScene()
    {
        instructionScene.SetActive(false);
        firstScene.SetActive(false);
        quizScene.SetActive(false);
        flappyBirdScene.SetActive(true);
        bossFightingScene.SetActive(false);
    }
    public void MoveToBossFightingScene()
    {
        instructionScene.SetActive(false);
        firstScene.SetActive(false);
        quizScene.SetActive(false);
        flappyBirdScene.SetActive(false);
        bossFightingScene.SetActive(true);

    }
    public void MoveBackToFirstSceneFromInstruction()
    {
        instructionScene.SetActive(false);
        firstScene.SetActive(true);
        quizScene.SetActive(false);
        flappyBirdScene.SetActive(false);
        bossFightingScene.SetActive(false);
    }
    public void MoveBackToQuizScene()
    {
        instructionScene.SetActive(false);
        firstScene.SetActive(false);
        quizScene.SetActive(true);
        flappyBirdScene.SetActive(false);
        bossFightingScene.SetActive(false);
    }
    public void MoveBackToflappyBirdScene()
    {
        instructionScene.SetActive(false);
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
