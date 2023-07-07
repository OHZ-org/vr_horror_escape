using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : player_base
{

    float speed = 5f;

    Rigidbody rigidbody;
    Vector3 movement;
    float h, v;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateState();
    }

    protected override void UpdateIdle()
    {

    }

    protected override void UpdateMove()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }

    protected override void UpdateInteraction()
    {

    }
}


void FixedUpdate()
{
    movement.Set(h, 0f, v);
    movement = movement.normalized * speed * Time.deltaTime;
    rigidbody.MovePosition(transform.position + movement);
}
