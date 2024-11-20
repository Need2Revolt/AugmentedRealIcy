using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float startingDelay = 10;
    public float delayDecrease = 0.5f;

    public int maxEnemies = 10;

    public GameObject[] enemyPrefabs;

    public ArrayList enemiesList;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Spawn());
        timer = 0;
        enemiesList = new ArrayList();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > startingDelay && enemiesList.Count < maxEnemies) {
            //rez code
            Debug.Log("AA");
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);

            GameObject newEnemy = Instantiate(enemyPrefabs[enemyIndex], 
            new Vector3(Random.Range(0.5f, 2), Random.Range(0.5f, 2), Random.Range(0, 1)), 
            Quaternion.identity);

            enemiesList.Add(newEnemy);

            startingDelay -= delayDecrease;
            timer = 0;
            Debug.Log("AA "+timer);
        }
    }

}
