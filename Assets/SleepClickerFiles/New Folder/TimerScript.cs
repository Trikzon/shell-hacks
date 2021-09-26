using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float timeValue = 7.0f;
    public Text timerText;

    public GameObject forTimerContinue;
    bool timerBreak;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timerBreak = forTimerContinue.GetComponent<overCheck>().timerBreak;
        Debug.Log(timerBreak);
        if (timeValue > 0 && !timerBreak)
        {
            timeValue -= Time.deltaTime;
        }
        else if (timerBreak) { }
        else
        {
            timeValue = 0;
        }
        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        timerText.text = string.Format("{0:00}", timeToDisplay);
    }
}
