using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FinalInstruction : MonoBehaviour {

    public Text Instruction1,Instruction2;
    public bool Display;
	void Start () {
        Display = false;
        Instruction1.text = "";
        Instruction2.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        if(Display)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Display = false;
                RemoveInstruction();
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Display = true;
            AddInstruction();
        }
    }
    void RemoveInstruction()
    {
        Instruction1.text = "";
        Instruction2.text = "";
    }
    void AddInstruction()
    {
        Instruction1.text = "You have Reached Final Stage, Look For Tresure to win! ";
        Instruction2.text = "Press Q to start";

    }
}
