using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Web : MonoBehaviour
{
    public float counter;


    void Start()
    {
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 10);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            
            gameObject.SetActive(false);
            counter = 1;
        }
    }
    public void conterCheck() {
        if (counter > 0)
        {
            int slow = 1;
        }
    }

}