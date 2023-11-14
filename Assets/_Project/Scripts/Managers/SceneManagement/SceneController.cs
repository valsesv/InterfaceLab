using System.Threading.Tasks;
using Managers.WindowsManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers.SceneManagement
{
    public class SceneController : MonoBehaviour
    {
        [SerializeField] private CanvasGroup loadingScreen;
        [SerializeField] private float minLoadingTime = 1f;

        private const int SleepDelay = (int)(WindowsManager.SwapDuration * 1000);

        private void Start()
        {
            SceneManager.LoadScene((int) SceneType.Menu);
            WindowsManager.CanvasGroupSwap(loadingScreen, false);
        }

        public async void LoadScene(SceneType sceneType)
        {
            WindowsManager.CanvasGroupSwap(loadingScreen, true);
            await Task.Delay(SleepDelay);
            Time.timeScale = 1f;

            var operation = SceneManager.LoadSceneAsync((int) sceneType);
            var startLoadingTime = Time.unscaledTime;

            while (operation.isDone == false || Time.unscaledTime - startLoadingTime < minLoadingTime)
            {
                await Task.Delay(SleepDelay);
            }

            WindowsManager.CanvasGroupSwap(loadingScreen, false);
        }
    }
}
