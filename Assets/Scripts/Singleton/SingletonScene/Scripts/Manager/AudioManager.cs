using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance = null;

    public static AudioManager Instance
    {
        get 
        {
            if(instance == null)
            {
                instance = new AudioManager();
            }
            return instance; 
        }
    }

    void Start()
    {
        if(Instance == null)
        {
            instance = this;
        }
    }

    int point = 0;

    public void Play(AudioClip clip)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }

    public int getPoint() => point++;

}
