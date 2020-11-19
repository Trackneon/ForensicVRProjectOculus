using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerprintPowder : MonoBehaviour
{
    public GameObject fingerprint;
    public GameObject powderBrush;
    public Renderer colorRender;

    public void Start()
    {
       colorRender = fingerprint.GetComponent<Renderer>();
    }

    public void OnTriggerEnter(Collider other)
    {
        AddPowder();
    }

    public void AddPowder()
    {
        if (powderBrush.gameObject.tag == "powderBrush")
        {
            for (float touchNum = 0.1f; touchNum <= 1; touchNum += 0.1f)
            {
                Color powderColor = colorRender.material.color;
                powderColor.a = touchNum;
                colorRender.material.color = powderColor;
                Debug.Log("touch num is "+touchNum);
                
            }
        }
        
        
        /* triggerCount += 1;
        material = materialsList[triggerCount];
        if (powderBrush.gameObject.tag == "powderBrush")
        {
            fingerprint.GetComponent<Renderer>().material = material;
        }*/
       
        
    }
}
