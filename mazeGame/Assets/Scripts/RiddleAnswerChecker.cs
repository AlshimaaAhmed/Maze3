using UnityEngine;
using UnityEngine.SceneManagement;

public class RiddleAnswerChecker : MonoBehaviour
{
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
            PlayerManager.Instance.AddKey(); // إضافة مفتاح
            Debug.Log("✅ Correct Answer - Key Added");
            SceneManager.LoadScene(returnSceneName);
        }
        else
        {
            PlayerManager.Instance.TakeDamage(1); // خسارة قلب
            Debug.Log("❌ Wrong Answer - Heart Removed");
        }
    }

    // التحقق من الضغط على الأرقام 1 إلى 4 من لوحة المفاتيح
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))  // إذا تم الضغط على الرقم 1
        {
            Debug.Log("Pressed 1");
            OnAnswerClicked("Answer1");  // اجعلها إجابة 1
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))  // إذا تم الضغط على الرقم 2
        {
            OnAnswerClicked("Answer2");  // اجعلها إجابة 2
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))  // إذا تم الضغط على الرقم 3
        {
            OnAnswerClicked("Answer3");  // اجعلها إجابة 3
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))  // إذا تم الضغط على الرقم 4
        {
            OnAnswerClicked("Answer4");  // اجعلها إجابة 4
        }
    }
}
