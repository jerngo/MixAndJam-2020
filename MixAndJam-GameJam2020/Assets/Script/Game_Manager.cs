using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Game_Manager : MonoBehaviour
{
    public Text scoreText;
    // Start is called before the first frame update
    private void Start()
    {
        scoreText.text = "0";
    }
    public void addScore(int scoring) {
        int teksscor = int.Parse(scoreText.text);
          teksscor += scoring;

        scoreText.text = teksscor.ToString();
    }
}
