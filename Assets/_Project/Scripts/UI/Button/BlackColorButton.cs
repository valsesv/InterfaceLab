using TMPro;
using UnityEngine;

namespace UI.Buttons
{
    public class BlackColorButton : ToggleButton
    {
        [Space(10)]
        [SerializeField] private Color textColorOn;
        [SerializeField] private Color textColorOff;
        [SerializeField] private TextMeshProUGUI buttonText;
        [SerializeField] private Color spriteColorOn;
        [SerializeField] private Color spriteColorOff;

        public override void SetButtonOn()
        {
            base.SetButtonOn();
            buttonImage.color = spriteColorOn;
            buttonText.color = textColorOn;
        }

        public override void SetButtonOff()
        {
            base.SetButtonOff();
            buttonImage.color = spriteColorOff;
            buttonText.color = textColorOff;
        }
    }
}