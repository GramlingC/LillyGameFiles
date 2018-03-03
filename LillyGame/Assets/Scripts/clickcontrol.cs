using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickcontrol : MonoBehaviour {

    public static string nameofobj;
    public GameObject objnametext;
    public Transform successclick;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        nameofobj = gameObject.name;
        /* for debugging porposes
          Debug.Log(nameofobj); */
        Destroy(gameObject);
        Destroy(objnametext);
        //Particle effect where text used to be
        Instantiate(successclick, objnametext.transform.position, successclick.rotation);
    }
}
