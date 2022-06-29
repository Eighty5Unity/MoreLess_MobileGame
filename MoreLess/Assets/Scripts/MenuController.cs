using UnityEngine;

public class MenuController : BaseController
{
    private readonly GameState _gameState;
    private readonly ResourcePath _menuViewResource = new ResourcePath() { PathResource = "Prefabs/Menu" };
    private readonly MenuView _menuView;

    public MenuController(GameState gameState, Transform uiRoot)
    {
        _gameState = gameState;
        _menuView = LoadView(uiRoot);
        _menuView.Init(StartGame);
    }

    private void StartGame()
    {
        _gameState.CurrentGameState.Value = EnumGameState.Game;
    }

    private MenuView LoadView(Transform uiRoot)
    {
        var objectView = Object.Instantiate(ResourceLoader.LoadPrefab(_menuViewResource), uiRoot, false);
        AddGameObject(objectView);
        return objectView.GetComponent<MenuView>();
    }
}
