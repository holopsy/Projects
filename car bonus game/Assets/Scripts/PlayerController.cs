using UnityEngine;

public class CarController : MonoBehaviour
{
    public string horizontalInput = "Horizontal";
    public string verticalInput = "Vertical";
    public float speed = 10f;
    public float turnSpeed = 100f;

    private float moveInput;
    private float turnInput;

    void Update()
    {
        moveInput = Input.GetAxis(verticalInput);
        turnInput = Input.GetAxis(horizontalInput);

        transform.Translate(Vector3.forward * speed * moveInput * Time.deltaTime);
        transform.Rotate(Vector3.up, turnSpeed * turnInput * Time.deltaTime);
    }
}