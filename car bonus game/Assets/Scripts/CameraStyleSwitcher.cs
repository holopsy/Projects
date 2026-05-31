using UnityEngine;

public class CameraStyleSwitcher : MonoBehaviour
{
    public Transform target; // The car to follow

    public Vector3 chaseOffset = new Vector3(0, 5, -10);
    public Vector3 topDownOffset = new Vector3(0, 15, 0);

    private int currentMode = 0;
    private Vector3 currentOffset;

    public float followSpeed = 5f;

    void Start()
    {
        currentOffset = chaseOffset;
    }

    void Update()
    {
        // Switch camera mode on key press
        if (Input.GetKeyDown(KeyCode.C))
        {
            currentMode = (currentMode + 1) % 2;

            if (currentMode == 0)
                currentOffset = chaseOffset;
            else
                currentOffset = topDownOffset;
        }
    }

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + currentOffset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);

        if (currentMode == 0)
            transform.LookAt(target); // Look at car in chase view
        else
            transform.rotation = Quaternion.Euler(90f, 0f, 0f); // Top-down fixed view
    }
}