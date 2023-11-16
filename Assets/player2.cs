using UnityEngine;

public class player2 : MonoBehaviour
{
    public float Speed = 10;
    public float RotateSpeed = 10;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //always move player forward
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // transform.Translate(Vector3.left * horizontal * speed * Time.deltaTime);

        transform.RotateAround(Vector3.up, horizontal * RotateSpeed * Time.deltaTime);
        transform.Translate(Speed * Time.deltaTime * vertical * Vector3.back);
        rb.AddForce(Speed * Time.deltaTime * vertical * Vector3.back);

    }
}