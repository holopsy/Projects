using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotateSpeed;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotateSpeed * Time.deltaTime, Space.World);
    }
}
