using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class SoundManager {


    public static void PlayMoveSound(){
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.i.snakeMove);    
    }

    public static void PlayEatSound(){
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.i.snakeEat);    
    }

    public static void PlayDieSound(){
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.i.snakeDie);    
    }
}
