using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public static DialogManager instance;

    public ButtonSuite buttonSuite;
    public Dialog dialogChosen;
    public TextMeshPro dialogText;
    public Transform dialogBox;
    public Transform dialogPanel;
    public Vector3 rightPos;
    public Vector3 leftPos;
    public string endScene;

    int messageID = -1;

    void Awake()
    {
        if (instance == null) instance = this;

        NextDialog();
    }

    public void NextDialog()
    {
        messageID++;

        if (dialogChosen.messageList.Count <= messageID)
        {
            buttonSuite.enabled = false;
            FadeToScene.instance.GoTo_SceneEnding(endScene);
            return;
        }

        dialogText.text = dialogChosen.messageList[messageID].text;

        if (dialogChosen.messageList[messageID].orientation == Orientation.right)
        {
            dialogPanel.position = rightPos;
            dialogBox.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if (dialogChosen.messageList[messageID].orientation == Orientation.left)
        {
            dialogPanel.position = leftPos;
            dialogBox.localRotation = Quaternion.Euler(0, 0, 0);
        }


        dialogText.text = dialogChosen.messageList[messageID].text;

        


    }
}
