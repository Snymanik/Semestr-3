using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallColour : MonoBehaviour
{
    public Material mat01;
    public Material mat02;

    void ColourWall()
    {
        int colour = 0;
        foreach (Transform child in transform)
        {
            colour = Random.Range(0, 2);
            switch (colour)
            {
                case 0:
                    child.gameObject.GetComponent<Renderer>().material = mat01;
                    break;
                case 1:
                    child.transform.GetComponent<Renderer>().material = mat02;
                    break;
            }
        }
    }
    private void Start()
    {
       ColourWall();
    }
    
    
}
