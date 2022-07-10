using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField] private Transform _uiRoot;

    private MainController _mainController;

    private void Awake()
    {
        var gameState = new GameState();
        gameState.CurrentGameState.Value = EnumGameState.Menu;
        _mainController = new MainController(gameState, _uiRoot);
    }

    protected void OnDestroy()
    {
        _mainController?.Dispose();
    }
}
