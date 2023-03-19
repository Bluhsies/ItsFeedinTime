using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveEndlessHeads : MonoBehaviour
{

    public int foodHitMax = 3;

    public int foodHitCurrent;

    public bool meat = false;
    public bool carrot = false;
    public bool fish = false;

    public AudioSource deathSound;

    public EndlessScore sc;

    private bool ammoType;

    void Start()
    {

        sc = GameObject.FindWithTag("Score").GetComponent<EndlessScore>();

        foodHitCurrent = foodHitMax;

        deathSound = GameObject.FindWithTag("Sound").GetComponent<AudioSource>();

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (meat == true)
        {
            if (collision.collider.CompareTag("Meat"))
            {

                foodHitCurrent--;

                if (foodHitCurrent == 0)
                {

                    HeadRemoval();
                    

                }
            }
        }

        if (carrot == true)
        {
            if (collision.collider.CompareTag("Carrot"))
            {
                
                foodHitCurrent--;

                if (foodHitCurrent == 0)
                {

                    HeadRemoval();
                    
                }
            }
        }

        if (fish == true)
        {
            if (collision.collider.CompareTag("Fish"))
            {

                foodHitCurrent--;

                if (foodHitCurrent == 0)
                {

                    HeadRemoval();
                    
                }
            }
        }


        

    }

    public void HeadRemoval()
    {

        sc.UpdateScoreValue(1);
        foodHitCurrent = foodHitMax;
        gameObject.SetActive(false);
        deathSound.Play();

    }
}
