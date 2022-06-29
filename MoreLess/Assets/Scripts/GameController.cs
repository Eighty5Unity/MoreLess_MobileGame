using UnityEngine;

public class GameController : BaseController
{
    private readonly GameState _gameState;
    private readonly ResourcePath _gameViewResource = new ResourcePath() { PathResource = "Prefabs/Game" };
    private readonly GameView _gameView;

    public GameController(GameState state, Transform uiRoot)
    {
        _gameState = state;
        _gameView = LoadView(uiRoot);
        _gameView.Init(BackToMenu);
    }

    private void BackToMenu()
    {
        _gameState.CurrentGameState.Value = EnumGameState.Menu;
    }

    private GameView LoadView(Transform uiRoot)
    {
        var objectView = Object.Instantiate(ResourceLoader.LoadPrefab(_gameViewResource), uiRoot, false);
        AddGameObject(objectView);
        return objectView.GetComponent<GameView>();
    }
}
