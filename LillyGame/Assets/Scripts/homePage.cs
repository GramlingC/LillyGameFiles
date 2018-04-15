using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homePage : MonoBehaviour {

	// Use this for initialization
    public void home_page()
    {
        SceneManager.LoadScene("StartLevel");
    }
}
