using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody rb;
    public Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        this.movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Horizontal"));
    }
    void FixedUpdate()
    {
        this.moveCharacter(this.movement);
    }
    void moveCharacter(Vector2 direction)
    {
        this.rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }
}
