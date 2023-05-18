using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;

    AudioSource AudioS;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

        AudioS = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (AudioS.volume == 0)
        {
            Destroy(this.gameObject);
        }

        if (SceneManager.GetActiveScene().name == "Level Selection")
        {
            AudioS.volume -= 1f;
        }
    }


}
