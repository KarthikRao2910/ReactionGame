using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetryScript : MonoBehaviour
{
    public Text pointsText;
    int scoreRS;
    
    void Start()
    {
        gameObject.SetActive(true);
        scoreRS = StateScoreController.scoreStat;
        pointsText.text = scoreRS.ToString() + " Points";
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("SampleScene");

    }

}
