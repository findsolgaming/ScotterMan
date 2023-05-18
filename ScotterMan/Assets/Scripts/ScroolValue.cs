using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ScroolValue : MonoBehaviour
{
    public Slider slide;
    public TMP_Text Number;
    public GameObject pan;
    public GameObject LobbyPanel;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FillScroll());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator FillScroll()
    {
        slide.value += 1;
        Number.text =((slide.value)).ToString() +" %";
        yield return new WaitForSeconds(0.03f);
        if(slide.value >= 100f)
        {
            StopCoroutine(FillScroll());
            LobbyPanel.SetActive(true);
            pan.SetActive(false);
            
        }
        else
        {
            StartCoroutine(FillScroll());
        }
        
    }
}
