using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pop_up_window : MonoBehaviour {

    public GameObject window_instruction;
    public GameObject window_credit;
    public Button home;
    void Start()
    {
        home = home.GetComponent<Button>();
    }
    public void Show_ins(string message){
		//messageField.text = message;
		window_instruction.SetActive (true);
        window_credit.SetActive(false);
        
    }

    public void Show_cre(string message)
    {
        //messageField.text = message;
        window_instruction.SetActive(false);
        window_credit.SetActive(true);
        
    }
    public void Hide(){
        window_instruction.SetActive(false);
        window_credit.SetActive(false);
    }

    public void backhome()
    {
        
        window_instruction.SetActive(false);
        window_credit.SetActive(false);
    }

}
