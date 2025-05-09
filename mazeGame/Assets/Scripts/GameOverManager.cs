using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    [Header("Buttons")]
    public Button backToMenuButton;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true; 
        
        if (backToMenuButton != null)
            backToMenuButton.onClick.AddListener(BackToMenu);
        else
            Debug.LogWarning("BackToMenuButton is not assigned in the inspector.");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
