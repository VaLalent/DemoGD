using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActionButtonUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private Button button;
    [SerializeField] private GameObject selectedGameObject;

    private BaseAction baseAction;
    public void SetBaseAction(BaseAction baseAction)
    {
        this.baseAction = baseAction;
        textMeshPro.text = baseAction.GetActionName().ToUpper();

        button.onClick.AddListener(() =>
        {
            UnitActionSystem.instance.SetSelectedAction(baseAction);
        });
    }

    public void UpdateSelectedVisaul()
    {
        BaseAction selectedBaseAction = UnitActionSystem.instance.GetSelecetedAction();
        selectedGameObject.SetActive(selectedBaseAction == baseAction);
    }
}
