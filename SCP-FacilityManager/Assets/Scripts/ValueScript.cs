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
    Button floorselector;
    public static RaycastHit RayInfo;
    public bool isselected;
    public Sprite selected;
    public Sprite notselected;


    void Start()
    {
        isselected = false;
        fundsvalue = GameObject.Find("FundsValue").GetComponent<Text>();
        researchvalue = GameObject.Find("ScienceValue").GetComponent<Text>();
        floorselector = GameObject.Find("FloorImage").GetComponent<Button>();
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

    public void OnClickFloor()
    {
        if (isselected == true)
        {
            floorselector.image.sprite = notselected;
            isselected = false;

        } else if (isselected == false)
        {
            floorselector.image.sprite = selected;
            isselected = true;
        }
    }
}
