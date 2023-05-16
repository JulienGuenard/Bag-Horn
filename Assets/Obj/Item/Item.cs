using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Gameplay Objects/Item", order = 1)]
public class Item : ScriptableObject
    {
        public Sprite itemSprite;
        public string itemName;
        public Owner itemOwner;
    [TextArea] public string itemDescription;
    }