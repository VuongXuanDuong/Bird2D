using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    bool isEndGame;
    int gamePoint = 0;
    public Text txtPoint;
    void Start()
    {
        Time.timeScale = 0;
        isEndGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isEndGame)
        {
            // load game again
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(0);
            }
        } else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;
            }
        }
    }
    public void EndGame()
    {
        //Debug.Log("EndGame.");
        isEndGame = true;
        Time.timeScale = 0;
    }
    public void GetPoint()
    {
        gamePoint++;
        txtPoint.text = gamePoint.ToString();
    }
}
