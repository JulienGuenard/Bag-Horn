using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tooltip : MonoBehaviour
{
    static public Tooltip instance;

    Animator animator;

    public Transform tooltipPanel;
    public TextMeshPro textMesh;

    SquareInput squareShowed;

    void Awake()
    {
        if (instance == null) instance = this;

        animator = GetComponent<Animator>();
    }

    public void ShowTooltip(SquareInput square)
    {
        if (square.itemCarried == null) return;

        

        Vector3 newPos = square.transform.position;
        transform.position = square.transform.position;

        Vector3 newRectPos = tooltipPanel.localPosition;

        if (transform.position.x < 1 && newRectPos.x > -1)
        {
            newRectPos.x = 0;
        }

        if (transform.position.x >= 1)
        {
            newRectPos.x = -0.6f;
        }

        if (transform.position.x <= -1)
        {
            newRectPos.x = 0.6f;
        }

        if (transform.position.y >= 0.8f)
        {
            newRectPos.y = -1.15f;
        }

        if (transform.position.y < 0.8f)
        {
            newRectPos.y = 1.15f;
        }

        tooltipPanel.localPosition = new Vector3 (newRectPos.x, newRectPos.y, 0);

        textMesh.text = square.itemCarried.itemDescription;

        if (square == squareShowed) return;

        animator.SetTrigger("Spawn");
        squareShowed = square;
    }

    public void HideTooltip()
    {
        transform.position = new Vector3(999,999,999);
    }
}
