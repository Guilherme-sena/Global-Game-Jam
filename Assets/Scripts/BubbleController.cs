using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class BubbleController : MonoBehaviour
{

    private Transform lastbubble;
    [SerializeField] private float _bubbleSpeed;
    private bool canMove;
    void Start()
    {
    }
    public void Update(){
        ApplyMovement();
        if(transform.parent.childCount > 0){
            lastbubble = GetLastBubble(transform.parent);
        }


    }
  
    void ApplyMovement(){
            
            Debug.Log("Func Apply Movement");
            // if bubble is not the last bubble it moves
            if(transform != GetLastBubble(transform.parent) && transform.parent.childCount >1){
                transform.position += new Vector3(0f ,_bubbleSpeed*Time.deltaTime,0f);
            }
            // if bubble is the only bubble it moves when let go of space
            if(transform.parent.childCount == 1){
                if(Input.GetKey(KeyCode.Space) == false){
                    Debug.Log("entei no if");
                    lastbubble.position += new Vector3( 0f,_bubbleSpeed* Time.deltaTime,0f);
                    
                }
            if(transform == GetLastBubble(transform.parent) && Input.GetKey(KeyCode.Space) == false){
                 lastbubble.position += new Vector3(0f ,_bubbleSpeed*Time.deltaTime,0f);

            }
            } 
            

            if(transform.position.y>20){
                Destroy(gameObject);
            }


        }
    Transform GetLastBubble(Transform Parent){
            return Parent.GetChild(Parent.childCount -1);
    }
    }
    
