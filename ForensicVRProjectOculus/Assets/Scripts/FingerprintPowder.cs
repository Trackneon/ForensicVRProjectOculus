using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerprintPowder : MonoBehaviour
{
    public GameObject fingerprint;
    public GameObject powderBrush;
    public Renderer colorRender;
    public float delay = 1f;
    public float touchNum = 0.01f;
    public void Start()
    {
       colorRender = fingerprint.GetComponent<Renderer>();
    }

    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(AddPowder());
    }

    IEnumerator AddPowder()
    {

        if (powderBrush.gameObject.tag == "powderBrush" && touchNum <= 1)
        {
            yield return new WaitForSeconds(delay);
            Color powderColor = colorRender.material.color;
            powderColor.a = touchNum;
            colorRender.material.color = powderColor;
            Debug.Log("touch num is "+touchNum);
            touchNum += 0.01f;
            yield break;
        }
        
        
        /* triggerCount += 1;
        material = materialsList[triggerCount];
        if (powderBrush.gameObject.tag == "powderBrush")
        {
            fingerprint.GetComponent<Renderer>().material = material;
        }*/
       
        
    }
}
