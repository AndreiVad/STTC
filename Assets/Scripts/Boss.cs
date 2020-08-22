using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Transform Player;
    private int health;
    private int AttackRange = 30;
    // Use this for initialization
    void Start()
    {
        Player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(Player);

        health = BulletScript.bossHP;

        if (Vector3.Distance(transform.position, Player.position) < AttackRange)
        {

            transform.position += transform.forward * Time.deltaTime * 7;

        }
        print(health);
        if (health >= 10)
        {
            Destroy(gameObject);
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            Destroy(collision.gameObject);


        }
    }
}
