using UnityEngine;
using UnityEngine.InputSystem;

public class RotatingObstacle : MonoBehaviour
{
    public float rotationSpeed = 90f;
    public bool isActive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("RotatingObstacle is running");
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            isActive = !isActive;
        }
        if (isActive)
        {
            transform.Rotate(
                0f,
                rotationSpeed * Time.deltaTime,
                rotationSpeed * Time.deltaTime);
        }
    }
}
