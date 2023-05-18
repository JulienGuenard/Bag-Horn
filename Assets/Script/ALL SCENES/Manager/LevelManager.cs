using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public List<TextMeshPro> achievementTextList;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    private void Start()
    {
        AchievementManager.instance.CheckAchievements();
    }

    public void finishAchievement(int id)
    {
        if (achievementTextList[id] == null) return;

        achievementTextList[id].color = ColorManager.instance.achievementFinished;
    }

    public void unfinishAllAchievements()
    {
        foreach(TextMeshPro txt in achievementTextList)
        {
            txt.color = ColorManager.instance.achievementUnfinished;
        }
    }
}
