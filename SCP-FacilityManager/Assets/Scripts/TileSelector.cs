using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSelector : MonoBehaviour
{
    public Material Selector;
    public static RaycastHit RayInfo;

    void Update()
    {
        Ray Rayy = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(Rayy, out RayInfo))
        {
            Debug.DrawLine(Camera.main.transform.position, RayInfo.point);
        }
    }
}
