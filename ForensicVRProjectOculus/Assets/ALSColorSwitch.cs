using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALSColorSwitch : MonoBehaviour
{
    public GameObject alsLight;
    public List<Color> lightColors;
    public Light currentLight;
    public Color myLightColor;
    public float delay = 0f;
    public int triggerPress = 0;
    
    private void Start()
    {
        currentLight = GetComponent<Light>();
        currentLight.enabled = false;
    }
    
    public void ChangeLight()
    {
        currentLight.enabled = true;
        StartCoroutine(LightChange());
        triggerPress += 1;
        if (triggerPress > lightColors.Count)
        {
            triggerPress = 0;
        }
    }

    public void TurnOffLight()
    {
        currentLight.enabled = false;
        triggerPress = 0;
    }

    IEnumerator LightChange()
    {
        //int i = 0;
        if(currentLight.enabled == true)
        {
            myLightColor = lightColors[triggerPress];
            alsLight.GetComponent<Light>().color = myLightColor;
            Debug.Log("the light is now " + currentLight.color + "my light color is " + myLightColor);
        }
        yield return new WaitForSeconds(delay);
    }
}
