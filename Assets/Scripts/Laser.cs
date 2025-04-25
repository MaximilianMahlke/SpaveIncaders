using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 10)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
