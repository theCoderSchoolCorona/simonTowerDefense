using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void MainMenu() 
    {
        SceneManager.LoadScene("MainMenu");
    }
}
