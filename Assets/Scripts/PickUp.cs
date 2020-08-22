using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public static int counter;


    void Start()
    {
    }

    void Update()
    {
       

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            counter++;
            gameObject.SetActive(false);
            
        }
    }
}
