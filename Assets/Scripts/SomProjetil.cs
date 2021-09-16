using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomProjetil : MonoBehaviour
{
    AudioSource m_MyAudioSource;

    
    bool m_Play;
    

    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
        {
             m_MyAudioSource.Play();
        }
    }
}
