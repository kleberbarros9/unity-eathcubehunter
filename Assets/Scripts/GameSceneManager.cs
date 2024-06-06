using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    private ScoreManager scoreManager;

    
    private void Start(){
        scoreManager = FindAnyObjectByType<ScoreManager>();
        ScoreManager.scoreCount = 0;
    }

/*
    public void RestartLevel(){
        ScoreManager.scoreCount = 0;
    }
    */
}
