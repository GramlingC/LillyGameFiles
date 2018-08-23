using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void SkinsScene()
    {
        movetowards.hintready = "n"; //Make sure gameobj of lilly is hidden
        SceneManager.LoadScene("Skins_Select");
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene("Level_Select");
    }
}
