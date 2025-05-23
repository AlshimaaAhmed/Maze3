using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        int level = PlayerManager.Instance.playerData.currentLevel;
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