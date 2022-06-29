public class GameState
{
    public SubscriptionProperty<EnumGameState> CurrentGameState { get; }

    public GameState()
    {
        CurrentGameState = new SubscriptionProperty<EnumGameState>();
    }
}
