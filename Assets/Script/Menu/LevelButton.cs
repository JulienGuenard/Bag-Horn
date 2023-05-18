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

    [TextArea]
    public string levelText;

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
        TooltipButton.instance.ShowTooltip(this.gameObject, levelText);

        if (isSelected) return;

        SpriteR.color = ColorManager.instance.squareMouseHover;
    }

    private void OnMouseExit()
    {
        isHovered = false;
        TooltipButton.instance.HideTooltip();

        if (isSelected) return;

        SpriteR.color = ColorManager.instance.squareMouseNeutral;
    }

    void Select()
    {
        isSelected = true;
        SpriteR.color = ColorManager.instance.squareMouseSelected;
        startButton.SetActive(true);
    }
}
