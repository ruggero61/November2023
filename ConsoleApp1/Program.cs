using System.Security.Cryptography;

namespace ConsoleApp1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      RandomNumbers randomNumbers; 
      randomNumbers = new RandomNumbers(
        new RandomNumberGenerator(), 
        new Message(), 
        new List<Action> { Beep.SoundBeep, BeepSound.SoundBeep });
      randomNumbers.RndNumbers(5);
      randomNumbers = new RandomNumbers(
        new RandomNumberGeneratorClassic(), 
        new MessageMock(), 
        new List<Action> { Beep.SoundBeep, BeepSound.SoundBeep });
      randomNumbers.RndNumbers(7);
    }
  }
}



