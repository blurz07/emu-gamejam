using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMovement : MonoBehaviour
{
   
    public float moveSpeed = 5.0f;

    public Rigidbody2D _rigidbody2D;

    Vector2 movement;
    Vector2 mousePos;
    public Camera cam;


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        
    }

    void FixedUpdate()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDirection = _rigidbody2D.position - mousePos;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        _rigidbody2D.rotation = angle;
    }
}
