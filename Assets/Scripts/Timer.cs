using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time;
    public bool timerEnd;

    // Start is called before the first frame update
    void Start()
    {
        time = 10f;

        StartCoroutine(TimerCountdown());
    }

    IEnumerator TimerCountdown()
    {
        return new WaitForSecondsRealtime(1);
        time -= 1;

        TimeCheck();
    }

    void TimeCheck()
    {
        if(time > 0)
        {
            StartCoroutine(TimerCountdown());
        }
        else
        {
            timerEnd = true;
        }
    }
}
