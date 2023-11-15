using System;
using UnityEngine;

namespace UI.Buttons
{
    public class ToggleButtonsController : MonoBehaviour
    {
        [SerializeField] private ToggleButton[] buttons;
        [SerializeField] private ToggleButton startButton;

        private void Start()
        {
            foreach (var button in buttons)
            {
                button.OnButtonOn += ChangeButton;
            }
            startButton.SetButtonOn();
        }

        private void ChangeButton(ToggleButton targetButton)
        {
            foreach (var button in buttons)
            {
                if (button == targetButton)
                {
                    continue;
                }
                button.SetButtonOff();
            }
        }
    }
}