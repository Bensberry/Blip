using UnityEngine;
using UnityEngine.SceneManagement;
public class GameModeSelect : MonoBehaviour
{
    public void Mode1()
    {
        SceneManager.LoadSceneAsync("Mode 1");
    }
    public void Mode2()
    {
        SceneManager.LoadSceneAsync("Mode 2");
    }


}
