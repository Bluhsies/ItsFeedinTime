using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMove : MonoBehaviour
{

    public GameObject[] waypoints;
    int current = 0;
    public float speed;
    float WPradius = 1;
    public bool random = false;

    // Update is called once per frame
    void Update()
    {



        transform.LookAt(Camera.main.transform);

        if (random == true)
        {

            if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
            {

                current = Random.Range(0, waypoints.Length);


                if (current >= waypoints.Length)
                {

                    current = 0;

                }



            }
            transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
        }
        else
        {

            if(Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
            {

                current++;


                if (current >= waypoints.Length)
                {

                    current = 0;

                }



            }
            transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);

        }
    }


}
