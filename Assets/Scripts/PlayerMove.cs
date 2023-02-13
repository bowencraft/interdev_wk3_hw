using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D LlegBody;
    public Rigidbody2D RlegBody;
    Rigidbody2D mainBody;

    public float power;
    public AudioSource mySource;
    public AudioClip jumpClip;

    // Start is called before the first frame update
    void Start()
    {
        mainBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //mySource.PlayOneShot(jumpClip);
            LlegBody.AddForce(transform.up * power, ForceMode2D.Impulse);
            mainBody.velocity = new Vector3(-power, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //mySource.clip = jumpClip;
            //mySource.Play();
            RlegBody.AddForce(transform.up * power, ForceMode2D.Impulse);
            mainBody.velocity = new Vector3(power, 0, 0);

        }
        //LlegBody.GetComponent<BoxCollider2D>()

        if (true) {

            if (Input.GetKeyDown(KeyCode.W))
            {
                LlegBody.AddForce(transform.up * power, ForceMode2D.Impulse);
                RlegBody.AddForce(transform.up * power, ForceMode2D.Impulse);
                mainBody.velocity = new Vector3(0, 0.5f * mainBody.gravityScale * power, 0);

            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                mainBody.velocity = new Vector3(0, -power, 0);

            }
        }
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    mainBody.velocity = new Vector3(-power, 0, 0);

        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    mainBody.velocity = new Vector3(power, 0, 0);

        //}
    }


    void OnCollisionEnter2D(Collision2D collision) {
        {
            if (collision.collider.gameObject.tag.Equals("Floor"))
                Debug.Log("开始碰撞" + collision.collider.gameObject.name);
        }
    }
}
