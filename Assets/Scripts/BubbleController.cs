using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEditor.Experimental.GraphView;
using UnityEditor.PackageManager;
using UnityEditor.Search;
using UnityEngine;

public class BubbleController : MonoBehaviour
{

    private Transform lastbubble;

    public Transform gun_position;
    public  GameObject _prefab_bubble;
    [SerializeField] private float _bubbleSpeed;
    void Update(){
       foreach (Transform child in transform){
            if(child.gameObject.GetComponent<SpriteRenderer>().enabled == false){
                child.DetachChildren();
            }
            if(child.position.y > 15 && child.transform != null ){
                Destroy(child.gameObject);
            }
       }
{
    //child is your child transform
}
    }
    public void ApplyMovement(Transform obj)
    {
        if(obj.transform != null){

            StartCoroutine(MoveToCoroutine(obj, new Vector2(obj.position.x,25), 15));
        }
        //obj.Translate(0f ,_bubbleSpeed*Time.deltaTime,0f);
    }
    public Transform GetLastBubble()
    {
        return transform.GetChild(transform.childCount -1);
    }
    public void ControllSize(Transform obj)
    {
        obj.localScale += new Vector3( Time.deltaTime, Time.deltaTime,1);
    }
    public void Spawn(){
        Instantiate(_prefab_bubble,gun_position.position ,_prefab_bubble.transform.rotation,parent:transform);
        
    }

    public IEnumerator MoveToCoroutine(Transform targ, Vector3 pos, float dur)
{
    float t = 0f;

         Vector3 start = targ.position;
         Vector3 v = pos - start;
        while(t < dur)
        {
            if(targ.transform == null){
                yield break;
            }
            t += Time.deltaTime * _bubbleSpeed;
            targ.position = start + v * t / dur;
            yield return null;
        
        }
        if(targ != null)
        {
            targ.position = pos;
        }
   
    
}
}
    
