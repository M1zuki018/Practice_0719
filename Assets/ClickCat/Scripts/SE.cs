using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SE : MonoBehaviour
{
    AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlaySe(AudioClip clip)
    {
        _audioSource.clip = clip;
        _audioSource.Play();
    }
}
