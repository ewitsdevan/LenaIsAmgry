using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    public bool timerEnd;

    private Slider timerSlider;

    // Start is called before the first frame update
    void Start()
    {
        time = 10f;
        timerSlider = GetComponent<Slider>();

        StartCoroutine(TimerCountdown());
    }

    IEnumerator TimerCountdown()
    {
        yield return new WaitForSecondsRealtime(1);

        time -= 1;
        timerSlider.value = time;
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
