using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiogame : MonoBehaviour
{

    public static AudioClip playerHitSound, FireSound, jumpSound, enemyDeathSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        enemyDeathSound = Resources.Load<AudioClip>("deethgame");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound()
    {
        audioSrc.PlayOneShot(enemyDeathSound);
    }
}

