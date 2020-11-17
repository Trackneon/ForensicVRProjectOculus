using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerprintPowder : MonoBehaviour
{
    public Material material;
    public List<Material> materialsList;
    public int triggerCount = 0;
    public GameObject fingerprint;
    public GameObject powderBrush;

    public void Start()
    {
        material = fingerprint.GetComponent<Renderer>().material;
    }

    public void AddPowder()
    {
        triggerCount += 1;
        material = materialsList[triggerCount];
        if (powderBrush.gameObject.tag == "powderBrush")
        {
            fingerprint.GetComponent<Renderer>().material = material;
        }
        
    }
}
