using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    static public ColorManager instance;

    public Color squareMouseHover;
    public Color squareMouseNeutral;
    public Color squareMouseSelected;

    public Color achievementUnfinished;
    public Color achievementFinished;

    public Color dialogButtonSuiteNeutral;
    public Color dialogButtonSuiteHover;

    void Awake()
    {
        if (instance == null) instance = this;
    }
}
