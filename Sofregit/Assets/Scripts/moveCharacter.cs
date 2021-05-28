using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCharacter : MonoBehaviour
{
    private Animator animator;
    private CharacterController controller;
    public float playerSpeed = 10.0f;
    private bool hasItem = false;
    private GameObject item;
    public GameObject itemObj;
    private float timeToCut = 0;
    private bool isCutting = false;
    private float timeBetweenActions = 0;
    private Vector3 knifePosition = new Vector3(-0.00148f, 0.0031f, -0.00148f);
    private Vector3 knifeRotation = new Vector3(-2.131f, -83.547f, 275.383f);

    private Vector3 itemPosition = new Vector3(0.00951f, 0.00403f, 0.0012f);
    private Vector3 itemRotation = new Vector3(90f, 0f, 0f);

    public GameObject knifeMod;
    private GameObject knife;

    public Transform rightHand;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBetweenActions > 0)
        {
            --timeBetweenActions;
        }
        if (!isCutting)
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            controller.Move(move * Time.deltaTime * playerSpeed);

            if (move != Vector3.zero)
            {
                animator.SetBool("Walking", !hasItem);
                animator.SetBool("Walking2", hasItem);
                animator.SetBool("Idle", false);
                animator.SetBool("Cutting", false);
                gameObject.transform.forward = move;
            }
            else
            {
                animator.SetBool("Walking", false);
                animator.SetBool("Walking2", false);
                animator.SetBool("Idle", true);
                animator.SetBool("Cutting", false);
            }
        }
        else
        {
            if(timeToCut <= 0)
            {
                isCutting = false;
                Destroy(knife);
            } else
            {
                timeToCut -= Time.deltaTime;
            }
            animator.SetBool("Walking", false);
            animator.SetBool("Walking2", false);
            animator.SetBool("Idle", false);
            animator.SetBool("Cutting", true);
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (timeBetweenActions <= 0)
        {
            if (hit.collider.gameObject.GetComponent<crateScript>())
            {
                Debug.Log("Es una caja");
                crateScript script = hit.collider.gameObject.GetComponent<crateScript>();
                if (Input.GetKey(KeyCode.Space)) //Agafa un ingredient
                {
                    Debug.Log("Apreta espacio");
                    if (!hasItem)
                    {
                        Debug.Log("No tiene item");
                        item = Instantiate(itemObj);
                        item.transform.parent = rightHand;
                        item.transform.localPosition = itemPosition;
                        item.transform.localEulerAngles = itemRotation;
                        Item itemScript = item.gameObject.GetComponent<Item>();
                        itemScript.createFoodByName(script.ingredientType.tag);
                        hasItem = true;
                    }
                    else
                    {
                        Debug.Log("Tiene item");
                    }
                    timeBetweenActions = 500;
                }
            }
            if (hit.collider.gameObject.GetComponent<tableScript>())
            {
                tableScript script = hit.collider.gameObject.GetComponent<tableScript>();
                Debug.Log("Es una mesa");
                if (Input.GetKey(KeyCode.Space))
                {
                    Debug.Log("Apreta espacio");
                    if (hasItem)
                    {
                        Debug.Log("Tiene item");
                        if (script.hasItem)
                        {
                            Debug.Log("La mesa tiene item"); //No puede dejar el item pero puede que se tengan que mezclar!!!!!!
                            if(script.mixItems(item.GetComponent<Item>().food.tag))
                            {
                                Destroy(item);
                                hasItem = false;
                            }
                        }
                        else
                        {
                            Debug.Log("La mesa no tiene item"); //Deja el item en la mesa
                            script.placeFood(item.GetComponent<Item>().food.tag);
                            Destroy(item);
                            hasItem = false;
                        }
                    }
                    else
                    {
                        Debug.Log("No tiene item");
                        if (script.hasItem)
                        {
                            Debug.Log("La mesa tiene item"); //Recoge el item
                            string foodType = script.pickUpFood();
                            item = Instantiate(itemObj);
                            item.transform.parent = rightHand;
                            item.transform.localPosition = itemPosition;
                            item.transform.localEulerAngles = itemRotation;
                            Item itemScript = item.gameObject.GetComponent<Item>();
                            itemScript.createFoodByName(foodType);
                            hasItem = true;
                        }
                        else
                        {
                            Debug.Log("La mesa no tiene item"); //No puede hacer nada
                        }
                    }
                    timeBetweenActions = 500;
                }
                else if (Input.GetKey(KeyCode.C))
                {
                    Debug.Log("Apreta C");
                    if (hasItem)
                    {
                        Debug.Log("Tiene item"); //No puede hacer nada
                    }
                    else
                    {
                        Debug.Log("No tiene item");
                        if(script.hasItem)
                        {
                            Debug.Log("La mesa tiene item");
                            if(script.itemIsProcesable())
                            {
                                Debug.Log("El item se puede cortar");
                                if(script.hasBoard)
                                {
                                    Debug.Log("La mesa tiene tabla de corte"); //Comprobar si es 
                                    script.processFood();
                                    timeToCut = 5;
                                    isCutting = true;
                                    knife = Instantiate(knifeMod);
                                    knife.transform.parent = rightHand;
                                    knife.transform.localPosition = knifePosition;
                                    knife.transform.localEulerAngles = knifeRotation;
                                }
                                else
                                {
                                    Debug.Log("La mesa no tiene tabla de corte"); //No puede hacer nada
                                }
                            }
                            else
                            {
                                Debug.Log("El item no se puede cortar"); //No puede hacer nada
                            }
                        }
                        else
                        {
                            Debug.Log("La mesa no tiene item"); //No puede hacer nada
                        }
                    }
                    timeBetweenActions = 500;
                }
            }
            if(hit.collider.gameObject.tag == "orderController") {
                if (Input.GetKey(KeyCode.Space) && hasItem)
                {
                    orderControllerLevel1 orderController = hit.collider.gameObject.GetComponent<orderControllerLevel1>();
                    if (orderController.handOrder(item))
                    {
                        Destroy(item);
                        hasItem = false;
                    }
                    timeBetweenActions = 500;
                }
            }
        }
    }

    /*
     if (!hasFood)
                {
                    crateScript script = hit.collider.gameObject.GetComponent<crateScript>();
                    item = Instantiate(item);
                    Item itemScript = item.GetComponent<Item>();
                    itemScript.createFood(script.ingredientType);
                    hasFood = true;
                }*/ 
}
