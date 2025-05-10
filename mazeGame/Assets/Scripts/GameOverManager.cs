using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    private string Lastscene = DatatoBeShared.LastScene;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

       

    }

    public void BackToMenu()
    {
        if (PlayerManager.Instance.playerData.lives < 5) { 
            PlayerManager.Instance.playerData.lives = 5;
            PlayerData.SaveData(PlayerManager.Instance.playerData);
        }
        SceneManager.LoadScene("MainMenuScene");
    }
}
/*
    public void BackToMenu()
    {
        for (int i = 0; i < 5; i++) { 
            PlayerManager.Instance.AddLife();
    }

        DatatoBeShared.ReturnPosition = Vector3.zero;
        SceneManager.LoadScene(Lastscene);
    }
    */

