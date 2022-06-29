using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
    [SerializeField] private Button _backToMenuButton;

    public void Init(UnityAction backToMenu)
    {
        _backToMenuButton.onClick.AddListener(backToMenu);
    }

    protected void OnDestroy()
    {
        _backToMenuButton.onClick.RemoveAllListeners();
    }
}
