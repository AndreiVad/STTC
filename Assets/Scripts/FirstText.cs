using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstText : MonoBehaviour {

    private Transform Player;
    float playerDistance = 10;
    // Use this for initialization
    void Start () {
        Player = GameObject.Find("Player").transform;
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(transform.position, Player.position) < playerDistance)
        {

            Destroy(gameObject,1);


        }
    }
}
