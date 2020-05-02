using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CubeCreator;

public class SimpleTerrainGenerator : MonoBehaviour
{
    public int Lenght;
    public int Material;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Generate(Lenght, Material);
        }
    }

    public void Generate(int Lenght, int Mat)
    {
        for (int i = 0; i < Lenght; i++)
        {
            Vector3 Yes = new Vector3(i * 0.40f, 0, 0);
            CreateBlock(Yes, Mat);
        }
    }
}
