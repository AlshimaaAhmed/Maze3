using UnityEngine;
using UnityEngine.SceneManagement;

public class RiddleAnswerChecker : MonoBehaviour
{
    public AudioSource correctAnswerSound;
    public AudioSource wrongAnswerSound;

    public void OnAnswerClicked(string selectedAnswer)
    {
        if (PlayerManager.Instance == null)
        {
            Debug.LogError("❌ PlayerManager is null!");
            return;
        }

        string returnSceneName = "Level " + PlayerManager.Instance.playerData.currentLevel.ToString();

        if (selectedAnswer == DatatoBeShared.CorrectAnswer)
        {
            PlayerManager.Instance.AddKey(); 
            Debug.Log("✅ Correct Answer - Key Added");

            if (correctAnswerSound != null)
                correctAnswerSound.Play();

            SceneManager.LoadScene(returnSceneName);
        }
        else
        {
            PlayerManager.Instance.TakeDamage(1); 
            Debug.Log("❌ Wrong Answer - Heart Removed");

            if (wrongAnswerSound != null)
                wrongAnswerSound.Play();
        }
    }
}

