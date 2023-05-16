using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public static SFX instance;

    AudioSource audioS;

    public AudioClip click;
    public AudioClip drop;

    void Awake()
    {
        if (instance == null) instance = this;

        audioS = GetComponent<AudioSource>();
    }

    public void Click()
    {
        audioS.pitch = Random.Range(0.7f, 1.3f);
        audioS.PlayOneShot(click);
    }

    public void Drop()
    {
        audioS.pitch = Random.Range(0.7f, 1.3f);
        audioS.PlayOneShot(drop);
    }
}
