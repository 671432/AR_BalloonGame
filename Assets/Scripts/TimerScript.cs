using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    float timeLeft = 30f;
    public GameObject gameOverScreen;
    public Text finalScoreText;
    public Text timeLeftText;
    public Text scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft = timeLeft - Time.deltaTime;
        timeLeftText.text = timeLeft + "";

        if(timeLeft < 0)
        {
            GameOver();
        }
    }
    
    void GameOver()
    {
        gameOverScreen.SetActive(true);

        finalScoreText.text = "The Score is " +  ShootScript.score;
    }

    public void RestartGame()
    {
        gameOverScreen.SetActive(false);
        timeLeft = 30f;
        ShootScript.score = 0;
        scoreText.text = 0 + "";
    }
}
