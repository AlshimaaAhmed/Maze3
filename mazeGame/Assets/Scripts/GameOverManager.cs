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
        PlayerManager.Instance.AddLife();
        PlayerManager.Instance.AddLife();
        PlayerManager.Instance.AddLife();
        PlayerManager.Instance.AddLife();
        PlayerManager.Instance.AddLife();

        DatatoBeShared.ReturnPosition = Vector3.zero;
        SceneManager.LoadScene(Lastscene);
    }
}
