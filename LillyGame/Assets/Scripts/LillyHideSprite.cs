using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LillyHideSprite : MonoBehaviour {

    SpriteRenderer LillySprite;

	// Use this for initialization
	void Start () {
		LillySprite = GetComponent<SpriteRenderer>();
        LillySprite.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		if (movetowards.hintready == "y")
        {
            LillySprite.enabled = true;
        }
        else
        {
            LillySprite.enabled = false;
        }
	}
}
