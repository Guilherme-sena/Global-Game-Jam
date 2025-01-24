using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour
{
    private float _bubbleX = 1;
    
    private float _bubbley = 1;
    [SerializeField] private float _bubbleSpeed = 1.5f;
    private bool canMove;
    void Start()
    {
    }
    void Update(){
        ControllSize();
        ApplyMovement();


    }
    private void ControllSize(){
        if(Input.GetKey(KeyCode.Space) == true ){
            _bubbleSpeed = 1.5f;
            _bubbleX += 1 * Time.deltaTime;
            _bubbley += 1 * Time.deltaTime;
        transform.localScale = new Vector3(_bubbleX,_bubbley,1);
        }
        
    }
    void ApplyMovement(){

            if(Input.GetKey(KeyCode.Space) == false){
           gameObject.transform.Translate(0f ,transform.position.y * _bubbleSpeed * Time.deltaTime,0f);
        
        }


        }
    }
    
