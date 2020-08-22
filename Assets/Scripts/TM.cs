using UnityEngine;

public class TM : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    float m_Speed ;
    private Transform Player;
    private float SafeDistance = 30;
    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        m_Speed = 8;
        Player = GameObject.Find("Player").transform;
    }

    void Update()
    {

        if (Vector3.Distance(transform.position, Player.position) > SafeDistance)
        {

            Destroy(gameObject);


        }

        if (m_Speed < 8)
        {
            m_Speed = m_Speed + Time.deltaTime ;
        }
        if (Input.GetKey(KeyCode.I))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = transform.forward * m_Speed;
        }

        if (Input.GetKey(KeyCode.K))
        {
            //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = -transform.forward * m_Speed;
        }

        if (Input.GetKey(KeyCode.L))
        {
            //Rotate the sprite about the Y axis in the positive direction
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * 150, Space.World);
        }

        if (Input.GetKey(KeyCode.J))
        {
            //Rotate the sprite about the Y axis in the negative direction
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * 150, Space.World);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "web")
        {

            m_Speed = 1;

        }
    }
}