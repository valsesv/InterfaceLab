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
        [SerializeField] private Sprite spriteOn;
        [SerializeField] private Sprite spriteOff;

        public override void SetButtonOn()
        {
            base.SetButtonOn();
            buttonImage.sprite = spriteOn;
            buttonText.color = textColorOn;
        }

        public override void SetButtonOff()
        {
            base.SetButtonOff();
            buttonImage.sprite = spriteOff;
            buttonText.color = textColorOff;
        }
    }
}