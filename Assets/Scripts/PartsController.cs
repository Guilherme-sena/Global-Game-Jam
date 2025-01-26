using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsController : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
  
    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log(other.transform.tag);
        if(other.transform.tag =="Bubble"){
            transform.SetParent(other.transform);
            transform.localPosition = Vector2.zero;
        }
    }
}
