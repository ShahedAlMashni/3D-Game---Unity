using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalEnemy : MonoBehaviour {
    private bool Goright;
    private float move=0.05f;
	// Use this for initialization
	void Start () {
        Goright = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x >= -35) Goright = false;
        if (transform.position.x <= -45) Goright = true;
        if (Goright) transform.position += new Vector3(move, 0, 0);
        else transform.position += new Vector3(-move, 0, 0);

    }
}
