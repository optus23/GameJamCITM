using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Timer {
    enum State { runTime, finalFrame, endTime};

    State timerState;
    private float startTime;
    private bool countDown = false;
    private float countDownTime;
    public bool finalFrame = false;

    public Timer()
    {
        startTime = 0.0F;
        timerState = State.runTime;
    }

    public void StarTimer()
    {
        startTime = Time.time;
    }

    public float GetCurrentTime()
    {
        if (countDown)
        {
            float time = countDownTime - ((Time.time - startTime));

            if (time < 0)
            {
                if (timerState == State.runTime)
                {
                    timerState = State.finalFrame;
                }
                else
                {
                    timerState = State.endTime;
                }

                return 0.0f;
            }

            return time;
        }
        else
        {
            return (Time.time - startTime);
        }
    }

    public void SetCountDown(float time)
    {
        countDownTime = time;
        countDown = true;
    }

    public bool IsFinalFrame()
    {
        return timerState == State.finalFrame;
    }
}
