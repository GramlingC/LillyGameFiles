using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontDestroy : MonoBehaviour {

    //These are your Scene names. Make sure to set them in the Inspector window
    public string m_StartLevel, m_Level_Select, m_Skins_Select;
    AudioSource audioSource;
    bool audioPlaying;
    Scene m_Scene;

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
        m_Scene = SceneManager.GetActiveScene();
        audioSource = GetComponent <AudioSource>();
        audioPlaying = true;




    }
    private void Update()
    {


        //Return the current Active Scene in order to get the current Scene's name
        m_Scene = SceneManager.GetActiveScene();
        //Debug.Log(m_Scene.name);

        if (m_Scene.name != m_Level_Select && m_Scene.name != m_Skins_Select && m_Scene.name != m_StartLevel)
        {
            if (audioPlaying == true)
            {
                audioSource.Stop();
                Debug.Log("Audio Paused");
                audioPlaying = false;
            }
        }

        if (m_Scene.name == m_Level_Select || m_Scene.name == m_Skins_Select || m_Scene.name == m_StartLevel)
        {
            if (audioPlaying == false)
            {
                audioSource.Play();
                Debug.Log("Audio Playing");
                audioPlaying = true;
            }
        }
    }
}
