using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class promptsounds : MonoBehaviour {

    private AudioSource AudioSource;

    // Use this for initialization
    void Start () {

        AudioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        AudioSource.Play();
    }

}
