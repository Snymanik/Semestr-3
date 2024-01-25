using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WinGame : MonoBehaviour
{
   
   //public  GameObject canvas;
    //public Rigidbody player;
    
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            GameManager.gameManager.Bruv(true) ;
        }
    }
    

    
}
