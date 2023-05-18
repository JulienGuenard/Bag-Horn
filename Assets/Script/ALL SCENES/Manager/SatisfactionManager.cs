using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SatisfactionManager : MonoBehaviour
{
    static public SatisfactionManager instance;

    public string goodText;
    public string superText;
    public string badText;

    public BagInventory bagInventory;

    [System.Serializable]
    public class CharacterProfile
    {
        public Character character;
        public TextMeshPro characterSatisfaction;
    }

    public CharacterProfile character1;
    public CharacterProfile character2;

    public int character1_satisfaction;
    public int character2_satisfaction;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    void Update()
    {

    }

    public void CompareBagAndAllCharacters()
    {
        CompareBagAndCharacter(character1);
        CompareBagAndCharacter(character2);
    }

    void CompareBagAndCharacter(CharacterProfile character)
    {
        int goodItemCount = 0;
        foreach(Item bagItem in bagInventory.itemCarriedList)
        {
            foreach (ItemGoodList characterItem in character.character.itemGoodList)
            {
                if (bagItem == characterItem.item)
                {
                    goodItemCount += characterItem.value;
                }
            }
        }

        if (goodItemCount >= character.character.superEndingCount)
        {
            if (character.characterSatisfaction.text == superText) return;

            character.characterSatisfaction.text = superText;
            character.characterSatisfaction.GetComponent<Animator>().SetTrigger("Change");

        }
        else if (goodItemCount >= character.character.goodEndingCount)
        {
            if (character.characterSatisfaction.text == goodText) return;

            character.characterSatisfaction.text = goodText;
            character.characterSatisfaction.GetComponent<Animator>().SetTrigger("Change");
        }
        else
        {
            if (character.characterSatisfaction.text == badText) return;

            character.characterSatisfaction.text = badText;
            character.characterSatisfaction.GetComponent<Animator>().SetTrigger("Change");
        }

        if (character == character1)
        {
            character1_satisfaction = goodItemCount;
        }

        if (character == character2)
        {
            character2_satisfaction = goodItemCount;
        }
    }
}
