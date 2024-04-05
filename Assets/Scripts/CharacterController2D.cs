using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2d;
    Vector2 _motionVector;
    [SerializeField] private float speed;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        _motionVector = new Vector2(horizontal, vertical).normalized;
        //Vector2 position = transform.position;
        //position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        //position.y = position.y + 3.0f * vertical * Time.deltaTime;
        //transform.position = position;
        rb2d.velocity = _motionVector * speed;
        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);
    }
}
