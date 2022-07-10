using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuView : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _infoButton;
    [SerializeField] private Button _recordButton;
    [SerializeField] private Button _storeButton;
    [SerializeField] private Button _twitterButton;
    [SerializeField] private Button _facebookButton;
    [SerializeField] private GameObject _recordPanel;
    [SerializeField] private Button _backToMenuFromRecordPanel;
    [SerializeField] private Text _recordScore;

    public void Init(
        UnityAction startGame, UnityAction info, UnityAction record,
        UnityAction store, UnityAction twitter, UnityAction facebook)
    {
        _startButton.onClick.AddListener(startGame);
        _infoButton.onClick.AddListener(info);
        _recordButton.onClick.AddListener(record);
        _storeButton.onClick.AddListener(store);
        _twitterButton.onClick.AddListener(twitter);
        _facebookButton.onClick.AddListener(facebook);

        _backToMenuFromRecordPanel.onClick.AddListener(BackToMenuFromRecordPanel);
        _recordPanel.SetActive(false);
    }

    protected void OnDestroy()
    {
        _startButton.onClick.RemoveAllListeners();
        _infoButton.onClick.RemoveAllListeners();
        _recordButton.onClick.RemoveAllListeners();
        _storeButton.onClick.RemoveAllListeners();
        _twitterButton.onClick.RemoveAllListeners();
        _facebookButton.onClick.RemoveAllListeners();
    }

    public void ShowRecordPanel()
    {
        _recordPanel.SetActive(true);
    }

    public void SetRecordScore(int score)
    {
        _recordScore.text = $"{score}";
    }

    private void BackToMenuFromRecordPanel()
    {
        _recordPanel.SetActive(false);
    }
}
