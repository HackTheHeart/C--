using UnityEngine;

public class PipeMovementScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;
    public LogicScipt logic;
    public BirdScript Bird;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Bird.isBirdAlive)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        }

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
