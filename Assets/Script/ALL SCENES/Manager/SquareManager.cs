using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareManager : MonoBehaviour
{
    static public SquareManager instance;

    public List<SquareInput> listSquare;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    private void Update()
    {
        if (listSquare.Count == 0)
        {
            foreach (SquareInput obj in GameObject.FindObjectsOfType<SquareInput>())
            {
                listSquare.Add(obj);
            }
        }
    }

    public SquareInput CheckSquareSelected()
    {
        foreach (SquareInput obj in listSquare)
        {
            if (obj.isSelected) return obj;
        }
        return null;
    }
}
