using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalGateTrigger : MonoBehaviour
{
    public string nextSceneName = "TR222";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
