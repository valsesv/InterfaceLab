using DG.Tweening;
using UnityEngine;

namespace Managers.WindowsManagement
{
    public static class WindowsManager
    {
        public const float SwapDuration = 0.25f;

        public static void CanvasGroupSwap(CanvasGroup canvasGroup, bool isEnabled)
        {
            canvasGroup.DOFade(isEnabled? 1 : 0, SwapDuration).SetUpdate(true);

            canvasGroup.interactable = isEnabled;
            canvasGroup.blocksRaycasts = isEnabled;
        }
    }
}
