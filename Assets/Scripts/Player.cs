using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rigidbody;
    private Vector2 playerDirection;
    float directiony;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        directiony = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directiony).normalized;
    }

    void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
