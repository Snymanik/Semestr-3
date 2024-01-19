using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraController : MonoBehaviour
{
    Transform player;
    void Start()
    {
        player = transform.parent;
         
    }
    void Update()
    {
        
        transform.position = player.position - transform.forward * 3.1f;
        Vector3 pos = new Vector3(player.position.x , player.position.y +5, player.position.z -1);
        transform.position = pos;
        transform.rotation = Quaternion.AngleAxis(-80, Vector3.left); 
    }
}

