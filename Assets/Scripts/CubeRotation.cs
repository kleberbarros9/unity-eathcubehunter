using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(50f, 50f, 50f);  // Ajuste a velocidade de rotação para cada eixo

    void Update()
    {
        // Aplicar rotação contínua ao cubo
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
