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
            
            // Rotate around Y axis based on horizontal mouse movement
            transform.Rotate(Vector3.up, delta.x * rotationSpeed * Time.deltaTime, Space.World);
            
            // Rotate around X axis based on vertical mouse movement
            transform.Rotate(Vector3.right, -delta.y * rotationSpeed * Time.deltaTime, Space.World);
            
            lastMousePosition = Input.mousePosition;
        }
    }
}
