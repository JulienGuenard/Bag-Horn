using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSuite : MonoBehaviour
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
        SpriteR.color = ColorManager.instance.dialogButtonSuiteHover;
    }

    private void OnMouseExit()
    {
        isHovered = false;
        if (isSelected) return;
        SpriteR.color = ColorManager.instance.dialogButtonSuiteNeutral;
    }

    void Interact()
    {
        DialogManager.instance.NextDialog();
    }
}
