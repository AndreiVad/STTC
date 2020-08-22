using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSwitch : MonoBehaviour {

    private Transform Player;
    // Use this for initialization
    void Start () {

        gameObject.SetActive(true);
        Player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown("e") && Vector3.Distance(transform.position, Player.position) < 10)
        {
            gameObject.SetActive(false);
            print("space key was pressed");

        }
    }
}
