using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject playerSpaceShip;
    public GameObject missile;
    public GameObject missilePosition;
    public float speed = 20f;

    public float timerFloat = 1;
    // Start is called before the first frame update
    void Start()
    {
        playerSpaceShip = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerSpaceShip.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        float playerDistance = Vector3.Distance(playerSpaceShip.transform.position, transform.position);
        // print(playerDistance);
        if (playerDistance <= 35)
        {
            if (timerFloat <= 0)
            {
                Instantiate(missile, missilePosition.transform.position, missilePosition.transform.rotation);
                timerFloat = 1;
            }
        }

        timerFloat -= Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Missile")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
