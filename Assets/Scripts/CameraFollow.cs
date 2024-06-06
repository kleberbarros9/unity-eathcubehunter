using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // A esfera
    public Vector3 offset;    // A posição relativa da câmera em relação à esfera

    void Start()
    {
        // Inicializar o offset com a posição inicial da câmera em relação à esfera
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        // Atualizar a posição da câmera para seguir a esfera sem rolar junto
        transform.position = target.position + offset;
    }
}
