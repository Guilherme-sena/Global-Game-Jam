using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour
{
    // Start is called before the first frame update
    private float _bubbleX = 1;
    private float _bubbley = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.Space) == true ){
            _bubbleX += 1 * Time.deltaTime;
            _bubbley += 1 * Time.deltaTime;
        transform.localScale = new Vector3(_bubbleX,_bubbley,1);
        Debug.Log("CRESCENDO");
        }
        
    }
}
