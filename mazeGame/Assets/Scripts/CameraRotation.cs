using UnityEngine;
using UnityEngine.EventSystems;

public class CameraRotation : MonoBehaviour
{
    public Transform player;
    public float sensitivity = 2f;
    public float maxVerticalAngle = 45f;

    private float verticalRotation = 0f;
    private bool isRotating = false;

    void Update()
    {
        // ❗ Stop rotating if hovering over UI
        if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
        {
            isRotating = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            return;
        }

        // 👇 Enable rotation on right-click
        if (Input.GetMouseButtonDown(1))
        {
            isRotating = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        // 👆 Stop rotation when releasing right-click
        if (Input.GetMouseButtonUp(1))
        {
            isRotating = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if (!isRotating) return;

        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        player.Rotate(Vector3.up * mouseX);

        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -maxVerticalAngle, maxVerticalAngle);
        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }
}