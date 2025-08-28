using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TimeWinText;
    [SerializeField] TextMeshProUGUI timerText;
    float elapsedTime;

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timerText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds); // uhh put this in your results screen or smth idk
        TimeWinText.text = string.Format("Total Time: {0:00}:{1:00}", minutes, seconds);  
    }
}
