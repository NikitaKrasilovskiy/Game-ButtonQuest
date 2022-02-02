using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeMinutes : MonoBehaviour
{
    float seconds = 30, minutes;
    public TextMeshProUGUI timeText;
    public GameObject smert;
    void Update()
    {
        seconds = seconds - Time.deltaTime;
        
        timeText.text = Math.Ceiling(minutes) + ":" + Math.Ceiling(seconds);

        if ( seconds <= 0)
        {
            SceneManager.LoadScene("Dead");
        }
    }
}
