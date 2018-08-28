using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LillyHideSprite : MonoBehaviour {

    SpriteRenderer LillySprite;
    BoxCollider2D Collider2D;
    public Sprite Lilly, Lilly2, Lilly3, Lilly4, Lilly5;
    public int sprite;
    public movetowards movetowards;

	// Use this for initialization
	void Start () {
        sprite = PlayerPrefs.GetInt("Lilly", sprite);
        LillySprite = GetComponent<SpriteRenderer>();
        LillySprite.enabled = false;
        Collider2D = GetComponent<BoxCollider2D>();
        Collider2D.enabled = false;
        ChangeSprite(); //start the game with the chosen sprite
    }
	
	// Update is called once per frame
	void Update () {
		if (movetowards.hintready == "y")
        {
            LillySprite.enabled = true;
            Collider2D.enabled = true;
        }
        else
        {
            LillySprite.enabled = false;
            Collider2D.enabled = false;
        }

    }

    public void OnMouseDown()
    {
        movetowards.OnMouseDown();
    }
    public void ChangeSprite () //change sprite to reference placed in game editor
    {

        if (PlayerPrefs.GetInt("Lilly", sprite) == 1)
        {
            LillySprite.sprite = Lilly;
        }

        if (PlayerPrefs.GetInt("Lilly", sprite) == 2)
        {
            LillySprite.sprite = Lilly2;
        }

        if (PlayerPrefs.GetInt("Lilly", sprite) == 3)
        {
            LillySprite.sprite = Lilly3;
        }
        if (PlayerPrefs.GetInt("Lilly", sprite) == 4)
        {
            LillySprite.sprite = Lilly4;
        }
        if (PlayerPrefs.GetInt("Lilly", sprite) == 5)
        {
            LillySprite.sprite = Lilly5;
        }
    }
}
