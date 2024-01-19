using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WinGame : MonoBehaviour
{
   public  GameObject canvas;
    public Rigidbody player;
    private void Start()
    {
        canvas.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            Wingame();
        }
    }

    private void Wingame()
    {
        canvas.SetActive(true);
        player.constraints = RigidbodyConstraints.FreezeAll;
    }
}
