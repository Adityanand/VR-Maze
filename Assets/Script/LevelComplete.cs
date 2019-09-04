using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour {
    public float Timer;
    public float TimeConsume;
    public GameObject StartPoint;
    public GameObject EndPoint;
    public bool TimerStart;
    public bool LevelComp;
    public Text TimerGUI;
    public Text TimeTaken;
    public GameObject LevelFailed;
    public GameObject LevelCompleted;
	// Use this for initialization
	void Start () {
        Timer = 300.0f;
	}
	
	// Update is called once per frame
	void Update () {
        TimerGUI.text = ("Timer:" + Mathf.Floor(Timer) + " Sec");
		if(TimerStart==true)
        {
            Timer -= 1 * Time.deltaTime;
        }
        if(Timer<=1.0f)
        {
            GetComponent<Movement>().enabled = false;
            LevelFailed.GetComponent<Canvas>().enabled = true;
            TimerStart = false;
        }
        if((TimerStart==false) &&(LevelComp==true))
        {
            TimeConsume = 300 - Timer;
            GetComponent<Movement>().enabled = false;
            LevelCompleted.GetComponent<Canvas>().enabled = true;
            TimeTaken.text = ("You get out of the maze in " + Mathf.Floor(TimeConsume)+" Seconds");
        }
	}
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == StartPoint)
        {
            TimerStart = true;
        }
        if(col.gameObject==EndPoint)
        {
            TimerStart = false;
            LevelComp = true;
        }
    }
}
