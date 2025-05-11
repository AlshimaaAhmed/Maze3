using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        if (audioSource != null)
        {
            audioSource.Play();
        }

    }

    public void BackToMenu()
    {
        if (PlayerManager.Instance.playerData.lives < 5) {
            for (int i = 0; i < 5; i++)
            {
                PlayerManager.Instance.AddLife();
            }
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

