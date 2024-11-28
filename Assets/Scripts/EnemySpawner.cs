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
        if(timer > startingDelay) {
            if(enemiesList.Count < maxEnemies) {
                Debug.Log("N2R: spawning enemy #" + (enemiesList.Count +1));
                //rez code
                int enemyIndex = Random.Range(0, enemyPrefabs.Length);

                //i need to figure out a way to calculate coordinates inside
                //the mesh part reachable by the player. This could be a problem...
                GameObject newEnemy = Instantiate(enemyPrefabs[enemyIndex], 
                new Vector3(Random.Range(0.4f, 2f) * direction[Random.Range(0, 2)], 
                Random.Range(0, 1),
                Random.Range(0.4f, 2) * direction[Random.Range(0, 2)]), 
                Quaternion.identity);

                enemiesList.Add(newEnemy);

                startingDelay -= delayDecrease;
                timer = 0;
            }
            else {
                Debug.Log("N2R: capped on enemies, refusing to spawn this cycle. Count: " + enemiesList.Count + "   Capacity: " + enemiesList.Capacity );
            }
        }
    }

    public void removeEnemy(GameObject newEnemy){
        enemiesList.Remove(newEnemy);
        Debug.Log("N2R: removed enemy. Count: " + enemiesList.Count + "   Capacity: " + enemiesList.Capacity );
    }

}
