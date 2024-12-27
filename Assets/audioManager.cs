using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioClip music;

    AudioSource Audio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
