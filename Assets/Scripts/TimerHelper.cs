using UnityEngine;
using TMPro;
using System.Collections;

public class TimerHelper : MonoBehaviour
{
    public bool startTimerOnAwake = true;
    public TextMeshProUGUI timerText;
    public float time = 60;
    public bool isRunning;

    void Start()
    {
        if (timerText == null)
        {
            Debug.LogWarning("TextMeshProUGUI wasnt add it is null!!!!");
        }

        if (startTimerOnAwake)
        {
            StartTimer();
        }
    }

    public void  StartTimer()
    {
        isRunning = true;
        StartCoroutine(StartTimerCor());
    }

    public void StopTimer()
    {
        time = 0;
        isRunning = false;
        StopAllCoroutines();
    }

    IEnumerator StartTimerCor()
    {
        while (isRunning || time > 0)
        {
            timerText.text = string.Format("{0}:{1}", MinuteParse(), SecondsParse());
            if (time <= 0)
            {
                StopTimer();
            }
            --time;
            yield return new WaitForSeconds(1);
        }
    }

    #region Parse
    private string MinuteParse()
    {
        int minute = (int)time / 60;
        
        return AddZero(minute);
    }
    private string SecondsParse()
    {
        int seconds = (int)time % 60;

        return AddZero(seconds);
    }
    private string AddZero(int num)
    {
        string zero = "0";
        if (num < 10 && num >= 0)
        {
            return zero + num.ToString();
        }

        return num.ToString();
    }
    #endregion
}
