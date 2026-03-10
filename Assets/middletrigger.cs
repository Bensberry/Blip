using UnityEngine;

public class middletrigger : MonoBehaviour
{
    public Logic logi;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logi = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logi.addscore(1);
        }
    }
}
