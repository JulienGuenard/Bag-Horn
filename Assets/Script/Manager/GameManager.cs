using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string dialogScene_Bad;
    public string dialogScene_Good;
    public string dialogScene_Super1;
    public string dialogScene_Super2;
    public string selectionLevelScene;

    public Button validateBtn;
    public Button resetBtn;
    public Button returnToMenuBtn;

    public void Validate()
    {
        validateBtn.interactable = false;
        resetBtn.interactable = false;
        returnToMenuBtn.interactable = false;

        if (SatisfactionManager.instance.character1_satisfaction >= SatisfactionManager.instance.character1.character.superEndingCount)
        {
            FadeToScene.instance.GoTo_SceneEnding(dialogScene_Super1);
            return;
        }

        if (SatisfactionManager.instance.character2_satisfaction >= SatisfactionManager.instance.character2.character.superEndingCount)
        {
            FadeToScene.instance.GoTo_SceneEnding(dialogScene_Super2);
            return;
        }

        if (SatisfactionManager.instance.character1_satisfaction >= SatisfactionManager.instance.character1.character.goodEndingCount
            && SatisfactionManager.instance.character2_satisfaction >= SatisfactionManager.instance.character2.character.goodEndingCount)
        {
            FadeToScene.instance.GoTo_SceneEnding(dialogScene_Good);
            return;
        }

        FadeToScene.instance.GoTo_SceneEnding(dialogScene_Bad);

    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }

    public void ReturnToMenu()
    {
        if (validateBtn != null) validateBtn.interactable = false;
        if (resetBtn != null) resetBtn.interactable = false;
        returnToMenuBtn.interactable = false;

        FadeToScene.instance.GoTo_SceneEnding(selectionLevelScene);
    }
}
