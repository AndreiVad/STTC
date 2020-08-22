using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIText : MonoBehaviour
{
    int textnumber = 1;
    bool orbcount = false;
    bool killcount = false;

    public static int orbnumber;
    public static int killnumber;
    public static int questnumber;
    // Use this for initialization
    void Start()
    {
        gameObject.transform.GetChild(3).gameObject.SetActive(true);
    }



    // Update is called once per frame
    void LateUpdate()
    {

        questnumber = TextActivate.missionorder;

        killnumber = BulletScript.kills;

        if (killnumber >= 3)
        {
            killcount = true;
        }





        if (Input.GetKeyDown("e") && (killcount == true) && (textnumber == 3) && questnumber == 3)
        {
            gameObject.transform.GetChild(textnumber - 1).gameObject.SetActive(false);
            
            textnumber = 4;
            

        }

        if (Input.GetKeyDown("e"))
        {

            if (orbcount == true)
            {

                if (textnumber == 2 && questnumber == 2)
                {
                    gameObject.transform.GetChild(textnumber - 1).gameObject.SetActive(false);
                    gameObject.transform.GetChild(textnumber).gameObject.SetActive(true);
                    textnumber = 3;
                   

                }
            }
        }



        if (Input.GetKeyDown("e") && textnumber == 1 && questnumber == 1)
        {
            gameObject.transform.GetChild(textnumber).gameObject.SetActive(true);
            textnumber = 2;

            print(orbcount);
            print(killcount);

        }

        orbnumber = PickUp.counter;

        if (orbnumber == 3)
        {
            orbcount = true;
        }


    }
}
