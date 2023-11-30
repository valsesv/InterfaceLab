using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class InfoPanel : UiPanel
{
    [SerializeField] private TextMeshProUGUI textInfo;
    [SerializeField] private float duration = 3f;

    public async void OpenTextPanel(string targetText)
    {
        textInfo.text = targetText;
        OpenPanel();
        await Task.Delay((int)(duration * 1000));
        CloseWindow();
    }
}
