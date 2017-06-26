using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : MonoBehaviour {

	// Use this for initialization
	void Start () {

        // Get a reference to the Player class and subscribe OnPlayerDeath method.
        PlayerController.deathEvent += OnPlayerDeath;
	}

    public static void OnPlayerDeath()
    {
        PlayerController.deathEvent -= OnPlayerDeath;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
