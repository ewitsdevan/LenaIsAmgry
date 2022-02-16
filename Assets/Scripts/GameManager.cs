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

    // Start is called before the first frame update
    void Awake()
    {
        mouseObject = Random.Range(minNumber, maxNumber);
    }

    public void WinGame()
    {
        timerObject.GetComponent<Timer>().stopTimer = true;
        winCanvas.SetActive(true);
    }

    public void LoseGame()
    {
        loseCanvas.SetActive(true);
    }
}
