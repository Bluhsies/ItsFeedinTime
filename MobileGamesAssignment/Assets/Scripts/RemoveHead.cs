using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RemoveHead : MonoBehaviour
{

    public int foodHitMax = 3;

    public int foodHitCurrent;

    public ScoreCounter hits;

    public bool meat = false;
    public bool carrot = false;
    public bool fish = false;

    public AudioSource deathSound;

    void Start()
    {

        foodHitCurrent = foodHitMax;

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

        hits.UpdateScoreValue(1);
        gameObject.SetActive(false);
        deathSound.Play();

    }
}
