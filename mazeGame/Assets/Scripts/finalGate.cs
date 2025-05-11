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
                DatatoBeShared.ReturnPosition = Vector3.zero;
                SceneManager.LoadScene(nextSceneName);
            }
            else if (currentKeys >= 7 && PlayerManager.Instance.playerData.currentLevel == 2)
            {
                DatatoBeShared.ReturnPosition = Vector3.zero;
                SceneManager.LoadScene(nextSceneName);
            }
            else if (currentKeys >= 12 && PlayerManager.Instance.playerData.currentLevel == 3)
            {
                DatatoBeShared.ReturnPosition = Vector3.zero;
                SceneManager.LoadScene(nextSceneName);
            }
            else
            {
                Debug.Log("You need 3 keys to enter!");
            }
        }
    }
}