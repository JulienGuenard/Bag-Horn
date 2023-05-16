using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class SquareInput : MonoBehaviour
{
    SpriteRenderer SpriteR;

    [Header("States")]
    bool isHovered = false;
    bool isClicked = false;
    public bool isSelected = false;

    [Header("Item")]
    GameObject item;
    public Item itemCarried;

    void Awake()
    {
        SpriteR = GetComponent<SpriteRenderer>();
        item = transform.Find("Item").gameObject;

        NewItem();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (isHovered) Interact();
        }
    }

    void Interact()
    {
        if (SquareManager.instance.CheckSquareSelected() != null)
        {
            SquareInput squareSelected = SquareManager.instance.CheckSquareSelected();
            squareSelected.Deselect();
            if (squareSelected.itemCarried != null)
            {
                Item itm = itemCarried;
                itemCarried = squareSelected.itemCarried;
                squareSelected.itemCarried = itm;
                squareSelected.NewItem();
                NewItem();
                SFX.instance.Drop();
            }
            else
            {
                Select();
            }
        }
        else
        {
            Select();
        }
    }

    private void OnMouseOver()
    {
        isHovered = true;
        Tooltip.instance.ShowTooltip(this);
        if (isSelected) return;
        SpriteR.color = ColorManager.instance.squareMouseHover;

        
    }

    private void OnMouseExit()
    {
        isHovered = false;
        Tooltip.instance.HideTooltip();
        if (isSelected) return;
        SpriteR.color = ColorManager.instance.squareMouseNeutral;

        
    }

    public void Deselect()
    {
        isSelected = false;
        SpriteR.color = ColorManager.instance.squareMouseNeutral;
    }

    public void Select()
    {
        isSelected = true;
        SpriteR.color = ColorManager.instance.squareMouseSelected;
        SFX.instance.Click();
    }

    public void NewItem()
    {
        if (itemCarried == null)
        {
            item.GetComponent<SpriteRenderer>().sprite = null;
            return;
        }

        item.GetComponent<SpriteRenderer>().sprite = itemCarried.itemSprite;
    }
}
