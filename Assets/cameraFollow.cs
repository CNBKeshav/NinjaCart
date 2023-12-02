using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform LookTarget;
    public float speed = 1;
    public Transform MoveTarget;
    public float LeftoverFireStable;
    // Start is called before the first frame update
    void Start()
    {
        transform.parent = null;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.DrawRay(transform.position, (LookTarget.position - transform.position).normalized * Time.deltaTime * speed, Color.red);
        //transform.position += (MoveTarget.position - transform.position).normalized * Time.deltaTime * speed;
        transform.position = Vector3.Lerp(transform.position, MoveTarget.position, LeftoverFireStable);
        //transform.Translate((FollowTarget.position - transform.position).normalized * Time.deltaTime * speed);
        transform.rotation = Quaternion.LookRotation(LookTarget.position - transform.position, Vector3.up);
    }
}
