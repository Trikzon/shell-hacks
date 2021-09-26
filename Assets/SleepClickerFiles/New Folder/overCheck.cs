using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class overCheck : MonoBehaviour
{
    public GameObject personHeightGetter;
    public GameObject person;
    public GameObject emoticon;

    public Text timerText;
    public GameObject toDestroy;
    public Text toChange;
    float timeLeft;
    float yValue;

    public bool timerBreak = false;

    public string winText = "YOU WIN";
    public string loseText = "YOU FAIL YOUR EXAMS";


    // Start is called before the first frame update
    void Start()
    {
        emoticon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft = timerText.GetComponent<TimerScript>().timeValue;
        yValue = personHeightGetter.transform.position.y;

        if ((timeLeft > 0) && (yValue <= -0.22))           //time isnt up and you fell
        {
            Destroy(toDestroy);
            toChange.text = loseText;
            timerBreak = true;
            emoticon.SetActive(true);

        }
        else if ((timeLeft <= 0) && !(yValue <= -0.22))     //time is up and you didnt fall
        {
            Destroy(toDestroy);
            toChange.text = winText;
            person.GetComponent<Rigidbody2D>().freezeRotation = true;
        }
        else if ((timeLeft <= 0) && (yValue <= -0.22))      //time is up and you fell
        {
            Destroy(toDestroy);
            toChange.text = loseText;
            timerBreak = true;
            emoticon.SetActive(true);
        }
       

    }

}
