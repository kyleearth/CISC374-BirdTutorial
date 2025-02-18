using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    public GameObject gameOverScreens;
    public AudioSource dingSFX;

    public AudioSource crashSFX;

    //public TextMeshProUGUI highScoreText; // Assign in Inspector
    
    public int highScore;
    public Text highScoreText;
    
    //[ContextMenu("Add Score")]
    public void addScore(int scoreToAdd=1)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        dingSFX.Play();
    }
    // public void resetScore()
    // {
    //     playerScore = 0;
    //     scoreText.text = playerScore.ToString();
    // }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //Debug.Log("Restarting Over");
    }

    public void gameOver()
    {   
        crashSFX.Play();
        //Debug.Log("Game Over 1");
        gameOverScreens.SetActive(true);
        //Debug.Log("Game Over 2");

        if (playerScore > highScore)
        {
            highScore = playerScore;
            PlayerPrefs.SetInt("HighScore", playerScore);
            highScoreText.text = "high Score: "+ highScore.ToString();
        }

    }
}
