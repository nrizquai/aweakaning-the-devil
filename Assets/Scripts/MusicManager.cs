using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 2)
            gameObject.GetComponent<AudioSource>().mute = true;
        else
            gameObject.GetComponent<AudioSource>().mute = false;
    }
}
