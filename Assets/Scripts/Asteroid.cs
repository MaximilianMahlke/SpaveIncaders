using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Rotate
        transform.Rotate(new Vector3(180, 180, 0) * Time.deltaTime);
        
        // Movement
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);

        // Destroy when out of screen
        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Laser")
        {
            GameManager.instance.score += 10;
            Destroy(gameObject);
        }
    }

    //private void OnDestroy()
    //{

    //}
}
