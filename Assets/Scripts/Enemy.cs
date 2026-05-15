using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject playerSpaceShip;
    public float speed = 20f;
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
