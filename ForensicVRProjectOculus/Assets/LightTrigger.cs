using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : ALSColorSwitch
{
    public GameObject visibleByALS;
    public string colorActivate;
    void Start()
    {
        visibleByALS.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        //if (visibleByALS.gameObject.tag == "ALS" && colorActivate == "UV" && lightColors[2]==isActiveAndEnabled)
        {
            visibleByALS.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        visibleByALS.SetActive(false);
    }
}
