using UnityEngine;

public class GameController : BaseController
{
    private readonly GameState _gameState;
    private readonly ResourcePath _gameViewResource = new ResourcePath() { PathResource = "Prefabs/Game" };
    private readonly GameView _gameView;
    private readonly GameModel _gameModel;

    public GameController(GameState state, Transform uiRoot)
    {
        _gameState = state;
        _gameModel = new GameModel();
        _gameView = LoadView(uiRoot);
        _gameView.Init(BackToMenu, Restart, ChooseMore, ChooseLess,
            ClickToButton1, ClickToButton2, ClickToButton3,
            ClickToButton4, ClickToButton5, ClickToButton6,
            ClickToButton7, ClickToButton8, ClickToButton9);
        _gameView.SetScore(_gameModel.Score);
    }

    private void BackToMenu()
    {
        _gameState.CurrentGameState.Value = EnumGameState.Menu;
    }

    private void Restart()
    {
        _gameState.CurrentGameState.Value = EnumGameState.Restart;
    }

    private void ChooseMore()
    {
        if(_gameModel.ChooseLess && _gameModel.ChooseMore)
        {
            return;
        }
        _gameModel.ChooseMore = true;
        _gameModel.ChooseLess = false;
    }

    private void ChooseLess()
    {
        if (_gameModel.ChooseLess && _gameModel.ChooseMore)
        {
            return;
        }
        _gameModel.ChooseLess = true;
        _gameModel.ChooseMore = false;
    }

    #region Buttons
    private void ClickToButton1()
    {
        if(_gameModel.ClickButton1)
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButton1 = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(1);
            return;
        }

        LessOrMore(1);
    }

    private void ClickToButton2()
    {
        if (_gameModel.ClickButton2)
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButton2 = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(2);
            return;
        }

        LessOrMore(2);
    }

    private void ClickToButton3()
    {
        if (_gameModel.ClickButton3)
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButton3 = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(3);
            return;
        }

        LessOrMore(3);
    }

    private void ClickToButton4()
    {
        if (_gameModel.ClickButton4)
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButton4 = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(4);
            return;
        }

        LessOrMore(4);
    }

    private void ClickToButton5()
    {
        if (_gameModel.ClickButton5)
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButton5 = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(5);
            return;
        }

        LessOrMore(5);
    }

    private void ClickToButton6()
    {
        if (_gameModel.ClickButton6)
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButton6 = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(6);
            return;
        }

        LessOrMore(6);
    }

    private void ClickToButton7()
    {
        if (_gameModel.ClickButton7)
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButton7 = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(7);
            return;
        }

        LessOrMore(7);
    }

    private void ClickToButton8()
    {
        if (_gameModel.ClickButton8)
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButton8 = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(8);
            return;
        }

        LessOrMore(8);
    }

    private void ClickToButton9()
    {
        if (_gameModel.ClickButton9)
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButton9 = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(9);
            return;
        }

        LessOrMore(9);
    }
    #endregion

    private GameView LoadView(Transform uiRoot)
    {
        var objectView = Object.Instantiate(ResourceLoader.LoadPrefab(_gameViewResource), uiRoot, false);
        AddGameObject(objectView);
        return objectView.GetComponent<GameView>();
    }

    private void FirstClick(int buttonNumber)
    {
        var number = GenerateRandomNumber();
        _gameModel.LastNumber = number;
        _gameModel.ChooseLess = false;
        _gameModel.ChooseMore = false;
        _gameView.SetSprite(buttonNumber, number);
    }

    private void LessOrMore(int buttonNumber)
    {
        var number = GenerateRandomNumber();
        if (_gameModel.ChooseMore)
        {
            if(_gameModel.LastNumber < number)
            {
                _gameModel.Score += _gameModel.WinCoef++;
                _gameModel.LoseCoef = -1;
            }
            else
            {
                _gameModel.Score += _gameModel.LoseCoef--;
                _gameModel.WinCoef = 1;
            }
            _gameModel.ChooseMore = false;
        }
        else if (_gameModel.ChooseLess)
        {
            if(_gameModel.LastNumber > number)
            {
                _gameModel.Score += _gameModel.WinCoef++;
                _gameModel.LoseCoef = -1;
            }
            else
            {
                _gameModel.Score += _gameModel.LoseCoef--;
                _gameModel.WinCoef = 1;
            }
            _gameModel.ChooseLess = false;
        }
        _gameModel.LastNumber = number;
        _gameView.SetSprite(buttonNumber, number);
        _gameView.SetScore(_gameModel.Score);
    }

    private int GenerateRandomNumber()
    {
        var index = Random.Range(0, _gameModel.Numbers.Count);
        var result = _gameModel.Numbers[index];
        _gameModel.Numbers.Remove(_gameModel.Numbers[index]);
        return result;
    }
}
