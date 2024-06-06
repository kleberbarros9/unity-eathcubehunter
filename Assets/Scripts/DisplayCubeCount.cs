using UnityEngine;
using UnityEngine.UI;

public class DisplayCubeCount : MonoBehaviour
{
    public Text cubeCountText;

    void Update()
    {
        cubeCountText.text = "Cubes Collected: " + CollectibleCube.cubeCount;
    }
}
