using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetAchievementButton : MonoBehaviour
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
    }

    private void OnMouseExit()
    {
        isHovered = false;
        if (isSelected) return;
    }


    void Interact()
    {
        this.enabled = false;
        AchievementManager.instance.UnfinishAllEndings();
    }
}
