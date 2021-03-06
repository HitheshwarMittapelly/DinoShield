﻿using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class SoundManagerScript : MonoBehaviour
{
    public AudioSource efxSource;                  
    public AudioSource musicSource;                
    public static SoundManagerScript instance = null;            
    public float lowPitchRange = .95f;             
    public float highPitchRange = 1.05f;           


    void Awake()
    {
       
        if (instance == null)
         
            instance = this;
       
        else if (instance != this)
           
            Destroy(gameObject);

      
        DontDestroyOnLoad(gameObject);
    }


   
    public void PlaySingle(AudioClip clip)
    {
        efxSource.Stop();
        efxSource.clip = clip;


        //Play the clip.
        efxSource.Play();
    }


   
    
}