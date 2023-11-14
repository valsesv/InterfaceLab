using Managers.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace UI.Buttons
{
    public class OpenSceneButton : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private SceneType sceneType;
    
        [Inject] private SceneController _sceneController;

        protected virtual void Start()
        {
            button.onClick.AddListener(LoadScene);
        }


        protected virtual void LoadScene()
        {
            _sceneController.LoadScene(sceneType);
        }
    }
}
