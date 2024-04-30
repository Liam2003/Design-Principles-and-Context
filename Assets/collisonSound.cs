using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisonSound : MonoBehaviour
{
    
    public AudioSource playTheAudio;

    void OnCollisionEnter(Collision collision)
    {
        playTheAudio.Play();
    }

}
