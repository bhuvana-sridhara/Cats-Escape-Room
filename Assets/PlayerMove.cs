using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class PlayerMove : NetworkBehaviour
{
    // Start is called before the first frame update
    public float speed = 25.0f;
    public float rotationSpeed = 90;
    public float force = 700f;

    // public AudioSource source;
    // public AudioClip audioclip;


    Rigidbody rb;
    Transform t;
    CameraScript test;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
        test = GetComponent<CameraScript>();
        // audioclip = Resources.Load<AudioClip> ("playerjump");
        // source = GetComponent<AudioSource>();
        // source.clip = audioclip;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
            return;
        if (Input.GetKey(KeyCode.W))
            rb.velocity += this.transform.forward * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.S))
            rb.velocity -= this.transform.forward * speed * Time.deltaTime;

        // Quaternion returns a rotation that rotates x degrees around the x axis and so on
        if (Input.GetKey(KeyCode.D))
            t.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
        else if (Input.GetKey(KeyCode.A))
            t.rotation *= Quaternion.Euler(0, -rotationSpeed * Time.deltaTime, 0);

        if (Input.GetKeyDown(KeyCode.Space)){
            // source.Play();
            rb.AddForce(t.up * 400);
        }

    }

    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }



}
