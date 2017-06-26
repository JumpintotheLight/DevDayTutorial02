using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiDelegateTutorial : MonoBehaviour 
{

    // One of the cool features of delegates is that you can subscribe multiple actions to each delegate.

    delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;


    void Start()
    {
        myMultiDelegate += PowerUp;
        myMultiDelegate += TurnRed;

        if (myMultiDelegate != null)
        {
            myMultiDelegate();
        }
    }

    void PowerUp()
    {
        print("Orb is powering up!");
    }

    void TurnRed()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}