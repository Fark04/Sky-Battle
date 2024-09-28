using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void PlayGame(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }
    public void BackMenu(string MenuScene)
    {
        SceneManager.LoadScene(MenuScene);
    }
    public void ExitGame()
    {
        Debug.Log("Выход из игры...");
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
