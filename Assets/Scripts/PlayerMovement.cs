using UnityEngine;
using UnityEngine.SceneManagement; // Importar o namespace para gerenciar cenas

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f; // Velocidade de movimento

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Obtém o componente Rigidbody da esfera
    }

    void Update()
    {
        // Obtém a entrada do teclado para ambos os eixos horizontais
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D ou Seta Esquerda/Direita
        float moveVertical = Input.GetAxis("Vertical");     // W/S ou Seta Cima/Baixo

        // Cria um vetor de movimento nos eixos X e Z
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Aplica a força de movimento ao Rigidbody
        rb.AddForce(movement * speed);

        // Verifica a posição Y do jogador
        if (transform.position.y < -2)
        {
            // Reinicia a cena atual
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            CollectibleCube.cubeCount = 0; // Reseta o contador de cubos coletados
        }

        // Returning to First Screen
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
