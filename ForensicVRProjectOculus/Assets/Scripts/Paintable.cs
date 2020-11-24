﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Paintable : MonoBehaviour
{
    public GameObject powder;

    public void PaintWithPowder()
    {
        Instantiate(powder, Vector3.up * 0.1f, Quaternion.identity, transform);
        Debug.Log("powdering");
    }
}
