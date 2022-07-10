using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
    [SerializeField] private Button _backToMenuButton;
    [SerializeField] private Button _restartButton;
    [SerializeField] private Text _score;
    [SerializeField] private Button _moreButton;
    [SerializeField] private Button _lessButton;
    [SerializeField] private GameObject _endGame;
    [Header("Buttons 1-9")]
    [SerializeField] private Button[] _buttons;
    [Header("Sprites")]
    private List<Button> _buttonSprites = new List<Button>(9);
    [SerializeField] private Sprite[] _numberSprites;

    public void Init(
        UnityAction backToMenu, UnityAction restart,
        UnityAction more, UnityAction less,
        UnityAction[] clickToButtons)
    {
        _backToMenuButton.onClick.AddListener(backToMenu);
        _restartButton.onClick.AddListener(restart);
        _moreButton.onClick.AddListener(more);
        _lessButton.onClick.AddListener(less);

        var indexOfButtons = 0;
        foreach(var button in _buttons)
        {
            button.onClick.AddListener(clickToButtons[indexOfButtons]);
            _buttonSprites.Add(button);
            indexOfButtons++;
        }

        _endGame.SetActive(false);
    }

    public void SetScore(int value)
    {
        _score.text = $"{value}";
    }

    public void SetSprite(int buttonNumber, int value)
    {
        _buttonSprites[buttonNumber - 1].image.sprite = _numberSprites[value - 1];
    }

    public void SetEndGame()
    {
        _endGame.SetActive(true);
    }

    protected void OnDestroy()
    {
        _backToMenuButton.onClick.RemoveAllListeners();
        _restartButton.onClick.RemoveAllListeners();
        _moreButton.onClick.RemoveAllListeners();
        _lessButton.onClick.RemoveAllListeners();

        foreach(var button in _buttons)
        {
            button.onClick.RemoveAllListeners();
        }
    }
}
