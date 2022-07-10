using System.Collections.Generic;

public class GameModel
{
    private int _countOfNumbers;
    private List<int> _numbers = new List<int>(9);
    public List<int> Numbers { get => _numbers; set => _numbers = value; }

    private int _score;
    private int _lastNumber;
    private int _winCoef;
    private int _loseCoef;
    public int Score { get => _score; set => _score = value; }
    public int LastNumber { get => _lastNumber; set => _lastNumber = value; }
    public int WinCoef { get => _winCoef; set => _winCoef = value; }
    public int LoseCoef { get => _loseCoef; set => _loseCoef = value; }

    private bool _chooseMore;
    private bool _chooseLess;
    public bool ChooseMore { get => _chooseMore; set => _chooseMore = value; }
    public bool ChooseLess { get => _chooseLess; set => _chooseLess = value; }

    private List<bool> _clickButtons = new List<bool>();
    private bool[] _clickButtonsArray;
    public bool[] ClickButtons { get => _clickButtonsArray; set => _clickButtonsArray = value; }

    public GameModel(GameState gameState)
    {
        _score = 0;
        _winCoef = 1;
        _loseCoef = -1;
        _chooseMore = true;
        _chooseLess = true;

        if(gameState.GameComplication == EnumGameComplication.easy)
        {
            _countOfNumbers = 9;
        }
        else if(gameState.GameComplication == EnumGameComplication.medium)
        {
            _countOfNumbers = 12;
        }
        else if(gameState.GameComplication == EnumGameComplication.hard)
        {
            _countOfNumbers = 15;
        }

        for (int i = 1; i <= _countOfNumbers; i++)
        {
            _numbers.Add(i);
            _clickButtons.Add(false);
        }
        _clickButtonsArray = _clickButtons.ToArray();
    }
}
