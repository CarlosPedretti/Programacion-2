using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejoJuego : MonoBehaviour
{
    [SerializeField] private GameObject GameOverScreen;
    public static ManejoJuego Instance { get; private set; }

    private void Awake()
    {
    
    }

    void Update()
    {


    }

    public void ShowGameOverSceen()
    {
        GameOverScreen.SetActive(true);
    }

    public void RestarScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

}