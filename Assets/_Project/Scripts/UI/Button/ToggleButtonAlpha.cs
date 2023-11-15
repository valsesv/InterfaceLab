using UnityEngine;

namespace UI.Buttons
{
    public class ToggleButtonAlpha : ToggleButton
    {
        [Space(10)]
        [SerializeField] private Color colorOn;
        [SerializeField] private Color colorOff;

        public override void SetButtonOn()
        {
            base.SetButtonOn();
            buttonImage.color = colorOn;
        }

        public override void SetButtonOff()
        {
            base.SetButtonOff();
            buttonImage.color = colorOff;
        }
    }
}