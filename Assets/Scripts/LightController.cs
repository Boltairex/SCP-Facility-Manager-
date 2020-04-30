using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{

    public bool iscontained;
    Light light;
    RaycastHit RayInfo;
    // Start is called before the first frame update
    void Start()
    {
        light = GameObject.Find("ContaimentLight").GetComponent<Light>();
        light.intensity = 0.03f;
        light.color = new Color(255, 255, 255, 255);

    }

    public void OnClick()
    {
        iscontained = !iscontained;

        if (iscontained == false)
        {
            light.color = new Color(255, 255, 255, 255);

        }
        else
        {
            light.color = new Color(255, 69, 69, 255);
        }
    }


}
