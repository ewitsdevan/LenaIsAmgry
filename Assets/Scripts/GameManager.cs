using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject timerObject;
    private bool timerIsEnd;

    public int mouseObject;

    public int minNumber;
    public int maxNumber;

    // Start is called before the first frame update
    void Awake()
    {
        mouseObject = Random.Range(minNumber, maxNumber);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timerIsEnd = timerObject.GetComponent<Timer>().timerEnd;
    }
}
