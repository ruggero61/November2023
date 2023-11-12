public class Message : IMessage
{
  public void SendMessage(string message)
  {
    Console.WriteLine(message);
  }
}

public class MessageMock : IMessage
{
  public void SendMessage(string message)
  {
    Console.WriteLine("Mock: " + message);
  }
}
