using UnityEngine;
using UnityEngine.UI;

public class ButtonClickSound : MonoBehaviour
{
    public AudioClip buttonSound;

    private Button button;
    private AudioSource audioSource;

    void Start()
    {
        button = GetComponent<Button>();
        audioSource = GetComponent<AudioSource>();
        
        // Adicione o som ao AudioSource
        audioSource.clip = buttonSound;

        // Adicione o evento de clique ao botão
        button.onClick.AddListener(PlaySound);
    }

    void PlaySound()
    {
        // Toca o som
        audioSource.Play();
    }
}
