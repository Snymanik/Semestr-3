using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCameraController : MonoBehaviour
{
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, player.position.z);
    }
}
