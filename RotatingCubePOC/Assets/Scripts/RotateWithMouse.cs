using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{
    [Header("Rotation Settings")]
    [Tooltip("Sensitivity of the mouse rotation")]
    public float rotationSpeed = 5f;

    private Vector3 lastMousePosition;
    private bool isDragging = false;

    void Update()
    {
        // Check if left mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            lastMousePosition = Input.mousePosition;
        }

        // Check if left mouse button is released
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        // Rotate the cube based on mouse movement
        if (isDragging)
        {
            Vector3 delta = Input.mousePosition - lastMousePosition;
            
            // Normalize delta by screen height for resolution independence
            float normalizedDeltaX = delta.x / Screen.height;
            float normalizedDeltaY = delta.y / Screen.height;
            
            // Rotate around Y axis based on horizontal mouse movement
            transform.Rotate(Vector3.up, normalizedDeltaX * rotationSpeed * 100f, Space.World);
            
            // Rotate around X axis based on vertical mouse movement
            transform.Rotate(Vector3.right, -normalizedDeltaY * rotationSpeed * 100f, Space.World);
            
            lastMousePosition = Input.mousePosition;
        }
    }
}
