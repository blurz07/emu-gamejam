using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : MonoBehaviour
{
    public GameObject enemy;
    public Transform Player;
    Vector2 playerpos;
    public Camera cam;
    public Rigidbody2D _rigidbody2D;


    void Update()
    {
        playerpos = Player.position;

    }

    void FixedUpdate()
    {

        Vector2 lookDirection = _rigidbody2D.position - playerpos;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        _rigidbody2D.rotation = angle;
    }
}
