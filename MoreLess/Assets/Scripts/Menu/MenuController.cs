using UnityEngine;

public class MenuController : BaseController
{
    private readonly GameState _gameState;
    private readonly MenuView _menuView;

    public MenuController(GameState gameState, Transform uiRoot)
    {
        _gameState = gameState;
        AddController(this);
        _menuView = LoadView(uiRoot);
        _menuView.Init(StartGame, ShowInfo, ShowLeaderBord, OpenStore, OpenTwitter, OpenFacebook);
    }

    private void StartGame()
    {
        _gameState.CurrentGameState.Value = EnumGameState.Game;
    }

    private void ShowInfo()
    {
        _gameState.CurrentGameState.Value = EnumGameState.Info;
    }

    private void ShowLeaderBord()
    {
        _menuView.SetRecordScore(_gameState.PlayerScore);
        _menuView.ShowRecordPanel();
    }

    private void OpenStore()
    {

    }

    private void OpenTwitter()
    {
        Application.OpenURL("https://twitter.com");
    }

    private void OpenFacebook()
    {
        Application.OpenURL("https://www.facebook.com");
    }

    private MenuView LoadView(Transform uiRoot)
    {
        var objectView = Object.Instantiate(ResourceLoader.LoadPrefab(PrefabLinks.menuViewResource), uiRoot, false);
        AddGameObject(objectView);
        return objectView.GetComponent<MenuView>();
    }
}
