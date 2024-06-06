using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public void go2StartScene(){
        SceneManager.LoadScene("GameScene");
    }

        public void go2CreditScene(){
        SceneManager.LoadScene("CreditScene");
    }
}
