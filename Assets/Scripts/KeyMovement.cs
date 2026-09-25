using UnityEngine;
using UnityEngine.InputSystem;

public class KeyMovement : MonoBehaviour
{
    public bool canUp = true;
    public bool canDown = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("KeyMovement is running");
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.upArrowKey.wasPressedThisFrame && canUp)
        {
            transform.Translate(
                0,
                10f,
                0);
            canUp = false;
            canDown = true;
        }
        if (Keyboard.current.downArrowKey.wasPressedThisFrame && canDown)
        {
            transform.Translate(
                0,
                -10f,
                0);
            canDown = false;
            canUp = true;
        }
    }
}
