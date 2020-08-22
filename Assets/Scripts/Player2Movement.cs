using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour {
    int speed = 2;
    public float RotateSpeed = 30f;


    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
       

        if (Input.GetKey("i"))
        {
            pos.z += speed * Time.deltaTime * 5 ;
        }
        if (Input.GetKey("k"))
        {
            pos.z -= speed * Time.deltaTime * 2 ;
        }
        

        if (Input.GetKey(KeyCode.J))

            transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime * 3);

        else if (Input.GetKey(KeyCode.L))

            transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime * 3);

        transform.position = pos;
    }
}
