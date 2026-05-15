using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemyPosition1;
    public GameObject enemyPosition2;
    public GameObject enemyPosition3;
    public GameObject enemyPosition4;
    public GameObject enemyPosition5;
    float timerFloat = 1;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timerFloat -= Time.deltaTime;
        if (timerFloat <= 0)
        {
            int randomPosition = Random.Range(1, 5);
            print(randomPosition);
            if (randomPosition == 1)
            {
                Instantiate(enemy, enemyPosition1.transform.position, enemyPosition1.transform.rotation);
            }
            else if (randomPosition == 2)
            {
                Instantiate(enemy, enemyPosition2.transform.position, enemyPosition2.transform.rotation);
            }
            else if (randomPosition == 3)
            {
                Instantiate(enemy, enemyPosition3.transform.position, enemyPosition3.transform.rotation);
            }
            else if (randomPosition == 4)
            {
                Instantiate(enemy, enemyPosition4.transform.position, enemyPosition4.transform.rotation);
            }
            else if (randomPosition == 5)
            {
                Instantiate(enemy, enemyPosition5.transform.position, enemyPosition5.transform.rotation);
            }
            timerFloat = Random.Range(2, 5);
        }
    }
}
