using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseLillySprite : MonoBehaviour {
    public LillyHideSprite lillySprite; //gameobject with script must be referenced in editor
    public int spriteChoice;
    public AudioSource AudioSource; 

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {

        lillySprite.sprite = spriteChoice;
        PlayerPrefs.SetInt("Lilly", lillySprite.sprite);
        lillySprite.ChangeSprite();
        AudioSource.Play();

    }
}
