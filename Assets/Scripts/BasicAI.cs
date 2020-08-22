using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicAI : MonoBehaviour {
    private Transform target;
    public Transform myTransform;

    public Text deathText;
    private void Start()
    {
        target = GameObject.Find("Player").transform;
    }


    void Update () {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "player")
        {
            Destroy(collision.gameObject);
            deathText.text = "You died";

        }
    }
}
