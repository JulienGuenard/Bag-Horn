using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    SpriteRenderer SpriteR;

    [Header("States")]
    bool isHovered = false;
    bool isSelected = false;

    void Awake()
    {
        SpriteR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (isHovered) Interact();
        }
    }

    private void OnMouseOver()
    {
        isHovered = true;
        if (isSelected) return;
        SpriteR.color = ColorManager.instance.squareMouseHover;
    }

    private void OnMouseExit()
    {
        isHovered = false;
        if (isSelected) return;
        SpriteR.color = ColorManager.instance.squareMouseNeutral;
    }


    void Interact()
    {
        this.enabled = false;
        FadeToScene.instance.GoTo_SceneEnding("1- Olaf & Nathan");
    }
}
