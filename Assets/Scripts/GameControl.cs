using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameControl : MonoBehaviour
{
    public Text GameOverText;
    public Text countText;
    private int count;
    private bool restart;
    public Text StartText1;
    public Text StartText2;
    void Start()
    {
        count = 0;
        restart = false;
        GameOverText.text = "";
        AddInstructionStart();
        countText.text = "Count: " + count.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.R))
            {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Application.LoadLevel(Application.loadedLevel);
            }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartText1.text = "";
            StartText2.text = "";
        }
        
    }

    public void Addscore()

    {
        count += 100;
        countText.text = "Count: " + count.ToString();
    }
    public void DecreaseScore()
    {
        count -= 20;
        if (count <= 0) GameOver();
        countText.text = "Count: " + count.ToString();
    }
    void GameOver()

    {
        GameOverText.text = "Game Over!...Press R for restart";
        restart = true;
    }
    public bool GameMode()
    {
        return restart;
    }
    public void Win()
    {
        GameOverText.text = "You Won!...Press R for restart";
        restart = true;
    }
    void AddInstructionStart()
    {
        StartText1.text = "Use arrows for movement, Space for Jump, Good Luck :D";
        StartText2.text = "Press Q to start";

    }
}
