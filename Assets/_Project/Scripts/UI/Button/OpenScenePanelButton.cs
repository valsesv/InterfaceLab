using UnityEngine;
using UnityEngine.UI;

namespace UI.Buttons
{
    [RequireComponent(typeof(Button))]
    public class OpenScenePanelButton : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private UiPanel uiPanel;
        [SerializeField] private UiPanel[] panelToClose;

        private void Start()
        {
            button.onClick.AddListener(OpenPanel);
        }

        private void OpenPanel()
        {
            foreach (var panel in panelToClose)
            {
                panel.CloseWindow();
            }

            uiPanel.OpenPanel();
        }
    }
}