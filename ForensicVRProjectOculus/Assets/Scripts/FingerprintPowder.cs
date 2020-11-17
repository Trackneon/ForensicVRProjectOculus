using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerprintPowder : MonoBehaviour
{
    public Material material;
    public List<Material> materialsList;
    public int triggerCount = 0;
    
    public void AddPowder()
    {
        triggerCount += 1;
        material = materialsList[triggerCount];
    }
}
