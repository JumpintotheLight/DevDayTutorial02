using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public delegate void DeathDelegate();

    // deathEvent is an instance of DeathDelegate, 
    // event called whenever player dies
    // events are same as delegates but have restrictions
    // Restrictions mean we can no longer assign directly to the delegate
    // Objects outside of event delegate definition can only subscribe / unscubscribe
    // Objects outside of event delegate definition can not invoke the delegate

    public static event DeathDelegate deathEvent;


    // We could also use an Action
    // Action is a delegate with void return type, no paramters
    // Action<T>, Action<T1, T2>, ...
    // Delegate with void return type and custom parameters


    // Func can be used to create a delegate with a custom return type and no parameters
    // Func can also be used to create a delegate with custom return type and parameters

    // Func<int, string, bool> myDelegate;
    // is the same as:
    // delegate bool MyDelegate(int a, string b);
    // MyDelegate myDelegate; 

    void Die()
    {
        if(deathEvent != null)
        {
            // Destroy player object
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
