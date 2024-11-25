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

    public int[] direction = { 1, -1 };

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
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);

            GameObject newEnemy = Instantiate(enemyPrefabs[enemyIndex], 
            new Vector3(Random.Range(0.4f, 2f) * direction[Random.Range(0, 2)], 
            Random.Range(0, 1),
            Random.Range(0.4f, 2) * direction[Random.Range(0, 2)]), 
            Quaternion.identity);

            enemiesList.Add(newEnemy);

            startingDelay -= delayDecrease;
            timer = 0;
        }
    }

}
