using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float smoothing = 0.125f;
    public Vector3 offset;
    public Vector3 lookOffset;
    public Vector3 velocity;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        
        Vector3 desiredPosition = target.position + target.forward*offset.x + target.up * offset.y;
        //Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition,ref velocity, smoothing);
        transform.position = smoothedPosition;
        //transform.Translate(smoothedPosition);
        transform.LookAt(target.position + lookOffset);
    }
}
