using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tableScript : MonoBehaviour
{

    public GameObject ingredientType;
    public GameObject processedFoodType;
    private GameObject item;
    public GameObject itemObj;
    public GameObject board;
    public bool hasBoard;
    public bool hasItem;
    public bool canProcess;

    // Start is called before the first frame update
    void Start()
    {
        if (hasBoard)
        {
            GameObject obj = Instantiate(board, transform.position + new Vector3(0, 0.22f, 0), transform.rotation);
            obj.transform.parent = this.gameObject.transform;
            hasItem = false;
            canProcess = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void placeFood(string name)
    {
        item = Instantiate(itemObj, transform.position + new Vector3(0f, 0.731f, 0f), ingredientType.transform.rotation);
        Item itemScript = item.gameObject.GetComponent<Item>();
        itemScript.createFoodByName(name);
        hasItem = true;
        canProcess = true;
    }

    public void processFood()
    {
        Debug.Log("A punto de procesar");
        Item itemScript = item.GetComponent<Item>();
        itemScript.processFood();
        canProcess = false;
    }

    public string pickUpFood()
    {
        string name = item.GetComponent<Item>().food.tag;
        Destroy(item);
        hasItem = false;
        return name;
    }

    public bool itemIsProcesable()
    {
        return true;
    }

    public bool mixItems(string name)
    {
        Debug.Log("Llega" + name);
        return item.GetComponent<Item>().mixFood(name);
    }
}