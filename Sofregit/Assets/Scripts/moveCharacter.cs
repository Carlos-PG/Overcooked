using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCharacter : MonoBehaviour
{
    private Animator animator;
    private CharacterController controller;
    private float playerSpeed = 2.0f;
    private bool hasFood = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey(KeyCode.C))
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            controller.Move(move * Time.deltaTime * playerSpeed);

            if (move != Vector3.zero)
            {
                animator.SetBool("Walking", !hasFood);
                animator.SetBool("Walking2", hasFood);
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
            animator.SetBool("Walking", false);
            animator.SetBool("Walking2", false);
            animator.SetBool("Idle", false);
            animator.SetBool("Cutting", true);
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {

    }
}
