using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public float moveSpeed;
    public GameObject laserObject = new GameObject();
    public GameObject cannonLeft = new GameObject();
    public GameObject cannonRight = new GameObject();

    //  public GameObject laserObject;
    //   public GameObject cannonLeft;
    //  public GameObject cannonRight;

    // Start is called before the first frame update
    void Start()
    {
        //   laserObject = new GameObject();
        //   cannonLeft = new GameObject();
        //   cannonRight = new GameObject();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();

    }

    void Movement()
    {
        Vector3 movement = Vector3.right * Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -14, 14);
        transform.position = position;
    }

    void Shooting()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laserObject, cannonLeft.transform.position, laserObject.transform.rotation);
            Instantiate(laserObject, cannonRight.transform.position, laserObject.transform.rotation);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (GameManager.instance.gameOver == false)
        {
            GameManager.instance.gameOver = true;
        }
    }
}
