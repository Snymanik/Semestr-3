using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
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
        
        //transform.position = player.position - transform.position * 3.1f;
      // Vector3 pos = new Vector3(player.position.x , player.position.y +5, player.position.z -1);
        //transform.position = pos;
       // transform.rotation = Quaternion.AngleAxis(80, Vector3.right); 
    }
    private const float YMin = -50.0f;
    private const float YMax = 50.0f;

    public Transform lookAt;

    public Transform Player;

    public float distance = 1.5f;
    private float currentX = 0.0f;
    public float sensivity = 20.0f;
    void LateUpdate()
    {

        currentX += Input.GetAxis("Mouse X") * sensivity * Time.deltaTime;

        Vector3 Direction = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(60, currentX, 0);
        transform.position = lookAt.position + rotation * Direction;

        transform.LookAt(lookAt.position);



    }
}


