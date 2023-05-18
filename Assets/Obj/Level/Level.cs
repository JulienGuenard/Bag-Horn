using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "Gameplay Objects/Level", order = 1)]
public class Level : ScriptableObject
{
    [System.Serializable]
    public class LevelAchievement
        {
        [TextArea]
           public string title;
        public bool nothing;
        }

    public List<LevelAchievement> levelAchievementList;
}