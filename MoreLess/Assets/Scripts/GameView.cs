using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
    [SerializeField] private Button _backToMenuButton;
    [SerializeField] private Button _storeButton;
    [SerializeField] private Text _score;
    [SerializeField] private Button _moreButton;
    [SerializeField] private Button _lessButton;
    [Header("Buttons 1-9")]
    [SerializeField] private Button _button1;
    [SerializeField] private Button _button2;
    [SerializeField] private Button _button3;
    [SerializeField] private Button _button4;
    [SerializeField] private Button _button5;
    [SerializeField] private Button _button6;
    [SerializeField] private Button _button7;
    [SerializeField] private Button _button8;
    [SerializeField] private Button _button9;
    [Header("Sprites")]
    private List<Button> _buttonSprites = new List<Button>(9);
    [SerializeField] private Sprite[] _numberSprites;

    public void Init(
        UnityAction backToMenu, UnityAction store,
        UnityAction more, UnityAction less,
        UnityAction button1, UnityAction button2,
        UnityAction button3, UnityAction button4,
        UnityAction button5, UnityAction button6,
        UnityAction button7, UnityAction button8,
        UnityAction button9)
    {
        _backToMenuButton.onClick.AddListener(backToMenu);
        _storeButton.onClick.AddListener(store);
        _moreButton.onClick.AddListener(more);
        _lessButton.onClick.AddListener(less);

        _button1.onClick.AddListener(button1);
        _button2.onClick.AddListener(button2);
        _button3.onClick.AddListener(button3);
        _button4.onClick.AddListener(button4);
        _button5.onClick.AddListener(button5);
        _button6.onClick.AddListener(button6);
        _button7.onClick.AddListener(button7);
        _button8.onClick.AddListener(button8);
        _button9.onClick.AddListener(button9);
        _buttonSprites.Add(_button1);
        _buttonSprites.Add(_button2);
        _buttonSprites.Add(_button3);
        _buttonSprites.Add(_button4);
        _buttonSprites.Add(_button5);
        _buttonSprites.Add(_button6);
        _buttonSprites.Add(_button7);
        _buttonSprites.Add(_button8);
        _buttonSprites.Add(_button9);
    }

    public void SetScore(int value)
    {
        _score.text = $"{value}";
    }

    public void SetSprite(int buttonNumber, int value)
    {
        _buttonSprites[buttonNumber - 1].image.sprite = _numberSprites[value - 1];
    }

    protected void OnDestroy()
    {
        _backToMenuButton.onClick.RemoveAllListeners();
        _storeButton.onClick.RemoveAllListeners();
        _moreButton.onClick.RemoveAllListeners();
        _lessButton.onClick.RemoveAllListeners();

        _button1.onClick.RemoveAllListeners();
        _button2.onClick.RemoveAllListeners();
        _button3.onClick.RemoveAllListeners();
        _button4.onClick.RemoveAllListeners();
        _button5.onClick.RemoveAllListeners();
        _button6.onClick.RemoveAllListeners();
        _button7.onClick.RemoveAllListeners();
        _button8.onClick.RemoveAllListeners();
        _button9.onClick.RemoveAllListeners();
    }
}
