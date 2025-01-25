using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    public GameObject _bubble;
    public Transform  _bubbleOffset;
    public Animator animator;
    private bool _moving;
    private bool _canMove = true;
    private GameObject _bubbleInstance;
    [SerializeField] private float speed = 5f;
    private bool is_turned_right = true;
    Rigidbody2D _rb;
    public  Vector2 _input;
    private float x;
    private float y;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
        if(_canMove == true){
            GetInput();
        }
        Animate();
        if(Input.GetKey(KeyCode.Space)){
            this.Shoot();
        }   
        else{
            _canMove = true;
        }
    }

     private void FixedUpdate() {
        if(_canMove){
            _rb.velocity = _input * speed;

        }
        else{
            _rb.velocity = Vector2.zero;
        }

    }


    public void Shoot(){ 
        _canMove = false; 
        _input = Vector2.zero;
        if(Input.GetKeyDown(KeyCode.Space)){

        _bubbleInstance = Instantiate(_bubble,_bubbleOffset.position ,_bubble.transform.rotation);
        }
        
       
    }
    private void GetInput(){
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        _input = new Vector2(x,y);
        _input.Normalize();
        
    }
    private void Animate(){
        if(_input.x < -0.1f && is_turned_right == true){
            gameObject.transform.Rotate(0,180,0);
            is_turned_right = false;
        }

        if(_input.x > 0.1f && is_turned_right == false){
            gameObject.transform.Rotate(0,180,0);
            is_turned_right = true;
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