public class  RandomNumberGeneratorClassic : IRandomNumberGenerator
{
  private Random _random = new Random();

  public event Action OnSomeEvent;

  public int Next() => _random.Next(1, 100);

  public void OnSomeHandler(int num)
  {
    if (num % 3 != 0)
      OnSomeEvent?.Invoke();
  }
}
