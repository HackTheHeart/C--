using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScipt : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject gameStartScreen;
    public GameObject Bird;
    public GameObject PipeSpawner;
    public GameObject Text;
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }
    public void onstartGame()
    {
            gameStartScreen.SetActive(false);
        Bird.SetActive(true);
        PipeSpawner.SetActive(true);
        Text.SetActive(true);
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
