using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class orderControllerLevel5 : MonoBehaviour
{
    private float totalTime = 180;
    private int recipesToWin = 5;
    private int handedRecipes = 0;
    private int recipesCreated = 1;
    private float timeToNextItem = 15;

    public Canvas canvas;
    public Text countDownText;
    public Text endRoundText;

    public Text namePanel1;
    public Text text1Panel1;
    public Text text2Panel1;
    public Text text3Panel1;
    public Text timeLeftPanel1;

    public Text namePanel2;
    public Text text1Panel2;
    public Text text2Panel2;
    public Text text3Panel2;
    public Text timeLeftPanel2;

    public Text namePanel3;
    public Text text1Panel3;
    public Text text2Panel3;
    public Text text3Panel3;
    public Text timeLeftPanel3;

    struct order
    {
        public float timeToEnd;
        public string finalRecipe;
        public string UIName;
        public List<string> ingredients;

        public order(int time, string recipe, string name, List<string> ingredients)
        {
            this.timeToEnd = time;
            this.finalRecipe = recipe;
            this.UIName = name;
            this.ingredients = new List<string>(ingredients);
        }
    };

    private List<order> currentOrders;

    private List<string> finalRecipes = new List<string>() { "mushroomTortilla", "cucumberTortilla", "potatoTortilla", "appleCake", "strawberryCake", "carrotCake", "onionSoup", "fishSoup" };
    private List<string> UINames = new List<string>() { "Mushroom Tortilla", "Cucumber Tortilla", "Potato Tortilla", "Apple Cake", "Strawberry Cake", "Carrot Cake", "Onion Soup", "Fish Soup" };
    private List<string> ListAppleCakeIng = new List<string>() { "Egg", "Flour", "Apple" };
    private List<string> ListStrawberryCakeIng = new List<string>() { "Egg", "Flour", "Strawberry" };
    private List<string> ListCarrotCakeIng = new List<string>() { "Egg", "Flour", "Carrot" };
    private List<string> ListMushTortIng = new List<string>() { "Egg", "Onion", "Mushroom" };
    private List<string> ListCucTortIng = new List<string>() { "Egg", "Onion", "Cucumber" };
    private List<string> ListPotTortIng = new List<string>() { "Egg", "Onion", "Potato" };
    private List<string> ListOnionSoupIng = new List<string>() { "Fish", "Water" };
    private List<string> ListFishSoupIng = new List<string>() { "Onion", "Water" };
    private List<List<string>> ingredients = new List<List<string>>();

    private
    // Start is called before the first frame update
    void Start()
    {
        ingredients.Add(ListAppleCakeIng);
        ingredients.Add(ListStrawberryCakeIng);
        ingredients.Add(ListCarrotCakeIng);
        ingredients.Add(ListMushTortIng);
        ingredients.Add(ListCucTortIng);
        ingredients.Add(ListPotTortIng);
        ingredients.Add(ListOnionSoupIng);
        ingredients.Add(ListFishSoupIng);
        int r = Random.Range(1, 4);
        Debug.Log(r);
        currentOrders = new List<order>();
        currentOrders.Add(new order(20, finalRecipes[r - 1], UINames[r - 1], ingredients[r - 1]));
        Debug.Log(currentOrders[0].finalRecipe);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentOrders);
        if (totalTime > 0 && handedRecipes < recipesToWin)
        {
            timeToNextItem -= Time.deltaTime;
            totalTime -= Time.deltaTime;
            countDownText.text = ((int)totalTime).ToString();
            if (currentOrders.Count < 3 && handedRecipes < recipesToWin && recipesCreated < recipesToWin)
            {
                Debug.Log(currentOrders.Count);
                if (timeToNextItem <= 0)
                {
                    int r = Random.Range(1, 4) - 1;
                    currentOrders.Add(new order(20, finalRecipes[r], UINames[r], ingredients[r]));
                    recipesCreated++;
                    timeToNextItem = 15;
                }
            }

            if (currentOrders.Count == 1)
            {
                namePanel1.text = currentOrders[0].UIName;
                text1Panel1.text = currentOrders[0].ingredients[0];
                text2Panel1.text = currentOrders[0].ingredients[1];
                text3Panel1.text = currentOrders[0].ingredients[2];
                timeLeftPanel1.text = ((int)currentOrders[0].timeToEnd).ToString();
            }
            else if (currentOrders.Count == 2)
            {
                namePanel1.text = currentOrders[0].UIName;
                text1Panel1.text = currentOrders[0].ingredients[0];
                text2Panel1.text = currentOrders[0].ingredients[1];
                text3Panel1.text = currentOrders[0].ingredients[2];
                timeLeftPanel1.text = ((int)currentOrders[0].timeToEnd).ToString();
                namePanel2.text = currentOrders[1].UIName;
                text1Panel2.text = currentOrders[1].ingredients[0];
                text2Panel2.text = currentOrders[1].ingredients[1];
                text3Panel2.text = currentOrders[1].ingredients[2];
                timeLeftPanel2.text = ((int)currentOrders[1].timeToEnd).ToString();
            }
            else if (currentOrders.Count == 3)
            {
                namePanel1.text = currentOrders[0].UIName;
                text1Panel1.text = currentOrders[0].ingredients[0];
                text2Panel1.text = currentOrders[0].ingredients[1];
                text3Panel1.text = currentOrders[0].ingredients[2];
                timeLeftPanel1.text = ((int)currentOrders[0].timeToEnd).ToString();
                namePanel2.text = currentOrders[1].UIName;
                text1Panel2.text = currentOrders[1].ingredients[0];
                text2Panel2.text = currentOrders[1].ingredients[1];
                text3Panel2.text = currentOrders[1].ingredients[2];
                timeLeftPanel2.text = ((int)currentOrders[1].timeToEnd).ToString();
                namePanel3.text = currentOrders[2].UIName;
                text1Panel3.text = currentOrders[2].ingredients[0];
                text2Panel3.text = currentOrders[2].ingredients[1];
                text3Panel3.text = currentOrders[2].ingredients[2];
                timeLeftPanel3.text = ((int)currentOrders[2].timeToEnd).ToString();
            }
            else
            {
                namePanel1.text = "";
                text1Panel1.text = "";
                text2Panel1.text = "";
                text3Panel1.text = "";
                timeLeftPanel1.text = "";
                text1Panel2.text = "";
                text2Panel2.text = "";
                text3Panel2.text = "";
                namePanel2.text = "";
                timeLeftPanel2.text = "";
                namePanel3.text = "";
                text1Panel3.text = "";
                text2Panel3.text = "";
                text3Panel3.text = "";
                timeLeftPanel3.text = "";
            }



        }
        else if (totalTime <= 0)
        {
            endRoundText.text = "Time!";
            StartCoroutine(ChangeModel());
        }
        else if (handedRecipes >= recipesToWin)
        {
            endRoundText.text = "Congratulations!";
            StartCoroutine(ChangeModel());
        }
    }

    IEnumerator ChangeModel()
    {
        GameObject sceneManager = GameObject.Find("SceneChanger");
        Debug.Log("To next scene");
        yield return new WaitForSeconds(4);

        sceneManager.GetComponent<NextScene>().ManageScene();
    }
    public bool handOrder(GameObject item)
    {
        Debug.Log("Haging item");
        string name = item.GetComponent<Item>().food.tag;
        Debug.Log(name);
        if (finalRecipes.Contains(name))
        {
            foreach (order ord in currentOrders)
            {
                if (ord.finalRecipe == name)
                {
                    handedRecipes++;
                    currentOrders.Remove(ord);
                    return true;
                }
            }
        }
        return false;
    }
}
