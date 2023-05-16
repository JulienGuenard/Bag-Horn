using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tooltip : MonoBehaviour
{
    static public Tooltip instance;

    public Transform tooltipPanel;
    public TextMeshPro textMesh;

    void Awake()
    {
        if (instance == null) instance = this;
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
            newRectPos.y = -1.5f;
        }

        if (transform.position.y < 0.8f)
        {
            newRectPos.y = 1.5f;
        }

        tooltipPanel.localPosition = new Vector3 (newRectPos.x, newRectPos.y, 0);

        textMesh.text = square.itemCarried.itemDescription;
    }

    public void HideTooltip()
    {
        transform.position = new Vector3(999,999,999);
    }
}
