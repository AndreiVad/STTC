using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestActivation : MonoBehaviour {

    bool activated = true;
    int active;

	// Use this for initialization
	void Start () {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown("tab"))
        {
            if (active == 1)

            {
                gameObject.transform.GetChild(0).gameObject.SetActive(false);
                activated = false;
                
            }
        }

        if (Input.GetKeyDown("tab") && active == 2)

        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            activated = true;
            
        }

        if (activated == true)
        {
            active = 1;
        }

        else active = 2;

    }
}
