using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour {

    private void OnEnable()
    {
        EventManager.OnClicked += Teleport;

    }


    private void OnDisable()
    {
        EventManager.OnClicked -= Teleport;

    }


    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.x = Random.Range(1.0f, 3.0f);
        pos.y = Random.Range(1.0f, 3.0f);
        pos.z = Random.Range(1.0f, 3.0f);
        transform.position = pos;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
