using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public bool upAxis = true;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, upAxis ? transform.up : transform.right, Time.deltaTime * 90f);
    }
}
