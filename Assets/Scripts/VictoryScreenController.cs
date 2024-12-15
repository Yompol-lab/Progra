using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScreenController : MonoBehaviour
{
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void RetryButton()
    {
        SceneManager.LoadScene("Action");
    }



    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("El juego se cerró."); // Solo funca en unity
    }

}
