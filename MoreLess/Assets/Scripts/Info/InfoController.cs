using UnityEngine;

public class InfoController : BaseController
{
    private readonly GameState _gameState;
    private readonly InfoView _infoView;

    public InfoController(GameState gameState, Transform uiRoot)
    {
        _gameState = gameState;
        AddController(this);
        _infoView = LoadView(uiRoot);
        _infoView.Init(BackToMenu);
    }

    private void BackToMenu()
    {
        _gameState.CurrentGameState.Value = EnumGameState.Menu;
    }

    private InfoView LoadView(Transform uiRoot)
    {
        var objectView = Object.Instantiate(ResourceLoader.LoadPrefab(PrefabLinks.infoViewResource), uiRoot, false);
        AddGameObject(objectView);
        return objectView.GetComponent<InfoView>();
    }
}
