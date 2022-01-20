using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public float speed = 6.0f;
    public AppleTree spawner;

    public TextMesh counter;

    private int applesCollected = 0;
    private Vector3 center;
    //[SerializeField]
    //private Transform leftArrow;
    //[SerializeField]
    //private Transform rightArrow;
    // Start is called before the first frame update
    void Start()
    {
        center = spawner.transform.position - Vector3.up * spawner.transform.position.y;
    }


    void OnCollisionEnter(Collision collision)
    {
        
        //play sound
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "apple")
        {
            Destroy(other.gameObject);
            applesCollected++;
            counter.text = applesCollected.ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {
        //Vector3 nearestApple = GameObject.FindGameObjectWithTag("apple").transform.position;

        //float leftDistance = (nearestApple - leftArrow.position).magnitude;
        //float rightDistance = (nearestApple - rightArrow.position).magnitude;

        //if (leftDistance < rightDistance)
        //{
        //    leftArrow.localScale = Vector3.one * Mathf.Clamp(Mathf.Pow(leftDistance + .5f, 2), 5, 35);
        //    rightArrow.localScale = Vector3.zero;
        //}
        //else
        //{
        //    rightArrow.localScale = Vector3.one * Mathf.Clamp(Mathf.Pow(rightDistance + .5f, 2), 5, 35);
        //    leftArrow.localScale = Vector3.zero;
        //}


        //Debug.DrawLine(leftArrow.position, nearestApple);
        //Debug.DrawLine(rightArrow.position, nearestApple);
        //var forwardMovement = Input.GetAxis("Vertical");
        transform.LookAt(spawner.transform.position-Vector3.up*spawner.transform.position.y+ Vector3.up *transform.position.y);
        
        //transform.Translate(Vector3.forward * forwardMovement * Time.deltaTime * speed);
        
        
        
        var moveDirection = Input.GetAxis("Horizontal");
        transform.Translate( Vector3.right*moveDirection* Time.deltaTime*speed);
    }
}
