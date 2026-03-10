using UnityEngine;

public class Left : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapstrenght;
    public Logic logi;
    public bool benisalive = true;

    void Start()
    {
        Time.timeScale = 1.2f;
        GameObject logicObject = GameObject.FindGameObjectWithTag("Logic");
        if (logicObject != null)
        {
            logi = logicObject.GetComponent<Logic>();
        }
    }

    void Update()
    {
        // For mobile touch input
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began && touch.position.x < Screen.width / 2)
            {
                myRigidbody.linearVelocity = Vector2.up * flapstrenght;
            }
        }

        // For testing in Unity Editor (Mouse Click)
        if (Input.GetMouseButtonDown(0) && Input.mousePosition.x < Screen.width / 2)
        {
            myRigidbody.linearVelocity = Vector2.up * flapstrenght;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (logi != null)
        {
            logi.Gameover();
        }
        benisalive = false;
    }
}
