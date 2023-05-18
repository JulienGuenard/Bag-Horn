using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TooltipLevel : MonoBehaviour
{
    static public TooltipLevel instance;

    public Transform tooltipPanel;
    public TextMeshPro textMesh;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void ShowTooltip(GameObject button)
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

        textMesh.text = "<b>Oluf le bonhomme de neige</b><br>Rangez les affaires de Oluf le bonhomme de neige, et de Nathan son fidèle constructeur.";
    }

    public void HideTooltip()
    {
        transform.position = new Vector3(999,999,999);
    }
}
