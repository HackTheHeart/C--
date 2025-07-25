using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 3 ;
    private float timer = 0;
    public float heightOffset = 10;
    public BirdScript Bird;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (Bird.isBirdAlive)
        {
            if (timer < spawnRate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                spawnPipe();
                timer = 0;
            }
        }
    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),transform.position.z), transform.rotation);
    }
}
