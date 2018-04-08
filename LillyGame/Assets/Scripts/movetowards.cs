using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetowards : MonoBehaviour
{

    public Transform target;
    public float speed;
    public GameObject trail;
    Vector3 originalPos;
    public static string hintready = "n";
    public static string hintused = "n";
    Collider m_Collider;

    // Use this for initialization
    void Start()
    {
        //Remember where it started
        originalPos = gameObject.transform.position;
        m_Collider = GetComponent<Collider>();
        m_Collider.enabled = !m_Collider.enabled;
        GetComponent<Animator>().SetFloat("Speed", speed);
    }

    // Update is called once per frame
    void Update()
    {
        //move towards a specfied position
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        //check if object has reached its destination
        if (gameObject.transform.position == target.position)
        {
            //"Stop" the object and enable clicking and hints
            GetComponent<Animator>().SetFloat("Speed", 0);
            m_Collider.enabled = true;
            hintready = "y";
        }
    }

    //Reset the position and Restart the animation
    void ResetPosition()
    {
        gameObject.transform.position = originalPos;
        GetComponent<Animator>().SetFloat("Speed", speed);
        //make the trail of yarn "disappear"
        foreach (YarnTrail yt in trail.GetComponentsInChildren<YarnTrail>())
        {
            yt.resetTrail();
        }

    }

    void OnMouseDown()
    {
        //Use the hint and reset
        hintused = "y";
        hintready = "n";
        ResetPosition();
        m_Collider.enabled = !m_Collider.enabled;
    }

}
