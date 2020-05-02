using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueScript : MonoBehaviour
{
    static public float funds = 0.00f;
    static public float research = 0.00f;
    Text fundsvalue;
    Text researchvalue;
    
    void Start()
    {
        

        fundsvalue = GameObject.Find("FundsValue").GetComponent<Text>();
        researchvalue = GameObject.Find("ScienceValue").GetComponent<Text>();
        



    }


    void Update()
    {
        fundsvalue.text = funds.ToString();
        researchvalue.text = research.ToString();


    }

    public void OnAddFunds()
    {
        funds++;
    }

    public void OnAddResearch()
    {
        research++;
    }
}
