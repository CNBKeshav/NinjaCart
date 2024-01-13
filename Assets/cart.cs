using UnityEngine;

public class cart : MonoBehaviour
{
    public Transform cartObj;
    public float Acceleration = 1;
    public float RotateSpeed = 10;
    public bool isPlayer2;
    private float Speed;
    private Rigidbody rb;

    void Start()    
    {
        rb = GetComponent<Rigidbody>();
        Speed = 0;
    }

    void FixedUpdate()
    {
        float horizontal;
        float vertical;
        
        




        //always move player forward
        if (isPlayer2)
        {
            horizontal = Input.GetAxisRaw("Horizontal1");
            vertical = Input.GetAxisRaw("Vertical1");
        }
        else
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
            Debug.Log(horizontal + "-" + vertical);
        }


        if (vertical != 0)
        {
            Speed += Acceleration * vertical;
        }
        else
        {
            if (Speed > 0) 
            {
                Speed -= Acceleration;
            }   
            else if (Speed < 0) 
            {
                Speed += Acceleration;
            }
        }
        Debug.Log(Speed);



        // transform.Translate(Vector3.left * horizontal * speed * Time.deltaTime);
        transform.RotateAround(Vector3.up, horizontal * RotateSpeed * Time.deltaTime);
        transform.Translate(Speed * Time.deltaTime * Vector3.back);
        rb.AddForce(Speed * Time.deltaTime * vertical * Vector3.back);
        if (cartObj)
        {
            Vector3 forward = transform.TransformDirection(Vector3.back);
            Vector3 toCart = cartObj.position - transform.position;
            //Debug.Log(Vector3.Dot(forward, toCart));
            if (Vector3.Dot(Vector3.up, transform.up) < 0)
            {
                Debug.Log("flipped");
                cartObj.rotation = Quaternion.Euler(0, 0, 0);
            }
                
        }
    }
}