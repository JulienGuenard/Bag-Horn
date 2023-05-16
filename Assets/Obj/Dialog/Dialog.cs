using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialog", menuName = "Gameplay Objects/Dialog", order = 1)]
public class Dialog : ScriptableObject
{
    [System.Serializable]
    public class Message
        {
        [TextArea]
           public string text;
           public Character character;
            public Orientation orientation;
        }

    public List<Message> messageList;
}