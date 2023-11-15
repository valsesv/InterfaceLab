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
        [SerializeField] private Sprite onSprite;
        [SerializeField] private Sprite offSprite;

        public override void SetButtonOn()
        {
            base.SetButtonOn();
            buttonImage.sprite = onSprite;
            buttonText.color = textColorOn;
        }

        public override void SetButtonOff()
        {
            base.SetButtonOff();
            buttonImage.sprite = offSprite;
            buttonText.color = textColorOff;
        }
    }
}