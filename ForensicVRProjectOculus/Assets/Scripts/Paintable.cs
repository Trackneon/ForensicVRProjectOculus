using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Paintable : MonoBehaviour
{
    public GameObject powder;
    public Vector3 tipPoint;
    public Transform transform;

    /*private void Start()
    {
        transform = GetComponent<Transform>();
    }*/

    public void PaintWithPowder()
    {
        Instantiate(powder, new Vector3(), Quaternion.identity);
        Debug.Log("powdering");
    }
}
