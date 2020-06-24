using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameSession : MonoBehaviour {

    // config params
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 83;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] bool isAutoPlayEnabled;
    [SerializeField] bool isPaused = false;
    public GameObject pauseMenuUI;
    [SerializeField] TextMeshProUGUI pauseText;
    [SerializeField] TextMeshProUGUI highScore;

    public int zPush = 0;

    // state variables
    [SerializeField] int currentScore = 0;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            currentScore += pointsPerBlockDestroyed;
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        scoreText.text = currentScore.ToString();    
        highScore.text = "High Score :"+    PlayerPrefs.GetInt("High",0);
    }

    // Update is called once per frame
    void Update () {
        scoreText.text = currentScore.ToString();  
              if(Input.GetKeyDown("p") && !isPaused)
    {
       print("p");
       pauseText.text = "game paused p to unpause";
       Time.timeScale = 0;
       isPaused = true;
    }
    else if(Input.GetKeyDown("p") && isPaused)
    {
       print("Unpaused");
    pauseText.text = "press p to pause";

       Time.timeScale = 1;
       isPaused = false;    
    } 
	}

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();

    }

    public void ResetGame()
    {
       
        if (currentScore > PlayerPrefs.GetInt("High")){
        PlayerPrefs.SetInt("High", currentScore);
        }
         Destroy(gameObject);

    }
    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }
}
