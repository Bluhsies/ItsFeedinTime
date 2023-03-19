using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
   

  
    [SerializeField] private ObjectPooler sc;
    public float projectilePower = 10f;


    public void Update()
    {





        if ((Input.mousePosition.x > (Screen.width * 0.75f) && Input.mousePosition.y < (Screen.height * 0.25f)) && Input.GetMouseButtonDown(0))
        {
            sc.SpawnPrefab();

            FireFood();
        }

    }

    public void FireFood()
    {

        Rigidbody projectile = sc.foodPrefab.GetComponent<Rigidbody>();

        projectile.AddForce(sc.spawnPosition.TransformDirection(Vector3.forward) * Mathf.Clamp(projectilePower, 10f, 25f), ForceMode.Impulse);

    }

}

