public class RandomNumberGenerator : IRandomNumberGenerator
{
  private Random _random = new Random();
  public int Next() => _random.Next(1, 11);
  public event Action OnSomeEvent;

  public void OnSomeHandler(int num)
  {
    if (num % 2 != 0)
      OnSomeEvent?.Invoke();
  }
}
