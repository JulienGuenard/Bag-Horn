using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    static public ColorManager instance;

    public Color squareMouseHover;
    public Color squareMouseNeutral;
    public Color squareMouseSelected;

    public Color bagMouseHover;
    public Color bagMouseNeutral;

    public Color dialogButtonSuiteNeutral;
    public Color dialogButtonSuiteHover;

    void Awake()
    {
        if (instance == null) instance = this;
    }
}
