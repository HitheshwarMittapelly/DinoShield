using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public static Manager Instance = null;
    public Image lifeOne;
    public Image lifeTwo;
    public Image lifeThree;
    public Text scoreText;
    public Text EndGameScore;
    public GameObject StartScreenPanel;
    public GameObject EndScreenPanel;

    public AudioClip AsteroidHitShield;
    public AudioClip AsteroidHitEgg;
    public AudioClip ShieldUp;
    public AudioClip AsteroidRelease;
    public AudioClip bgm;
    public int currentlyActiveEggs;
    public bool isGameStarted;
    private int score = 0;
    private int damagedEggs = 0;
    public void Awake()
    {
        if (Instance == null)
            Instance = this;

        else if (Instance != null)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        StartScreenPanel.SetActive(true);
        StartScreenPanel.transform.SetAsLastSibling();

       
    }
    // Use this for initialization
    void Start () {
        scoreText.text = "";
        isGameStarted = false;
        currentlyActiveEggs = 0;
        //scoreText.text = "Score :"+ score.ToString() ;
	}
	
	// Update is called once per frame
	void Update () {
        if (isGameStarted)
        {
            scoreText.text = "Score : " + score.ToString();
            
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartGame();
            }
        }
    }

    public void updateScore()
    {
        score++;

    }

    public void StartGame()
    {
        isGameStarted = true;
        StartScreenPanel.SetActive(false);
        //StartScreenPanel.transform.SetAsFirstSibling();
    }
    public void updateDamagedEggs()
    {
       
        damagedEggs++;
        if(damagedEggs == 1)
        {
            lifeThree.CrossFadeAlpha(0f, 0.1f, false);
        }else if(damagedEggs == 2)
        {
            lifeTwo.CrossFadeAlpha(0f, 0.1f, false);
        }
        else if(damagedEggs == 3)
        {
            lifeOne.CrossFadeAlpha(0f, 0.1f, false);
        }
        else if(damagedEggs>3)
        {
            SoundManagerScript.instance.efxSource.Stop();
            SoundManagerScript.instance.musicSource.Stop();
            isGameStarted = false;
            Debug.Log("Game Over");
            EndGameScore.text = "Your score is: " + score.ToString();
            EndScreenPanel.SetActive(true);
            EndScreenPanel.transform.SetAsLastSibling();
            isGameStarted = false;
        }
    }
}
