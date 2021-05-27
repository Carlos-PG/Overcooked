using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //Base ingredients
    public GameObject apple;
    public GameObject strawberry;
    public GameObject carrot;
    public GameObject potato;
    public GameObject cucumber;
    public GameObject mushroom;
    public GameObject egg;
    public GameObject onion;
    public GameObject flour;
    public GameObject fish;

    //Processed ingredients
    public GameObject processedApple;
    public GameObject processedStrawberry;
    public GameObject processedCarrot;
    public GameObject processedPotato;
    public GameObject processedCucumber;
    public GameObject processedMushroom;
    public GameObject processedEgg;
    public GameObject processedOnion;
    public GameObject processedFish;

    //Recipe base
    public GameObject tortilla;
    public GameObject cake;
    public GameObject water;

    //Final recipe
    public GameObject appleCake;
    public GameObject strawberryCake;
    public GameObject carrotCake;
    public GameObject potatoTortilla;
    public GameObject cucumberTortilla;
    public GameObject mushroomTortilla;
    public GameObject onionSoup;
    public GameObject fishSoup;

    public GameObject food;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createFoodByName(string name)
    {
        Debug.Log(name);
        if (name == "Apple")
        {
            if (food != null) Destroy(food);
            food = Instantiate(apple, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "Strawberry")
        {
            if (food != null) Destroy(food);
            food = Instantiate(strawberry, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "Carrot")
        {
            if (food != null) Destroy(food);
            food = Instantiate(carrot, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "Potato")
        {
            if (food != null) Destroy(food);
            food = Instantiate(potato, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "Cucumber")
        {
            if (food != null) Destroy(food);
            food = Instantiate(cucumber, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "Mushroom")
        {
            if (food != null) Destroy(food);
            food = Instantiate(mushroom, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "Egg")
        {
            if (food != null) Destroy(food);
            food = Instantiate(egg, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "Onion")
        {
            if (food != null) Destroy(food);
            food = Instantiate(onion, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "Flour")
        {
            if (food != null) Destroy(food);
            food = Instantiate(flour, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "Fish")
        {
            if (food != null) Destroy(food);
            food = Instantiate(fish, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "processedApple")
        {
            if (food != null) Destroy(food);
            food = Instantiate(processedApple, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "processedStrawberry")
        {
            if (food != null) Destroy(food);
            food = Instantiate(processedStrawberry, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "processedCarrot")
        {
            if (food != null) Destroy(food);
            food = Instantiate(processedCarrot, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "processedPotato")
        {
            if (food != null) Destroy(food);
            food = Instantiate(processedPotato, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "processedCucumber")
        {
            if (food != null) Destroy(food);
            food = Instantiate(processedCucumber, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "processedMushroom")
        {
            if (food != null) Destroy(food);
            food = Instantiate(processedMushroom, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "processedEgg")
        {
            if (food != null) Destroy(food);
            food = Instantiate(processedEgg, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "processedOnion")
        {
            if (food != null) Destroy(food);
            food = Instantiate(processedOnion, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "processedFish")
        {
            if (food != null) Destroy(food);
            food = Instantiate(processedFish, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "Cake")
        {
            if (food != null) Destroy(food);
            food = Instantiate(cake, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "Tortilla")
        {
            if (food != null) Destroy(food);
            food = Instantiate(tortilla, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "Water")
        {
            if (food != null) Destroy(food);
            food = Instantiate(water, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "appleCake")
        {
            if (food != null) Destroy(food);
            food = Instantiate(appleCake, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "strawberryCake")
        {
            if (food != null) Destroy(food);
            food = Instantiate(strawberryCake, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "carrotCake")
        {
            if (food != null) Destroy(food);
            food = Instantiate(carrotCake, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "potatoTortilla")
        {
            if (food != null) Destroy(food);
            food = Instantiate(potatoTortilla, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "cucumberTortilla")
        {
            if (food != null) Destroy(food);
            food = Instantiate(cucumberTortilla, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "mushroomTortilla")
        {
            if (food != null) Destroy(food);
            food = Instantiate(mushroomTortilla, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "onionSoup")
        {
            if (food != null) Destroy(food);
            food = Instantiate(onionSoup, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
        else if (name == "fishSoup")
        {
            if (food != null) Destroy(food);
            food = Instantiate(fishSoup, transform.position, transform.rotation);
            food.transform.parent = transform;
        }
    }

    public void processFood()
    {
        string type = food.tag;
        Debug.Log(type);
        if(type == "Apple")
        {
            StartCoroutine(ChangeModel(processedApple));
        }
        else if (type == "Strawberry")
        {
            StartCoroutine(ChangeModel(processedStrawberry));
        }
        else if (type == "Carrot")
        {
            StartCoroutine(ChangeModel(processedCarrot));
        }
        else if (type == "Potato")
        {
            StartCoroutine(ChangeModel(processedPotato));
        }
        else if (type == "Cucumber")
        {
            StartCoroutine(ChangeModel(processedCucumber));
        }
        else if (type == "Mushroom")
        {
            StartCoroutine(ChangeModel(processedMushroom));
        }
        else if (type == "Egg")
        {
            StartCoroutine(ChangeModel(processedEgg));
        }
        else if (type == "Onion")
        {
            StartCoroutine(ChangeModel(processedOnion));
        }
        else if (type == "Fish")
        {
            StartCoroutine(ChangeModel(processedFish));
        }
    }

    IEnumerator ChangeModel(GameObject processedFood)
    {
        Debug.Log("procesando...");
        yield return new WaitForSeconds(4);
        Destroy(food);
        food = Instantiate(processedFood, transform.position, transform.rotation);
        food.transform.parent = transform;
        Debug.Log("procesado");
    }

    public bool mixFood(string name)
    {
        Debug.Log("Mezclando: " + name + " con: " + food.tag);
        if((name == "processedEgg" && food.tag == "Flour") || (name == "Flour" && food.tag == "processedEgg"))
        {
            Destroy(food);
            food = Instantiate(cake, transform.position, transform.rotation);
            food.transform.parent = transform;
            return true;
        }
        else if ((name == "processedEgg" && food.tag == "processedOnion") || (name == "processedOnion" && food.tag == "processedEgg"))
        {
            Destroy(food);
            food = Instantiate(tortilla, transform.position, transform.rotation);
            food.transform.parent = transform;
            return true;
        }
        else if ((name == "Tortilla" && food.tag == "processedPotato") || (name == "processedPotato" && food.tag == "Tortilla"))
        {
            Destroy(food);
            food = Instantiate(potatoTortilla, transform.position, transform.rotation);
            food.transform.parent = transform;
            return true;
        }
        else if ((name == "Tortilla" && food.tag == "processedCucumber") || (name == "processedCucumber" && food.tag == "Tortilla"))
        {
            Destroy(food);
            food = Instantiate(cucumberTortilla, transform.position, transform.rotation);
            food.transform.parent = transform;
            return true;
        }
        else if ((name == "Tortilla" && food.tag == "processedMushroom") || (name == "processedMushroom" && food.tag == "Tortilla"))
        {
            Destroy(food);
            food = Instantiate(mushroomTortilla, transform.position, transform.rotation);
            food.transform.parent = transform;
            return true;
        }
        else if ((name == "processedApple" && food.tag == "Cake") || (name == "Cake" && food.tag == "processedApple"))
        {
            Destroy(food);
            food = Instantiate(appleCake, transform.position, transform.rotation);
            food.transform.parent = transform;
            return true;
        }
        else if ((name == "processedStrawberry" && food.tag == "Cake") || (name == "Cake" && food.tag == "processedStrawberry"))
        {
            Destroy(food);
            food = Instantiate(strawberryCake, transform.position, transform.rotation);
            food.transform.parent = transform;
            return true;
        }
        else if ((name == "processedCarrot" && food.tag == "Cake") || (name == "Cake" && food.tag == "processedCarrot"))
        {
            Destroy(food);
            food = Instantiate(carrotCake, transform.position, transform.rotation);
            food.transform.parent = transform;
            return true;
        }
        else if ((name == "processedFish" && food.tag == "Water") || (name == "Water" && food.tag == "processedFish"))
        {
            Destroy(food);
            food = Instantiate(fishSoup, transform.position, transform.rotation);
            food.transform.parent = transform;
            return true;
        }
        else if ((name == "processedOnion" && food.tag == "Water") || (name == "Water" && food.tag == "processedOnion"))
        {
            Destroy(food);
            food = Instantiate(onionSoup, transform.position, transform.rotation);
            food.transform.parent = transform;
            return true;
        }
        return false;
    }
}
