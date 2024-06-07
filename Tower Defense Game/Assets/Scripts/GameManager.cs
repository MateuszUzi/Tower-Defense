using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static bool gameIsOver;

    public GameObject gameOverUI;

    public string nextLevel = "Level 02";
    public int levelToUnlock = 2;

    public SceneFader sceneFader;

    void Start ()
    {
        gameIsOver = false;
    }

    void Update() {
        if (gameIsOver) 
            return;

        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }
    void EndGame()
    {
        gameIsOver = true;
        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {
        Debug.Log("LEVEL WON!");
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
        sceneFader.FadeTo(nextLevel);
    }
}
