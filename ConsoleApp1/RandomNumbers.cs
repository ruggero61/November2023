public class RandomNumbers
{
  private IRandomNumberGenerator _rng;
  private IMessage _message;
  private List<Action> _beep = new List<Action>();

  public RandomNumbers(IRandomNumberGenerator rng, IMessage msg, List<Action> beep)
  {
    _rng = rng;
    _message = msg;
    _beep = beep;
  }

  public void RndNumbers(int howManyNumbers)
  {
    _beep.ForEach(b => _rng.OnSomeEvent += b);
    int counter = 0;
    while (counter < howManyNumbers)
    {
      int n = _rng.Next();
      _message.SendMessage(n.ToString());
      _rng.OnSomeHandler(n);
      Thread.Sleep(1000);
      counter++;
    }
  }
}
