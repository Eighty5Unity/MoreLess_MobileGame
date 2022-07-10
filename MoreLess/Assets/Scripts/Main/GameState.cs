public class GameState
{
    public SubscriptionProperty<EnumGameState> CurrentGameState { get; }
    public EnumGameComplication GameComplication;
    public int PlayerScore;

    public GameState()
    {
        CurrentGameState = new SubscriptionProperty<EnumGameState>();
        GameComplication = EnumGameComplication.easy;
    }
}
