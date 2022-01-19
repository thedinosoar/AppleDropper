using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public float speed = 6.0f;
    public AppleTree spawner;

    public TextMesh counter;
    private int applesCollected = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        
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
            counter.text = applesCollected++.ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        transform.LookAt(spawner.transform.position-Vector3.up*spawner.transform.position.y+ Vector3.up *transform.position.y);
        var moveDirection = Input.GetAxis("Horizontal");
        transform.Translate( Vector3.right*moveDirection* Time.deltaTime*speed);
    }
}
