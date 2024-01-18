using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Transform player;
    void Start()
    {
        player = transform.parent;
         
    }
    void Update()
    {
        Vector3 pos = new Vector3(player.position.x , player.position.y +5, player.position.z -10);
        transform.position = pos;
      
    }
}
