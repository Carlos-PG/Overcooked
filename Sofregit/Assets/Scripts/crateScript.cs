using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crateScript : MonoBehaviour
{

    public GameObject ingredientType;

    private GameObject sample;

    // Start is called before the first frame update
    void Start()
    {
        sample = Instantiate(ingredientType, transform.position + new Vector3(0f, 2f, 0f), ingredientType.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        sample.transform.Rotate(new Vector3(0f, 0.1f, 0f));
    }
}
