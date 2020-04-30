using UnityEngine;
using System;

public class MaterialContainer : MonoBehaviour
{
    [Serializable]
    public struct Materials
    {
        public string Name; //Material Name
        public Material MyMaterial;
    }

    [SerializeField]
    public Materials[] MatContainer;
}

