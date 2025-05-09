using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerReturnPosition : MonoBehaviour
{
    void Start()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (DatatoBeShared.ReturnPosition != Vector3.zero)
        {
            Debug.Log("⏪ رجوع اللاعب للمكان السابق: " + DatatoBeShared.ReturnPosition);
            transform.position = DatatoBeShared.ReturnPosition;


            Animator animator = GetComponent<Animator>();
            if (animator != null)
            {
                animator.ResetTrigger("Sink");
                animator.Play("Idle");
            }
        }
    }
}