using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalEnemy : MonoBehaviour {

    private bool GoUp;
    private float move = 0.05f;
    // Use this for initialization
    void Start()
    {
        GoUp= true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 8f) GoUp = false;
        if (transform.position.y <= 4f) GoUp = true;
        if (GoUp) transform.position += new Vector3(0, move, 0);
        else transform.position += new Vector3(0,-move, 0);

    }
}
