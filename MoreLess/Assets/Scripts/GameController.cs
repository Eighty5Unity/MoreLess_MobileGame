using System.Collections.Generic;
using UnityEngine;

public class GameController : BaseController
{
    private readonly GameState _gameState;
    private readonly ResourcePath _gameViewResource = new ResourcePath() { PathResource = "Prefabs/Game" };
    private readonly GameView _gameView;
    private bool _chooseMore = true;
    private bool _chooseLess = true;
    private List<int> _numbers = new List<int>(9);
    private int _score = 0;
    private int _lastNumber;
    private int _winCoef = 1;
    private int _loseCoef = -1;

    private bool _clickButton1;
    private bool _clickButton2;
    private bool _clickButton3;
    private bool _clickButton4;
    private bool _clickButton5;
    private bool _clickButton6;
    private bool _clickButton7;
    private bool _clickButton8;
    private bool _clickButton9;

    public GameController(GameState state, Transform uiRoot)
    {
        _gameState = state;
        _gameView = LoadView(uiRoot);
        _gameView.Init(BackToMenu, OpenStore, ChooseMore, ChooseLess,
            ClickToButton1, ClickToButton2, ClickToButton3,
            ClickToButton4, ClickToButton5, ClickToButton6,
            ClickToButton7, ClickToButton8, ClickToButton9);
        _gameView.SetScore(_score);
        _numbers.Add(1);
        _numbers.Add(2);
        _numbers.Add(3);
        _numbers.Add(4);
        _numbers.Add(5);
        _numbers.Add(6);
        _numbers.Add(7);
        _numbers.Add(8);
        _numbers.Add(9);
    }

    private void BackToMenu()
    {
        _gameState.CurrentGameState.Value = EnumGameState.Menu;
    }

    private void OpenStore()
    {
        Debug.Log("Click to store");
    }

    private void ChooseMore()
    {
        if(_chooseLess && _chooseMore)
        {
            return;
        }
        _chooseMore = true;
        _chooseLess = false;
    }

    private void ChooseLess()
    {
        if (_chooseLess && _chooseMore)
        {
            return;
        }
        _chooseLess = true;
        _chooseMore = false;
    }

    #region Buttons
    private void ClickToButton1()
    {
        if(_clickButton1)
        {
            return;
        }

        if (!_chooseMore && !_chooseLess)
        {
            return;
        }

        _clickButton1 = true;

        if (_chooseMore && _chooseLess)
        {
            FirstClick(1);
            return;
        }

        LessOrMore(1);
    }

    private void ClickToButton2()
    {
        if (_clickButton2)
        {
            return;
        }

        if (!_chooseMore && !_chooseLess)
        {
            return;
        }

        _clickButton2 = true;

        if (_chooseMore && _chooseLess)
        {
            FirstClick(2);
            return;
        }

        LessOrMore(2);
    }

    private void ClickToButton3()
    {
        if (_clickButton3)
        {
            return;
        }

        if (!_chooseMore && !_chooseLess)
        {
            return;
        }

        _clickButton3 = true;

        if (_chooseMore && _chooseLess)
        {
            FirstClick(3);
            return;
        }

        LessOrMore(3);
    }

    private void ClickToButton4()
    {
        if (_clickButton4)
        {
            return;
        }

        if (!_chooseMore && !_chooseLess)
        {
            return;
        }

        _clickButton4 = true;

        if (_chooseMore && _chooseLess)
        {
            FirstClick(4);
            return;
        }

        LessOrMore(4);
    }

    private void ClickToButton5()
    {
        if (_clickButton5)
        {
            return;
        }

        if (!_chooseMore && !_chooseLess)
        {
            return;
        }

        _clickButton5 = true;

        if (_chooseMore && _chooseLess)
        {
            FirstClick(5);
            return;
        }

        LessOrMore(5);
    }

    private void ClickToButton6()
    {
        if (_clickButton6)
        {
            return;
        }

        if (!_chooseMore && !_chooseLess)
        {
            return;
        }

        _clickButton6 = true;

        if (_chooseMore && _chooseLess)
        {
            FirstClick(6);
            return;
        }

        LessOrMore(6);
    }

    private void ClickToButton7()
    {
        if (_clickButton7)
        {
            return;
        }

        if (!_chooseMore && !_chooseLess)
        {
            return;
        }

        _clickButton7 = true;

        if (_chooseMore && _chooseLess)
        {
            FirstClick(7);
            return;
        }

        LessOrMore(7);
    }

    private void ClickToButton8()
    {
        if (_clickButton8)
        {
            return;
        }

        if (!_chooseMore && !_chooseLess)
        {
            return;
        }

        _clickButton8 = true;

        if (_chooseMore && _chooseLess)
        {
            FirstClick(8);
            return;
        }

        LessOrMore(8);
    }

    private void ClickToButton9()
    {
        if (_clickButton9)
        {
            return;
        }

        if (!_chooseMore && !_chooseLess)
        {
            return;
        }

        _clickButton9 = true;

        if (_chooseMore && _chooseLess)
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
        _lastNumber = number;
        _chooseLess = false;
        _chooseMore = false;
        _gameView.SetSprite(buttonNumber, number);
    }

    private void LessOrMore(int buttonNumber)
    {
        var number = GenerateRandomNumber();
        if (_chooseMore)
        {
            if(_lastNumber < number)
            {
                _score += _winCoef;
                _winCoef++;
                _loseCoef = -1;
            }
            else
            {
                _score += _loseCoef;
                _loseCoef--;
                _winCoef = 1;
            }
            _chooseMore = false;
        }
        else if (_chooseLess)
        {
            if(_lastNumber > number)
            {
                _score += _winCoef;
                _winCoef++;
                _loseCoef = -1;
            }
            else
            {
                _score += _loseCoef;
                _loseCoef--;
                _winCoef = 1;
            }
            _chooseLess = false;
        }
        _lastNumber = number;
        _gameView.SetSprite(buttonNumber, number);
        _gameView.SetScore(_score);
    }

    private int GenerateRandomNumber()
    {
        var index = Random.Range(0, _numbers.Count);
        var result = _numbers[index];
        _numbers.Remove(_numbers[index]);
        return result;
    }
}
