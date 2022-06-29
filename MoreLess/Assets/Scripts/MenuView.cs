using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuView : MonoBehaviour
{
    [SerializeField] private Button _startButton;

    public void Init(UnityAction startGame)
    {
        _startButton.onClick.AddListener(startGame);
    }

    protected void OnDestroy()
    {
        _startButton.onClick.RemoveAllListeners();
    }
}
