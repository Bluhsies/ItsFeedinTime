using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEndless : MonoBehaviour
{

    public GameObject foodPrefab;
    public int poolSize;
    public Dictionary<GameObject, bool> pool = new Dictionary<GameObject, bool>();
    public Transform[] spawnPosition;
    int randomSpawnPoint;
    public Transform tempPosition;
    
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = (GameObject)Instantiate(foodPrefab, tempPosition.position, Quaternion.identity);

            pool.Add(obj, true);

            obj.SetActive(false);
        }
    }

    public void SpawnPrefab()
    {

        randomSpawnPoint = Random.Range(0, spawnPosition.Length);

        

        foreach (KeyValuePair<GameObject, bool> obj in pool)
        {
            if (obj.Value == true)
            {
                foodPrefab = obj.Key;
                break;
            }
        }

        pool[foodPrefab] = false;

        foodPrefab.SetActive(true);

        foodPrefab.transform.position = spawnPosition[randomSpawnPoint].position;

        StartCoroutine(ReturnPrefab(foodPrefab));
    }


   
   
    IEnumerator ReturnPrefab(GameObject selPrefab)
    {

        

        yield return new WaitForSeconds(30.0f);
        selPrefab.transform.position = tempPosition.position;
        selPrefab.SetActive(false);
        selPrefab.GetComponent<Rigidbody>().velocity = Vector3.zero;

        pool[selPrefab] = true;

    }

}
