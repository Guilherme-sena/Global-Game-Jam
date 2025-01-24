using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject _bubble;
    public Animator animator;
    private bool _moving;
    private GameObject _bubbleInstance;
    [SerializeField] private float _bubbleSpeed;
    [SerializeField] private Vector3 _bubbleOffset;
    [SerializeField] private float speed = 5f;
    Rigidbody2D _rb;
    private  Vector2 _input;
    private float x;
    private float y;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {

        GetInput();
        Animate();
        if(Input.GetKeyDown(KeyCode.Space)){
            this.Shoot();
        }   
    }

     private void FixedUpdate() {
        _rb.velocity = _input * speed;
    }


    public void Shoot(){
        _bubbleInstance = Instantiate(_bubble,transform.position + _bubbleOffset,_bubble.transform.rotation);
    }
    private void GetInput(){
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        _input = new Vector2(x,y);
        _input.Normalize();
        
    }
    private void Animate(){
        if(_input.x < -0.1f){
            gameObject.transform.localScale = new Vector3(-1,1,1);
        }

        if(_input.x > 0.1f){
            gameObject.transform.localScale = new Vector3(1,1,1);
        }

        if(_input.magnitude > 0.1f || _input.magnitude < -0.1f){
            _moving = true;
        }
        else{
            _moving = false;
        }

        if (_moving){
            animator.SetFloat("X",x);
            animator.SetFloat("Y",y);
        }
        animator.SetBool("moving",_moving);
    }
}