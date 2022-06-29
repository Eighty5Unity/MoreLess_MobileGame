using System;

public class SubscriptionProperty<T> : ISubscriptionProperty<T>
{
    private T _value;
    private Action<T> _onValueChange;

    public T Value {
        get => _value;
        set {
            _value = value;
            _onValueChange?.Invoke(_value);
        }
    }

    public void SubscribeOnChange(Action<T> action)
    {
        _onValueChange += action;
    }

    public void UnSubscribe(Action<T> action)
    {
        _onValueChange -= action;
    }
}
