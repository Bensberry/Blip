using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float speed = 2f; // Adjust speed as needed

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Destroy cloud when it moves off-screen to free up memory
        if (transform.position.x < -40) // Adjust based on your screen size
        {
            Destroy(gameObject);
        }
    }
}

