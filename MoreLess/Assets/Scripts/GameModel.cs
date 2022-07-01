using System.Collections.Generic;

public class GameModel
{
    private int _countOfNumbers = 9;
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

    private bool _clickButton1;
    private bool _clickButton2;
    private bool _clickButton3;
    private bool _clickButton4;
    private bool _clickButton5;
    private bool _clickButton6;
    private bool _clickButton7;
    private bool _clickButton8;
    private bool _clickButton9;
    public bool ClickButton1 { get => _clickButton1; set => _clickButton1 = value; }
    public bool ClickButton2 { get => _clickButton2; set => _clickButton2 = value; }
    public bool ClickButton3 { get => _clickButton3; set => _clickButton3 = value; }
    public bool ClickButton4 { get => _clickButton4; set => _clickButton4 = value; }
    public bool ClickButton5 { get => _clickButton5; set => _clickButton5 = value; }
    public bool ClickButton6 { get => _clickButton6; set => _clickButton6 = value; }
    public bool ClickButton7 { get => _clickButton7; set => _clickButton7 = value; }
    public bool ClickButton8 { get => _clickButton8; set => _clickButton8 = value; }
    public bool ClickButton9 { get => _clickButton9; set => _clickButton9 = value; }

    public GameModel()
    {
        _score = 0;
        _winCoef = 1;
        _loseCoef = -1;
        _chooseMore = true;
        _chooseLess = true;

        for (int i = 1; i <= _countOfNumbers; i++)
        {
            _numbers.Add(i);
        }
    }
}
