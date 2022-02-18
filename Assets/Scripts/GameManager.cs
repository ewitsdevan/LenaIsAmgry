using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject timerObject;

    public int mouseObject;

    public int minNumber;
    public int maxNumber;

    public GameObject winCanvas;
    public GameObject loseCanvas;

    public GameObject gameMusic;
    public GameObject winMusic;
    public GameObject loseMusic;
    public GameObject countdownSFX;

    // Start is called before the first frame update
    void Awake()
    {
        mouseObject = Random.Range(minNumber, maxNumber);
        
    }

    public void WinGame()
    {
        timerObject.GetComponent<Timer>().stopTimer = true;
        winCanvas.SetActive(true);
        Destroy(gameMusic);
        winMusic.SetActive(true);
        countdownSFX.SetActive(false);
    }

    public void LoseGame()
    {
        loseCanvas.SetActive(true);
        Destroy(gameMusic);
        loseMusic.SetActive(true);
        countdownSFX.SetActive(false);
    }
}
