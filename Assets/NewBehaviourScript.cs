using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapstrenght;
    public Logic logi;
    public bool benisalive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1.2f;
        logi = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)|| Input.touchCount>0) == true && benisalive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapstrenght;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logi.Gameover();
        benisalive = false;
    }
}
