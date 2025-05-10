using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalGate : MonoBehaviour
{
    public string nextSceneName = "Leveling up";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int currentKeys = PlayerManager.Instance.playerData.keys;

            if (currentKeys >= 3 && PlayerManager.Instance.playerData.currentLevel == 1)
            {
                SceneManager.LoadScene(nextSceneName);
            }
            else if (currentKeys >= 7 && PlayerManager.Instance.playerData.currentLevel == 2)
            {
                SceneManager.LoadScene(nextSceneName);
            }
            else if (currentKeys >= 7 && PlayerManager.Instance.playerData.currentLevel == 3)
            {
                SceneManager.LoadScene(nextSceneName);
            }
            else
            {

            }
        }
    }
}