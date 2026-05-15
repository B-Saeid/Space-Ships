using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 30;
    public float lifeTime = 5;
    // Start is called before the first frame update
    void Start()
    {

    } 

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if(lifeTime <= 0)
        {
            Destroy(gameObject);
        }
        lifeTime -= Time.deltaTime;
    }
}
