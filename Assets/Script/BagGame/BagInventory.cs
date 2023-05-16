using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BagInventory : MonoBehaviour
{
    public List<Item> itemCarriedList;

    public List<SquareInput> squareList;

    void Awake()
    {
        
    }

    void Update()
    {
        CheckItemCarried();
    }

    public void CheckItemCarried()
    {
        List<Item> newList = new List<Item>();
        foreach (SquareInput square in squareList)
        {
            if (square.itemCarried != null) newList.Add(square.itemCarried);
        }
        itemCarriedList.RemoveRange(0, itemCarriedList.Count);

        if (newList.Count == 0) return;

        itemCarriedList.AddRange(newList);

        SatisfactionManager.instance.CompareBagAndAllCharacters();
    }
}
