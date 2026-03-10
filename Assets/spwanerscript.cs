using UnityEngine;

public class spwanerscript : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnrate = 85;
    private float timer = 0;
    public float heightoffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnpoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnpoint();
            timer = 0;
        }
    }
    void spawnpoint()
    {
        float lowestPoint = transform.position.y - heightoffset;
        float heighestPoint = transform.position.y + heightoffset;
        Instantiate(Pipe, new Vector3 (transform.position.x, Random.Range(lowestPoint, heighestPoint) , 0 ), transform.rotation);
    }
}
