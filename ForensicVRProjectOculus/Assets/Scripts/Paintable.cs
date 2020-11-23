using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Paintable : MonoBehaviour
{
    public GameObject powder;

    public void PaintWithPowder()
    {
        var go = Instantiate(powder, Vector3.up * 0.1f, Quaternion.identity, transform);
    }
}
