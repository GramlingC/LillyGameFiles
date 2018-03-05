using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickcontrol : MonoBehaviour {
    public static string nameofobj;
    public GameObject objnametext;
    public Transform objnametextPos;
    public Transform sucessclick;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        nameofobj = gameObject.name;
        //Debug.Log(nameofobj);
        Destroy(gameObject);
        Destroy(objnametext);
        trackingclicks.totalclicks = 0;
        Instantiate(sucessclick, objnametextPos.position, sucessclick.rotation);
    }
}
