using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{

    public GameObject turnOff;
    public GameObject playerOff;
    public GameObject sceneOn;

    void Start()
    {

        Time.timeScale = 1f;

    }

    private void OnCollisionEnter(Collision collision)
    {



        if (collision.collider.CompareTag("Head"))
        {

            Time.timeScale = 0f;
            turnOff.SetActive(false);
            playerOff.SetActive(false);
            sceneOn.SetActive(true);

        }

    }


}
