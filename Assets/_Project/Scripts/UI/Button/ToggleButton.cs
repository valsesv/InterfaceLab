using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Buttons
{
    public class ToggleButton : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] protected Image buttonImage;
        
        public event Action<ToggleButton> OnButtonOn;

        private void Start()
        {
            button.onClick.AddListener(SetButtonOn);
        }

        public virtual void SetButtonOn()
        {
            OnButtonOn?.Invoke(this);
        }


        public virtual void SetButtonOff()
        {

        }
    }
}