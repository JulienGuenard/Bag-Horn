using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Gameplay Objects/Character", order = 1)]
public class Character : ScriptableObject
{
    public List<ItemGoodList> itemGoodList;
    public int goodEndingCount;
    public int superEndingCount;
    public int badEndingCount;
}