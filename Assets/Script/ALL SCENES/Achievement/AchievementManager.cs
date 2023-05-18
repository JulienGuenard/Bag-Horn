using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AchievementManager : MonoBehaviour
{
    public static AchievementManager instance;

    public List<bool> endingDoneList;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void CheckAchievements()
    {
        if (LevelManager.instance == null) return;

        for(int i = 0; i < endingDoneList.Count; i++)
        {
            if (endingDoneList[i]) LevelManager.instance.finishAchievement(i);
        }
    }

    public void FinishEnding(int id)
    {
        endingDoneList[id] = true;
    }

    public void UnfinishAllEndings()
    {
        for (int i = 0; i < endingDoneList.Count; i++)
        {
            endingDoneList[i] = false;
        }

        LevelManager.instance.unfinishAllAchievements();
    }
}
