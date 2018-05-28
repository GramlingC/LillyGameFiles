using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ne_Level : MonoBehaviour {
    
    public GameObject Next_Level;
    public int max_level;
    public string num_level;
    public static int thelevel;
    public int t;
	// Use this for initialization
	void Start () {
        
        thelevel = PlayerPrefs.GetInt("thelevel", thelevel);
       
	}
	
	void Update()
    {
        for (int i =1; i < max_level; i++)
        {
            if (LevelUnlocked.level == i)
            {
                Next_Level.SetActive(true);
            }
        }
    }
    public static void the_level(int t)
    {
        thelevel = t;
        PlayerPrefs.SetInt("thelevel", thelevel);
    }
    public void next()
    {
        LevelUnlocked.Next_Level();
        //Tim S. - I changed Application.LoadLevel to SceneManager.LoadScene
        SceneManager.LoadScene("Level_Select");
    }
    public void _level()
    {
        the_level(t);
        //Tim S. - I changed Application.LoadLevel to SceneManager.LoadScene
        SceneManager.LoadScene(num_level);
        
    }
    //void OnTriggerEnter2D(Collider2D other)
    //{
     //   Next_Level.SetActive(true);
   // }
    
}
