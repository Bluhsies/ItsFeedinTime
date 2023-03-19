using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSwitch : MonoBehaviour
{

    public Behaviour food;

    public void StopTheFood()
    {
        Debug.Log("Stop");
        food.enabled = false;
    }

    public void StartTheFood()
    {

        Debug.Log("Start");
        food.enabled = true;

    }

}
