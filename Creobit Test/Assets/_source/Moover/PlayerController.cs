using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    [SerializeField] private float _speed;
    private Rigidbody rb;
    private float moveX;
    private float moveY;

    private void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        transform.position += moveY * transform.forward * _speed * Time.deltaTime;
        transform.Rotate(transform.up, moveX);

    }
}
