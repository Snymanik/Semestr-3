
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ask about gravity and the rotation of the camera
public class SphereMovement : MonoBehaviour
{
    [SerializeField]
     float speed = 20f;

    
    
    public Rigidbody Rigidbody;
    Vector3 direction;

    

    // Use this for initialization
    void Start()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Rigidbody = GetComponent<Rigidbody>();
       

    }

    // Update is called once per frame
    void Update()
    {
        
        if (UnityEngine.Input.GetKey(KeyCode.UpArrow))
        {
             direction = new Vector3(0, 0, 1);
           
        }
        else if (UnityEngine.Input.GetKey(KeyCode.LeftArrow))
        {
             direction = new Vector3(-1, 0, 0);
            
        }
        else if (UnityEngine.Input.GetKey(KeyCode.RightArrow))
        {
             direction = new Vector3(1, 0, 0);
        }
        else if (UnityEngine.Input.GetKey(KeyCode.DownArrow))
        {
             direction = new Vector3(0, 0, -1);

        }
        else
        {
            direction = Vector3.zero;
        }
        
         //   rotation();
        
       
        moveCharacter(direction);
       
    }

    /*private void rotation()
    {
        float rotate = Input.GetAxis("Mouse X");
        //rotate = Mathf.Clamp(rotate, -50, 50);
        transform.rotation = Quaternion.Euler(0, transform.rotation.y+ rotate, 0);
    }*/

    void moveCharacter(Vector3 direction)
    {
       
        Rigidbody.velocity = direction * speed;
        
    }

}

