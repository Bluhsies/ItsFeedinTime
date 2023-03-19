using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{

    private float rightWidth;
    private float HeightOne;
    private float HeightTwo;
    private float leftWidth;

    private Vector3 rotation;

    public GameObject playerCamera;

    void Start()
    {

        rightWidth = 0.75f;
        leftWidth = 0.25f;
        HeightOne = 0.6f;
        HeightTwo = 0.4f;
        rotation = new Vector3(0, 2.0f, 0);

    }

    void Update()
    {

        
            if ((Input.mousePosition.x > (Screen.width * rightWidth) && Input.mousePosition.y < (Screen.height * HeightOne) && Input.mousePosition.y > (Screen.height * HeightTwo)) && Input.GetMouseButton(0))
            {


                playerCamera.transform.Rotate(rotation);
            }
            else if ((Input.mousePosition.x <= (Screen.width * leftWidth) && Input.mousePosition.y < (Screen.height * HeightOne) && Input.mousePosition.y > (Screen.height * HeightTwo)) && Input.GetMouseButton(0))
            {


                playerCamera.transform.Rotate(-rotation);
            }
       
    }
}


