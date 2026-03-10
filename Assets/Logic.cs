using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // Required for TextMeshPro

public class Logic : MonoBehaviour
{
    public int playerscore;
    public TMP_Text scoreText; // Changed from Text to TMP_Text
    public GameObject gameoverscreen;

    public TMP_Text gameOverScoreText;       // TextMeshPro field for Game Over current score
    public TMP_Text gameOverHighscoreText;   // TextMeshPro field for Game Over highscore
    public TMP_Text highscoreText;           // Optional: in-game UI display (e.g. top corner)

    private int highscore;

    void Start()
    {
        // Load highscore from PlayerPrefs
        highscore = PlayerPrefs.GetInt("Highscore", 0);
        UpdateHighscoreUI();
    }

    [ContextMenu("increase score")]
    public void addscore(int Scoretoadd)
    {
        playerscore += Scoretoadd;
        scoreText.text = playerscore.ToString();

        if (playerscore > highscore)
        {
            highscore = playerscore;
            PlayerPrefs.SetInt("Highscore", highscore); // Save new highscore
            PlayerPrefs.Save();
            UpdateHighscoreUI();
        }
    }

    void UpdateHighscoreUI()
    {
        if (highscoreText != null)
            highscoreText.text = "Highscore: " + highscore.ToString();
    }

    public void Restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Returntomainmenu()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }

    public void Gameover()
    {
        gameoverscreen.SetActive(true);

        // Update Game Over screen scores
        if (gameOverScoreText != null)
            gameOverScoreText.text = "Score: " + playerscore.ToString();

        if (gameOverHighscoreText != null)
            gameOverHighscoreText.text = "Highscore: " + highscore.ToString();
    }
}
