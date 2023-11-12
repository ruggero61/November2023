public interface IRandomNumberGenerator
{
  public int Next();
  public event Action OnSomeEvent;
  public void OnSomeHandler(int num);
}
