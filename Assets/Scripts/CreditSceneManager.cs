using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditSceneManager : MonoBehaviour
{
    void Update()
    {
        //Going to Game Over Screen
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("GameOverScene");
        }

        // Returning to First Screen
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
