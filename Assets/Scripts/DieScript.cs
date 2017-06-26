using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieScript : MonoBehaviour {

    private void OnEnable()
    {
        EventManager.deathEvent += Die;

    }


    private void OnDisable()
    {
        EventManager.deathEvent -= Die;

    }


    void Die()
    {
        Destroy(this.gameObject);
    }

}

