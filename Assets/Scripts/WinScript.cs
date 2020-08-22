using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour {


    bool orbcount = false;

    private Transform Player;

    public static int orbnumber;
    // Use this for initialization
    void Start () {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        Player = GameObject.Find("Player").transform;

    }
	
	// Update is called once per frame
	void Update () {
        orbnumber = PickUp.counter;

        if (orbnumber == 5 && Vector3.Distance(transform.position, Player.position) < 10)
        {

            orbcount = true;

        }

        if (orbcount)
        {

            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Time.timeScale = 0.0f;

        } 
    }
}
