using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public Vector3 direction = new Vector3(1, 0, 0);
    public float speed = 30f;
    private float startTime = 0f;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.forward = direction;//new Vector3(1,0,0);
        startTime = Time.time;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime > speed / 2f)
        {
            transform.position = startPos;
            startTime = Time.time;
        }
        else
            transform.position += (direction) * Time.deltaTime * speed;
    }
}
