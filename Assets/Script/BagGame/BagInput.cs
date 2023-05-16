using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagInput : MonoBehaviour
{
    SpriteRenderer SpriteR;

    void Awake()
    {
        SpriteR = GetComponent<SpriteRenderer>();
    }

    private void OnMouseOver()
    {
        SpriteR.color = ColorManager.instance.bagMouseHover;
        SpriteR.sortingOrder = 1;
    }

    private void OnMouseExit()
    {

        SpriteR.color = ColorManager.instance.bagMouseNeutral;
        SpriteR.sortingOrder = 5;
    }
}
