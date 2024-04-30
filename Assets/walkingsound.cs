using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingsound : MonoBehaviour
{

    public AudioSource walkingSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("w")){
            walkingSound.Play();
        }

        if(Input.GetKeyDown("s")){
            walkingSound.Play();
        }

        if(Input.GetKeyUp("w")){
            walkingSound.Stop();
        }

        if(Input.GetKeyUp("s")){
            walkingSound.Stop();
        }
    }
}
