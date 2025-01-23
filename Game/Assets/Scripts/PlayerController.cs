using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject _bubble;
    
    private GameObject _bubbleInstance;
    [SerializeField] private float _bubbleSpeed;
    [SerializeField] private Vector3 _bubbleOffset;
    [SerializeField] private float speed = 5f;
    Rigidbody2D _rb;
    private  Vector2 playerDirection;
    private float horizontalMovement;
    private float verticalMovement;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            this.Shoot();
        }

        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement   = Input.GetAxis("Vertical");
        playerDirection = new Vector2(horizontalMovement,verticalMovement);
        if (horizontalMovement != 0 && verticalMovement != 0) {
            playerDirection = playerDirection.normalized;
            }
        if (horizontalMovement == 0 && verticalMovement == 0){
            _rb.velocity = new Vector2(0,0);
            }
        _rb.velocity = new Vector2(playerDirection.x * speed, playerDirection.y * speed);
    }
     public void Shoot(){
        _bubbleInstance = Instantiate(_bubble,transform.position + _bubbleOffset,_bubble.transform.rotation);

        


    }
}
