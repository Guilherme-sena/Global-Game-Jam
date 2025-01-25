using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour
{
    private float _bubbleX = 1;
    public GameObject _bubbleInstance;
    
    private float _bubbley = 1;
    [SerializeField] private float _bubbleSpeed;
    private bool canMove;
    void Start()
    {
    }
    public void Update(){
        ControllSize();
        ApplyMovement();


    }
    private void ControllSize(){
        if(Input.GetKey(KeyCode.Space) == true ){
            _bubbleX += 1 * Time.deltaTime;
            _bubbley += 1 * Time.deltaTime;
        transform.localScale = new Vector3(_bubbleX,_bubbley,1);
        }
        
    }
    void ApplyMovement(){

            if(Input.GetKey(KeyCode.Space) == false){
                _bubbleInstance.transform.position += new Vector3(0f ,Mathf.Abs(_bubbleSpeed)*Time.deltaTime,0f);
        
        }
            if(transform.position.y>20){
                Destroy(_bubbleInstance);
            }


        }
    }
    
