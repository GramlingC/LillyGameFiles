﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseLillySprite : MonoBehaviour {
    public LillyHideSprite lillySprite; //gameobject with script must be referenced in editor
    public GameObject spriteOptions; //to reference self
    public int spriteChoice, levelNumber;//Allows different values for each level's rating
    public AudioSource AudioSource;
    SpriteRenderer spriteRenderer;
    Collider2D m_Collider;


    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        m_Collider = GetComponent<Collider2D>();
        m_Collider.enabled = false;
        spriteRenderer.color = Color.black;
        PlayerPrefs.SetInt("rewardAnimal_0", 1);// Always start with default skin available

        //if player passed the level they get a new sprite option
        if (PlayerPrefs.GetInt("rewardAnimal_" + levelNumber) == 1)
        {
            m_Collider.enabled = true;
            spriteRenderer.color = Color.white;
        }
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
