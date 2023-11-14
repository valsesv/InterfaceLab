using System;
using Managers.WindowsManagement;
using UnityEngine;
using UnityEngine.UI;

public class UiPanel : MonoBehaviour
{
    [SerializeField] private bool isStartPanel;
    [SerializeField] private Button[] closeButtons;

    private CanvasGroup _canvasGroup;

    public event Action OnOpen;
    public event Action OnClosed;

    protected virtual void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        HidePanelInstantly();
    }

    protected virtual void Start()
    {
        foreach (var button in closeButtons)
        {
            button.onClick.AddListener(CloseWindow);
        }
        if (isStartPanel)
        {
            OpenPanel();
        }
    }

    public virtual void OpenPanel()
    {
        WindowsManager.CanvasGroupSwap(_canvasGroup, true);
        OnOpen?.Invoke();
    }

    public virtual void CloseWindow()
    {
        WindowsManager.CanvasGroupSwap(_canvasGroup, false);
        OnClosed?.Invoke();
    }

    private void HidePanelInstantly()
    {
        _canvasGroup.alpha = 0f;
        _canvasGroup.interactable = false;
        _canvasGroup.blocksRaycasts = false;
    }
}
