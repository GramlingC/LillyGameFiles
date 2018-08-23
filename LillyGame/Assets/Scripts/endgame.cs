using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endgame : MonoBehaviour {
    public GameObject nextlevel_panel;
    public LillyHideSprite lillySprite; //gameobject with script must be referenced in editor
    public int levelNumber;//Allows different values for each level's rating

    private AudioSource introSource;//Allows random clip to play from array
    public AudioClip[] introClips;
    private AudioClip intro;

    private AudioSource praiseSource;//Allows random clip to play from array
    public AudioClip[] praiseClips;
    private AudioClip praise;
    private int i; //So that AudioSource doesn't keep trying to play, because it's being called on Update


    // Use this for initialization
    void Start ()   {
        praiseSource = gameObject.GetComponent<AudioSource>();
        i = 0;
        introSource = gameObject.GetComponent<AudioSource>();

        nextlevel_panel.SetActive(false);
        lillySprite.sprite = PlayerPrefs.GetInt("Lilly", lillySprite.sprite);
        
        //Play intros
        int introIndex = Random.Range(0, introClips.Length); //Pick random int within array range
        intro = introClips[introIndex]; // set audioclip variable
        introSource.clip = intro; // set audiosource
        introSource.Play(); //Play Intro


    }
	
	// Update is called once per frame
	void Update () {
        //End Game if all tagged objects are gone
        if (GameObject.FindGameObjectsWithTag("TargetObject").Length <= 0)
        {
            if (i <= 0) //ONLY PLAY ONCE
            {
                //Play Praises
                int praiseIndex = Random.Range(0, praiseClips.Length); //Pick random int within array range
                praise = praiseClips[praiseIndex]; // set audioclip variable
                praiseSource.clip = praise; // set audiosource
                praiseSource.Play(); //Play Praises
                i++;
            }
            //activate the "Next Level" prompt
            nextlevel_panel.SetActive(true);
            PlayerPrefs.SetInt("rewardAnimal_" + levelNumber, 1);

        }

    }

}
