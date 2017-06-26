using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

    public delegate void ClickAction();
    public static event ClickAction OnClicked;


    // deathEvent is an instance of DeathDelegate, 
    // event called whenever player dies
    // events are same as delegates but have restrictions
    // Restrictions mean we can no longer assign directly to the delegate
    // Objects outside of event delegate definition can only subscribe / unscubscribe
    // Objects outside of event delegate definition can not invoke the delegate

    public delegate void DeathDelegate();
    public static event DeathDelegate deathEvent;

    private void OnGUI()
    {
        if(GUI.Button(new Rect(Screen.width/2 - 50, 5, 100, 30), "Click"))
        {
            if (OnClicked != null)
                OnClicked();

        }


        if (GUI.Button(new Rect(Screen.width / 2 - 50, 55, 100, 30), "Die"))
        {
            if (deathEvent != null)
                deathEvent();
        }


    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
