using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeButton : MonoBehaviour
{
    public GameObject resumeButton;

    public void BackToMainMenu(){
         SceneManager.LoadSceneAsync(0);
    }
}
