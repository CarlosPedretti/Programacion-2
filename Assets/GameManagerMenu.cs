using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Audio;

public class GameManagerMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Dino Game");
    }

    public void Exit()
    {
        Debug.Log("Exit...");
        Application.Quit();
    }
}
