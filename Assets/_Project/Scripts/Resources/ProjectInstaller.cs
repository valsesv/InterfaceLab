using Managers.SceneManagement;
using UnityEngine;
using Zenject;

public class ProjectInstaller : MonoInstaller
{
    [SerializeField] private SceneController sceneController;

    public override void InstallBindings()
    {
        Container.Bind<SceneController>().FromInstance(sceneController).AsSingle();
    }
}