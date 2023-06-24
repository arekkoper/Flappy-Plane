using Game.Presentation;
using JetBrains.Annotations;
using UnityEngine;
using Zenject;

public class PresentationInstaller : MonoInstaller
{
    [Header("References")]
    [SerializeField] private UIManager _uiManager;

    [Header("Factories")]
    [SerializeField] private MainMenuView _mainMenuView;

    public override void InstallBindings()
    {
        Debug.Log("Presentation Installer");
        Container.Bind<UIManager>().FromInstance(_uiManager).AsSingle();

        //Factories
        Container.BindFactory<MainMenuView, MainMenuView.Factory>().FromComponentInNewPrefab(_mainMenuView).UnderTransform(_uiManager.transform);
        
    }
}