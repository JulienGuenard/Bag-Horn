using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    SpriteRenderer SpriteR;

    [Header("States")]
    bool isHovered = false;
    bool isSelected = false;

    public GameObject startButton;

    void Awake()
    {
        SpriteR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (isHovered) Select();
        }
    }

    private void OnMouseOver()
    {
        isHovered = true;
        if (isSelected) return;
        SpriteR.color = ColorManager.instance.squareMouseHover;

        TooltipLevel.instance.ShowTooltip(this.gameObject);
    }

    private void OnMouseExit()
    {
        isHovered = false;
        if (isSelected) return;
        SpriteR.color = ColorManager.instance.squareMouseNeutral;

        TooltipLevel.instance.HideTooltip();
    }

    void Select()
    {
        isSelected = true;
        SpriteR.color = ColorManager.instance.squareMouseSelected;
        startButton.SetActive(true);
    }
}
