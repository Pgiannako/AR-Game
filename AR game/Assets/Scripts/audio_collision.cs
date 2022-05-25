using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_collision : MonoBehaviour
{

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision sound)
    {
        if (sound.gameObject.tag == "collision")
        {
            audioSource.Play();
        }

    }
}