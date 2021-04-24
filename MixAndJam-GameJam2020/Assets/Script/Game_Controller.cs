using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Game_Controller : MonoBehaviour
{
    static Game_Controller instance;
    public int HighScore;
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    bool newScoreDetected;
    public void UpdateScore(int newScore) {
        if (newScore > HighScore)
        {

            HighScore = newScore;
            newScoreDetected = true;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if (newScoreDetected == true) {
            if (SceneManager.GetActiveScene().buildIndex == 0)
            {
                GameObject.FindGameObjectWithTag("Score").GetComponent<Text>().text = HighScore.ToString();
                newScoreDetected = false;
            }
        }
        
    }
}
