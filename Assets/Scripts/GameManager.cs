using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject canvas;
    //[SerializeField]
    public Camera ThirdPCamera, FirstPCamera;

    public static GameManager gameManager;
    [SerializeField]
    public Rigidbody player;
    [SerializeField]
    int time = 100;
    [SerializeField]
    Text end;
    [SerializeField]
    GameObject player2;
    private bool PlayGame = true;
    private void Awake()
    {
        FirstPCamera.enabled = false;
        ThirdPCamera.enabled = true;
        
    }

    // Update is called once per frame
    private void Start()
    {
        
        if (gameManager == null)
        {
            gameManager = this;
        }
        canvas.SetActive(false);
        InvokeRepeating("Time", 2, 1); 
        PlayGame = true;
    }
    public void Time()
    {
        time--;
        Debug.Log(time);
        if (time < 0)
        {
            Bruv(false);
            
        }

    }
    public void Bruv(bool bu)
    {
        if (bu == true)
        {
            end.text = "You win!!!";
        }
        else
        {
            end.text = "You lose";
        }
        canvas.SetActive(true);
        player.constraints = RigidbodyConstraints.FreezeAll;
        CancelInvoke("Time");
        PlayGame = false;
    }
    private void Update()
    {
        Restart();
        if (Input.GetKeyDown(KeyCode.F5))
        {
            CameraSwitch();
        }
    }
    public void Restart()
    {
        if (PlayGame == false && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
    }
    private void CameraSwitch()
    {
        ThirdPCamera.enabled = !ThirdPCamera.enabled;
        FirstPCamera.enabled = !FirstPCamera.enabled;
       
    }
}
