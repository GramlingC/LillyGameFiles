using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuScript : MonoBehaviour
{

    public Image instruction_text;
    public Image credit_text;
    public Button start;
    public Button credit;
    public Button instruction;
    public Button home;
  


    // Use this for initialization
    void Start()
    {
        start = start.GetComponent<Button>();
        credit = credit.GetComponent<Button>();
        instruction = instruction.GetComponent<Button>();
        home = home.GetComponent<Button>();


        instruction_text.enabled = false;
        credit_text.enabled = false;

    }

    public void ins_press()
    {
        instruction.enabled = true;
        start.enabled = true;
        credit.enabled = true;
        credit_text.enabled = false;
        instruction_text.enabled = true;
        home.enabled = true;

        


    }


    public void credit_press()
    {
        credit.enabled = true;
        start.enabled = true;
        instruction.enabled = true;
        credit_text.enabled = true;
        instruction_text.enabled = false;
        home.enabled = true;

    }

    public void back_home()
    {
        credit.enabled = true;
        start.enabled = true;
        instruction.enabled = true;
        credit_text.enabled = false;
        instruction_text.enabled = false;
        home.enabled = true;
    }


    public void startlevel()
    {
        Application.LoadLevel(1);

    }


}
