using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class MenuScript : MonoBehaviour
{
    public Image BackTekstu; // Kiedy obiekt będzie istnieć od początku do końca, ta metoda jest wygodniejsza i lepsza dla optymalizacji

    TMP_Text ToJaTekst;

    Scrollbar WajchaMaga;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        ToJaTekst = GameObject.Find("ToJa").GetComponent<TMP_Text>();
        WajchaMaga = GameObject.Find("Scrollbar").GetComponent<Scrollbar>();
    }

    void Update()
    {
        BackTekstu.color = new Color(0, 0, 0, WajchaMaga.value);
    }

    public void KlikajFrajerze()
    {
        Debug.Log("Siema to ja debug log");
        print("Siema to ja print");
    }
}
