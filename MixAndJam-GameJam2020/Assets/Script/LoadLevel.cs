using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour
{
    public Text scoreTxt;
    public void Load(int index) {
        SceneManager.LoadScene(index);
    }

    public void LoadAndUpdate(int index)
    {
        int score = int.Parse(scoreTxt.text);
        FindObjectOfType<Game_Controller>().UpdateScore(score);
        SceneManager.LoadScene(index);
    }
}
