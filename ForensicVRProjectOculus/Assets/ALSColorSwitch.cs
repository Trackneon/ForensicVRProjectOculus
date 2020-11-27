using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALSColorSwitch : MonoBehaviour
{
    public List<Color> lightColors;
    public Light currentLight;
    public Color myLightColor;
    
    private void Start()
    {
        currentLight = GetComponent<Light>();
        myLightColor = GetComponent<Light>().color;
        
        //currentLight.enabled = false;
        ChangeLight();
    }
    
    public void ChangeLight()
    {
        currentLight.enabled = true;
        int i = 0;
        foreach (var light in lightColors)
        {
            if (i < lightColors.Count)
            {
                i++;
                //currentLight.color = lightColors[i];
                myLightColor = light;
                currentLight.color = myLightColor;
                Debug.Log("the light is now " + currentLight.color + "my light color is " + myLightColor);
                
            }
            else if (i >= lightColors.Count)
            {
                i = 0;
            }
        }
    }
}
