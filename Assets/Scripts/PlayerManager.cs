using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public static bool isGameStarted;
    public GameObject startingText;
    public static int numberOfCoins;
    public Text coinsNum;
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
        numberOfCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            Time.timeScale = 0;
            FindObjectOfType<AudioManager>().StopSound("Step");
            gameOverPanel.SetActive(true);
        }
        coinsNum.text = "Coins: " + numberOfCoins;
        if(Input.anyKeyDown)
        {
            isGameStarted = true;
            Destroy(startingText);
        }
    }
}
