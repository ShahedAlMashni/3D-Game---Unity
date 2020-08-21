using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMov : MonoBehaviour {
    public Vector3 mov, start;
    public float jump;
    public float force=7f;
    private bool isJumping = false;
    public Rigidbody rb;
    public GameControl tmp;
    public GameObject DeathParticle;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        mov = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
        }
    }

    void FixedUpdate()
    {
        if (!tmp.GameMode())
        {
            rb.AddForce(mov * force *Time.deltaTime);
            if (isJumping == true && Physics.Raycast(transform.position, new Vector3(0, -1, 0), 1))
            {
                rb.AddForce(new Vector3(0, jump, 0));
                isJumping = false;
            }
            if (!Physics.Raycast(transform.position, new Vector3(0, -1, 0), 1)) rb.AddForce(new Vector3(0, -jump * 0.01f, -jump * 0.01f));
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Ground" || other.transform.tag == "Spikes" || other.transform.tag == "Enemy")
        {
            Instantiate(DeathParticle, transform.position, Quaternion.identity);
            transform.position = start;
            tmp.DecreaseScore();

        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CheckPoint")
        {
            start = other.transform.position;
            tmp.Addscore();
            Destroy(other.gameObject);
        }
        if (other.tag == "Goal")
        {
            tmp.Win();
        }

    }
 


}
