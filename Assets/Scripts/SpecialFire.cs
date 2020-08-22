using UnityEngine;
using System.Collections;

public class SpecialFire : MonoBehaviour
{
    public GameObject Bullet_Emitter;
    public GameObject Bullet;
    public float Bullet_Forward_Force;
    float time = 1;
    void Start()
    {

    }

    void Update()
    {
        time -= Time.deltaTime;
        if (Input.GetKeyDown("z") && time <= 0)
        {
            //The Bullet instantiation happens here.
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;


            //Retrieve the Rigidbody component from the instantiated Bullet and control it.
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            //Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force.
            Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);

            //Bullets disappear after 3 seconds
            Destroy(Temporary_Bullet_Handler, 3.0f);
            time = 10;
        }
    }

}