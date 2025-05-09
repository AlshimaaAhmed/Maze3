using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEndScene : MonoBehaviour
{
    public Transform cameraTransform;
    public float lookUpAngle = -90f;
    public float rotationSpeed = 2f;
    private bool startRotation = false;

    void Update()
    {
        if (startRotation)
        {
            Vector3 targetRotation = new Vector3(lookUpAngle, cameraTransform.eulerAngles.y, cameraTransform.eulerAngles.z);
            cameraTransform.rotation = Quaternion.Slerp(cameraTransform.rotation, Quaternion.Euler(targetRotation), rotationSpeed * Time.deltaTime);

            float angleDifference = Mathf.DeltaAngle(cameraTransform.eulerAngles.x, lookUpAngle);

            if (Mathf.Abs(angleDifference) < 1f)
            {
                SceneManager.LoadScene("EndScene");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            startRotation = true;
        }
    }
}
