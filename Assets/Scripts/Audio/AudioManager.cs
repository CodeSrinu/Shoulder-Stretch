using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]private AudioSource audioSource;
    [SerializeField]private AudioClip GunShot;
    [SerializeField]private AudioClip ButtonClick;
    [SerializeField]private AudioClip ZombieDead;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            
            audioSource.PlayOneShot(GunShot);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            audioSource.PlayOneShot(ButtonClick);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            audioSource.PlayOneShot(ZombieDead);
            
        }
    }
}
