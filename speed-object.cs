using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed / Timer: MonoBehaviour {
    
    
    // The speed and duration of the object
    public float speed = 8f;
    public float lifeDuration = 2f;

    private float lifeTimer;

    // Use this for initialization
    void OnEnable () {
        lifeTimer = lifeDuration;
    }
    
    // Update is called once per frame
    void Update () {
        // Make the object move.
        transform.position += transform.forward * speed * Time.deltaTime;

        // Check if the object should be destoryed.
        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f) {
            gameObject.SetActive (false);
        }
    }
}
