using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public Player player;
    private int score;
    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject gameOverText;
    public GameObject getReadyText;


    private void Awake() 
    {
        Pause();
        gameOverText.SetActive(false);
        getReadyText.SetActive(true);
    }
    public void Play()
    {
        score=0;
        scoreText.text = score.ToString();
        player.enabled= true;
        Time.timeScale=1;
        gameOverText.SetActive(false);
        playButton.SetActive(false);
        getReadyText.SetActive(false);
        PipesMovement[] pipes = FindObjectsOfType<PipesMovement>();
        for (int i = 0; i < pipes.Length ; i++)
        {
            Destroy(pipes[i].gameObject);
            
        }



    }   
    public void Pause()
    {
        player.enabled= false;
        Time.timeScale=0;
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        
    }





}
