using System;
using System.Threading.Tasks;
using UnityEngine;

public class CubeCreator : MonoBehaviour
{
    public static MaterialContainer MC;
    public GameObject PrefabBlock;
    public Vector3 Vec;
    public int Mater;

    static GameObject PrefabBlockStat;

    private void Awake()
    {
        MC = GameObject.Find("DataContainer").GetComponent<MaterialContainer>();
        PrefabBlockStat = PrefabBlock;
        Vector3 NewPosition = new Vector3(0, 0, 0);
        CreateBlock(NewPosition, 1);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            CreateBlock(Vec, Mater);
        }

        if (!MC)
        {
            MC = GameObject.Find("DataContainer").GetComponent<MaterialContainer>();
        }
    }

    public static void CreateBlock(Vector3 position, int matID)
    {
        GameObject Block = Instantiate(PrefabBlockStat); 
        Block.transform.position = position;
        Block.name = MC.MatContainer[matID].Name;
        Block.GetComponent<MeshRenderer>().material = MC.MatContainer[matID].MyMaterial;
    }
}
