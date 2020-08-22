using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAttack : MonoBehaviour
{
    private Transform Player;
    int MinDist = 50;
    int Launch = 20;
    public GameObject spawn;
    public GameObject spawner;
    public float time = 3;
    public float amount = 2;
    GameObject spawnClone;
    // Use this for initialization
    void Start()
    {
        Player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()

    {
        time -= Time.deltaTime;
        if (time < 0) {
            if (amount > 0)
            {
                if (Vector3.Distance(transform.position, Player.position) < Launch)
                {
                    spawnClone = Instantiate(spawn, spawner.transform.position, spawner.transform.rotation) as GameObject;
                    time = 3;
                    transform.position += transform.forward * Time.deltaTime;
                    amount--;
                    
                }
            }

        }

        Destroy(spawnClone, 5);
    }
}
