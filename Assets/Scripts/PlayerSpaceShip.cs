using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerSpaceShip : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float flyingSpeed = 10f;

    public GameObject shootingPosition;
    public GameObject missile;

    public float shootingTimer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.forward * flyingSpeed * Time.deltaTime);
        }
        Fly();
        Shoot();

    }

    void Fly()
    {

        float zRotationValue = Input.GetAxis("Horizontal");
        float xRotationValue = Input.GetAxis("Vertical");

        transform.Rotate(-xRotationValue * rotationSpeed * Time.deltaTime, 0, -zRotationValue * rotationSpeed * Time.deltaTime);

    }

    void Shoot()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (shootingTimer >= 0.5)
            {
                Instantiate(missile, shootingPosition.transform.position, gameObject.transform.rotation);
                shootingTimer = 0;
            }
        }

        shootingTimer += Time.deltaTime;
    }
}
