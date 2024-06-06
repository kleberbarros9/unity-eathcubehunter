using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class CollectibleCube : MonoBehaviour
{
    public static int cubeCount = 0; // Contador global
    private bool isCollected = false; // Flag para evitar múltiplas coletas
    public AudioSource bipSource;

    void Start()
    {
        // Adicione um AudioSource ao GameObject para reproduzir o som
        bipSource = gameObject.AddComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered"); // Verifique se a colisão é detectada

        if (other.CompareTag("Player") && !isCollected)
        {
            Debug.Log("Player Collision Detected"); // Verifique se o jogador colidiu

            // Toca o som de coleta
            bipSource.Play();

            // Incrementa o contador global
            cubeCount++;
            isCollected = true; // Marcar como coletado

            // Imprime o contador no console
            Debug.Log("Cubes Collected: " + cubeCount);

            // Destroi o cubo
            Destroy(gameObject);
            ScoreManager.scoreCount += 1; 

            // Verifica se todos os cubos foram coletados
            if (cubeCount >= 10) // Certifique-se de que este valor é o número correto de cubos
            {
                Debug.Log("Loading Game Over Scene"); // Verifique se a cena de Game Over está sendo carregada
                // Carrega a cena de Game Over
                SceneManager.LoadScene("CreditScene");
            }
        }

        if(other.CompareTag("Cube")){
            ScoreManager.scoreCount += 1;
        }
    }
}
