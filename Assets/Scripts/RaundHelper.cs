using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaundHelper : MonoBehaviour
{
    private TimerHelper timer;
    public GameObject GameOverWindow;

    private bool gameEnded = false;
    // Start is called before the first frame update
    void Start()
    {
        timer = Camera.main.GetComponent<TimerHelper>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnded)
        {
            return;
        }
        if (timer.time <= 0)
        {
            gameEnded = true;
            EndRaund();
        }
        
    }

    private void EndRaund()
    {
        Time.timeScale = 0f;
        GameOverWindow.SetActive(true);      
    }
}
