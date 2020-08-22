using UnityEngine;
using System.Collections;

public class Melee : MonoBehaviour
{

    float time = 1;
    float activeTime = 1;
    void Start()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    void Update()
    {
        time -= Time.deltaTime;
        if (Input.GetKeyDown("x") && time <= 0)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            activeTime = 1;
            time = 10;
        }
        activeTime -= Time.deltaTime;
        if (activeTime <= 0) {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }

}