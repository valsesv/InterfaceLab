using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSwitchButton : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private Image imageToChange;
    [SerializeField] private Sprite spriteOn;
    [SerializeField] private Sprite spriteOff;

    private bool _isOn = true;

    private void Start()
    {
        if (imageToChange == null)
        {
            return;
        }
        button.onClick.AddListener(SwitchImage);
    }

    private void SwitchImage()
    {
        _isOn = !_isOn;
        imageToChange.sprite = _isOn ? spriteOn : spriteOff;
    }

}
