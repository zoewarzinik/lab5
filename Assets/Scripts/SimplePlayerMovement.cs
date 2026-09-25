using UnityEngine;
using UnityEngine.InputSystem;
public class SimplePlayerMovement : MonoBehaviour
{
    public float moveForce = 20f;
    private Rigidbody rb;
    private Vector3 moveDirection;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        moveDirection = Vector3.zero;
        if (Keyboard.current == null)
            return;
        if (Keyboard.current.wKey.isPressed)
            moveDirection += Vector3.forward;
        if (Keyboard.current.sKey.isPressed)
            moveDirection += Vector3.back;
        if (Keyboard.current.aKey.isPressed)
            moveDirection += Vector3.left;
        if (Keyboard.current.dKey.isPressed)
            moveDirection += Vector3.right;
        moveDirection = moveDirection.normalized;
    }
    void FixedUpdate()
    {
        rb.AddForce(moveDirection * moveForce, ForceMode.Acceleration);
    }
}