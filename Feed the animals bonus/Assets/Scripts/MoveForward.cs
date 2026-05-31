using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 40;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed );
    }
}
