using UnityEngine;
using UnityEngine.Events;

public class GameController : BaseController
{
    private readonly GameState _gameState;
    private readonly GameView _gameView;
    private readonly GameModel _gameModel;
    private UnityAction[] _clickToButtons;

    public GameController(GameState state, Transform uiRoot)
    {
        _gameState = state;
        _gameModel = new GameModel(_gameState);
        AddController(this);
        _gameView = LoadView(uiRoot);
        ClickToButtonsAction();
        _gameView.Init(BackToMenu, Restart, ChooseMore, ChooseLess, _clickToButtons);
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
        if(_gameModel.ClickButtons[0])
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButtons[0] = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(1);
            return;
        }

        LessOrMore(1);
    }

    private void ClickToButton2()
    {
        if (_gameModel.ClickButtons[1])
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButtons[1] = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(2);
            return;
        }

        LessOrMore(2);
    }

    private void ClickToButton3()
    {
        if (_gameModel.ClickButtons[2])
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButtons[2] = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(3);
            return;
        }

        LessOrMore(3);
    }

    private void ClickToButton4()
    {
        if (_gameModel.ClickButtons[3])
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButtons[3] = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(4);
            return;
        }

        LessOrMore(4);
    }

    private void ClickToButton5()
    {
        if (_gameModel.ClickButtons[4])
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButtons[4] = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(5);
            return;
        }

        LessOrMore(5);
    }

    private void ClickToButton6()
    {
        if (_gameModel.ClickButtons[5])
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButtons[5] = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(6);
            return;
        }

        LessOrMore(6);
    }

    private void ClickToButton7()
    {
        if (_gameModel.ClickButtons[6])
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButtons[6] = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(7);
            return;
        }

        LessOrMore(7);
    }

    private void ClickToButton8()
    {
        if (_gameModel.ClickButtons[7])
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButtons[7] = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(8);
            return;
        }

        LessOrMore(8);
    }

    private void ClickToButton9()
    {
        if (_gameModel.ClickButtons[8])
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButtons[8] = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(9);
            return;
        }

        LessOrMore(9);
    }

    private void ClickToButton10()
    {
        if (_gameModel.ClickButtons[9])
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButtons[9] = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(10);
            return;
        }

        LessOrMore(10);
    }

    private void ClickToButton11()
    {
        if (_gameModel.ClickButtons[10])
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButtons[10] = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(11);
            return;
        }

        LessOrMore(11);
    }

    private void ClickToButton12()
    {
        if (_gameModel.ClickButtons[11])
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButtons[11] = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(12);
            return;
        }

        LessOrMore(12);
    }

    private void ClickToButton13()
    {
        if (_gameModel.ClickButtons[12])
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButtons[12] = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(13);
            return;
        }

        LessOrMore(13);
    }

    private void ClickToButton14()
    {
        if (_gameModel.ClickButtons[13])
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButtons[13] = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(14);
            return;
        }

        LessOrMore(14);
    }

    private void ClickToButton15()
    {
        if (_gameModel.ClickButtons[14])
        {
            return;
        }

        if (!_gameModel.ChooseMore && !_gameModel.ChooseLess)
        {
            return;
        }

        _gameModel.ClickButtons[14] = true;

        if (_gameModel.ChooseMore && _gameModel.ChooseLess)
        {
            FirstClick(15);
            return;
        }

        LessOrMore(15);
    }
    #endregion

    private GameView LoadView(Transform uiRoot)
    {
        ResourcePath prefabLinks = null;

        if(_gameState.GameComplication == EnumGameComplication.easy)
        {
            prefabLinks = PrefabLinks.easyGameViewResource;
        }
        else if(_gameState.GameComplication == EnumGameComplication.medium)
        {
            prefabLinks = PrefabLinks.mediumGameViewResource;
        }
        else if(_gameState.GameComplication == EnumGameComplication.hard)
        {
            prefabLinks = PrefabLinks.hardGameViewResource;
        }

        var objectView = Object.Instantiate(ResourceLoader.LoadPrefab(prefabLinks), uiRoot, false);
        AddGameObject(objectView);
        return objectView.GetComponent<GameView>();
    }

    private void ClickToButtonsAction()
    {
        if(_gameState.GameComplication == EnumGameComplication.easy)
        {
            _clickToButtons = new UnityAction[] {
            ClickToButton1, ClickToButton2, ClickToButton3,
            ClickToButton4, ClickToButton5, ClickToButton6,
            ClickToButton7, ClickToButton8, ClickToButton9};
        }
        else if(_gameState.GameComplication == EnumGameComplication.medium)
        {
            _clickToButtons = new UnityAction[] {
            ClickToButton1, ClickToButton2, ClickToButton3,
            ClickToButton4, ClickToButton5, ClickToButton6,
            ClickToButton7, ClickToButton8, ClickToButton9,
            ClickToButton10, ClickToButton11, ClickToButton12};
        }
        else if(_gameState.GameComplication == EnumGameComplication.hard)
        {
            _clickToButtons = new UnityAction[] {
            ClickToButton1, ClickToButton2, ClickToButton3,
            ClickToButton4, ClickToButton5, ClickToButton6,
            ClickToButton7, ClickToButton8, ClickToButton9,
            ClickToButton10, ClickToButton11, ClickToButton12,
            ClickToButton13, ClickToButton14, ClickToButton15};
        }
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

        if(_gameModel.Numbers.Count == 0)
        {
            EndLevel();
        }
    }

    private int GenerateRandomNumber()
    {
        var index = Random.Range(0, _gameModel.Numbers.Count);
        var result = _gameModel.Numbers[index];
        _gameModel.Numbers.Remove(_gameModel.Numbers[index]);
        return result;
    }

    private void EndLevel()
    {
        if(_gameModel.Score == 36 && _gameState.GameComplication == EnumGameComplication.easy)
        {
            _gameState.GameComplication = EnumGameComplication.medium;
        }
        else if(_gameModel.Score == 66 && _gameState.GameComplication == EnumGameComplication.medium)
        {
            _gameState.GameComplication = EnumGameComplication.hard;
        }
        _gameState.PlayerScore += _gameModel.Score;
        _gameView.SetEndGame();
    }
}
