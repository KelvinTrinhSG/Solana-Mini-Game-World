using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManagerBird : MonoBehaviour
{
    public PlayerBird player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public int score;
    public Text btnTxt;
    public GameObject ToMainGameButton;

    private void Awake()
    {
        StaticData.valueToKeepBird = "NotYet";
        Application.targetFrameRate = 60;
        gameOver.SetActive(false);
        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();
        gameOver.SetActive(false);
        playButton.SetActive(false);
        ToMainGameButton.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;
        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }
    public void Pause()
    {
        // Time.timeScale = 0f;
        player.enabled = false;
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        ToMainGameButton.SetActive(true);
        if (score >= 10)//100
        {
            StaticData.valueToKeepBird = "Correct";
            SceneManager.LoadScene(2);
        }
        Pause();
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    public void BackToMainGame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
