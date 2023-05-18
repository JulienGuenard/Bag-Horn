using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeToScene : MonoBehaviour
{
    static public FadeToScene instance;

    public string sceneName;

    Animator animator;

    private void Awake()
    {
        if (instance == null) instance = this;

        animator = GetComponent<Animator>();
    }

    public void GoTo_Scene()
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void GoTo_SceneEnding(string name)
    {
        sceneName = name;
        animator.SetTrigger("FadeIn");
    }
}
