using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGameOverWindowHelper : MonoBehaviour
{

    public void RestartLevel()
    {
        ResumeGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);       
    }

    public void GoMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void ResumeGame()
    {
        Debug.Log("GameResume");
        Time.timeScale = 1f;
    }

    public void PauseGame()
    {
        Debug.Log("GamePaused");
        Time.timeScale = 0f;
    }
}
