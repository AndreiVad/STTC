using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{

    Animator anim;
    float speed = 5;
    float moveHash = Animator.StringToHash("Speed");
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        
        if (speed < 5) {
            speed = speed + Time.deltaTime/2;
        }
        //Speed of movement forwards, backwords and rotation left right
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 2.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float move = Input.GetAxis("Vertical");
        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKeyDown(KeyCode.W))
            anim.SetFloat("Speed", 2);
        if (Input.GetKeyUp(KeyCode.W))
            anim.SetFloat("Speed", 0);


        if (Input.GetKeyDown(KeyCode.S))
            anim.SetFloat("Speed", -1);
        if (Input.GetKeyUp(KeyCode.S))
            anim.SetFloat("Speed", 0);

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "web")
        {
            
            speed = 1;
            
        }
    }
}