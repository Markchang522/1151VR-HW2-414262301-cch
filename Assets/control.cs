using UnityEngine;
using UnityEngine.Rendering;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 10.0f;
    public bool end = false;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        Vector2 movement = new Vector2(0 ,0);
        if (end == false){
            if (Input.GetKey(KeyCode.LeftArrow))
            {
            
                movement = new Vector2(-1, 0);
            }else if (Input.GetKey(KeyCode.RightArrow))
            {
                
                movement = new Vector2(1, 0);
    
            }else
            {
                
                movement = new Vector2(0, 0);
            }
            transform.Translate(movement * moveSpeed * Time.deltaTime);
    
            if (transform.position.x >= 9)
            {
                Debug.Log("抵達終點！結束遊戲");
                end = true;
                
            }
        }


        
    }
}