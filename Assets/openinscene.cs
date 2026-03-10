using UnityEngine;
using UnityEngine.SceneManagement;

public class openinscene : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown || Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            SceneManager.LoadSceneAsync("Main Menu");
        }
    }
}
