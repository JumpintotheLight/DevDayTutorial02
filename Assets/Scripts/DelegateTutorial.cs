using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTutorial : MonoBehaviour {


    // Delegates are a convenient way to ...


    // public delegate is void and takes int as paramater
    // any function that is void and takes int can be used by this delegate.
    public delegate void DelegateExample(int a);

    



	// Use this for initialization
	void Start () {

        // instance of this delegate
        DelegateExample myDelegate = Bar;
        //myDelegate(5);
        Foobar(Bar);
		
	}


    void Foobar(DelegateExample myDelegate)
    {
        myDelegate(50);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Foo(int a)
    {
        // Do something
        Debug.Log("Foo: " + a);
    }

    void Bar(int a)
    {
        // Do something else
        Debug.Log("Bar " + a);

    }
}
