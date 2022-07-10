using UnityEngine;

public class MainController : BaseController
{
    private readonly GameState _gameState;
    private readonly Transform _uiRoot;
    private MenuController _menuController;
    private GameController _gameController;
    private InfoController _infoController;

    public MainController(GameState gameState, Transform uiRoot)
    {
        _gameState = gameState;
        _uiRoot = uiRoot;

        GameStateChanged(_gameState.CurrentGameState.Value);
        gameState.CurrentGameState.SubscribeOnChange(GameStateChanged);
    }

    private void GameStateChanged(EnumGameState state)
    {
        switch (state)
        {
            case EnumGameState.Menu:
                _menuController = new MenuController(_gameState, _uiRoot);
                _gameController?.Dispose();
                _infoController?.Dispose();
                break;
            case EnumGameState.Info:
                _infoController = new InfoController(_gameState, _uiRoot);
                _menuController?.Dispose();
                break;
            case EnumGameState.Game:
                _gameController = new GameController(_gameState, _uiRoot);
                _menuController?.Dispose();
                break;
            case EnumGameState.Restart:
                _gameController?.Dispose();
                _gameState.CurrentGameState.Value = EnumGameState.Game;
                break;
            default:
                _menuController?.Dispose();
                _gameController?.Dispose();
                _infoController?.Dispose();
                break;
        }
    }

    protected override void OnDispose()
    {
        _menuController?.Dispose();
        _gameController?.Dispose();
        _infoController?.Dispose();
        _gameState.CurrentGameState.UnSubscribe(GameStateChanged);
        base.OnDispose();
    }
}
