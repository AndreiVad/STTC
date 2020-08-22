using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementB : MonoBehaviour
{

    private float latestDirectionChangeTime;
    private readonly float directionChangeTime = 3f;
    private float characterVelocity = 3f;
    private Vector3 movementDirection;
    private Vector3 movementPerSecond;

    //public Transform Player;
    private Transform Player;
    int MinDist = 30;
    int Launch = 10;


    void Start()
    {
        Player = GameObject.Find("Player").transform;
        latestDirectionChangeTime = 0f;
        calcuateNewMovementVector();
    }

    void calcuateNewMovementVector()
    {
        //create a random direction vector with the magnitude of 1, later multiply it with the velocity of the enemy
        movementDirection = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
        movementPerSecond = movementDirection * characterVelocity;
    }

    void Update()
    {

        transform.LookAt(Player);

         if (Vector3.Distance(transform.position, Player.position) < MinDist)
         {

            transform.position += transform.forward * Time.deltaTime * 3;


        }
        //if the changeTime was reached, calculate a new movement vector
        else if (Vector3.Distance(transform.position, Player.position) > MinDist)
        {
            if (Time.time - latestDirectionChangeTime > directionChangeTime)
            {
                latestDirectionChangeTime = Time.time;
                calcuateNewMovementVector();
            }

            //move enemy: 
            transform.position = new Vector3(transform.position.x + (movementPerSecond.x * Time.deltaTime),
            transform.position.y + (movementPerSecond.y * Time.deltaTime), transform.position.z + (movementPerSecond.z * Time.deltaTime));

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

