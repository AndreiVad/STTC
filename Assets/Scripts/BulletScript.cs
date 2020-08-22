using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public static int kills;
    public static int bossHP;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "enemy")
        { 
            kills++;
            Destroy(collision.gameObject);

            gameObject.SetActive(false);
        }

        if (collision.transform.tag == "boss")
        {

            bossHP++;

            gameObject.SetActive(false);
        }


    }
}
