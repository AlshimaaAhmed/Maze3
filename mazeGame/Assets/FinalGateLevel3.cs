using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalGateTrigger : MonoBehaviour
{
    public string nextSceneName = "TR222";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            if (PlayerManager.Instance.playerData.keys >= 12)
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
}
