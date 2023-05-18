using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TooltipButton : MonoBehaviour
{
    static public TooltipButton instance;

    public Transform tooltipPanel;
    public TextMeshPro textMesh;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void ShowTooltip(GameObject button, string text)
    {

        Vector3 newPos = button.transform.position;
        transform.position = button.transform.position;

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

        tooltipPanel.localPosition = new Vector3 (newRectPos.x, tooltipPanel.localPosition.y, 0);

        textMesh.text = text;
    }

    public void HideTooltip()
    {
        transform.position = new Vector3(999,999,999);
    }
}
