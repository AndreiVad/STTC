using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCOrientation : MonoBehaviour {
    private Transform target;
	// Use this for initialization
	void Start () {
        target = GameObject.Find("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target); 
	}
}
