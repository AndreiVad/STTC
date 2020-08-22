using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextActivate : MonoBehaviour {
    int textnumber = 1;
    bool orbcount = false;
    bool killcount = false;
    private int distance = 10;

    private Transform Player;

    public static int missionorder = 1;
    public static int orbnumber;
    public static int killnumber;
	// Use this for initialization
	void Start () {

        Player = GameObject.Find("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, Player.position) < distance)
        {
            killnumber = BulletScript.kills;

            if (killnumber >= 3)
            {
                killcount = true;
            }


            if (Input.GetKeyDown("e") && (textnumber == 4))
            {

                gameObject.transform.GetChild(textnumber - 1).gameObject.SetActive(false);

                textnumber = 5;
                missionorder = 4;

            }



            if (Input.GetKeyDown("e") && (killcount == true) && (textnumber == 3))
            {

                gameObject.transform.GetChild(textnumber - 1).gameObject.SetActive(false);
                gameObject.transform.GetChild(textnumber).gameObject.SetActive(true);
                textnumber = 4;
                missionorder = 3;

            }


            if (Input.GetKeyDown("e"))
            {

                if (orbcount == true)
                {

                    if (textnumber == 2)
                    {

                        gameObject.transform.GetChild(textnumber - 1).gameObject.SetActive(false);
                        gameObject.transform.GetChild(textnumber).gameObject.SetActive(true);
                        textnumber = 3;
                        missionorder = 2;

                    }
                }
            }



            if (Input.GetKeyDown("e") && textnumber == 1)
            {

                gameObject.transform.GetChild(textnumber).gameObject.SetActive(true);
                textnumber = 2;


            }

            orbnumber = PickUp.counter;

            if (orbnumber >= 3)
            {

                orbcount = true;

            }

        }
    }
}
