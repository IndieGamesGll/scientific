using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartMainLoka()
    {
        SceneManager.LoadScene("MainLokaGame");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
