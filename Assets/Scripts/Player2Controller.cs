using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{

    
    float speed = 5;
    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (speed < 5) {
            speed = speed + Time.deltaTime/2;
        }
        
        //Speed of movement forwards, backwords and rotation left right
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed * 2;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "web")
        {

            speed = 1;

        }
    }
}
