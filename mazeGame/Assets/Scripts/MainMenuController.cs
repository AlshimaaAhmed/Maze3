using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("LevelsShow");
    }

    public void OpenShop()
    {
        DatatoBeShared.LastScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("shop");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}