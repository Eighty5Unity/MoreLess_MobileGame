using System;

public interface ISubscriptionProperty<T>
{
    T Value { get; }
    void SubscribeOnChange(Action<T> action);
    void UnSubscribe(Action<T> action);
}
