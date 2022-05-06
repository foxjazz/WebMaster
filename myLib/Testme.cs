using DogManager;
using System.Threading;
namespace myLib
{
    public class Testme
    {
        private IDogger _dog;
        public Testme(IDogger dogger) 
        {
            
            _dog = dogger;
        }
        public void doone(string data)
        {
            _dog.Info(data);
        }
        public static void mystatic(int refcnter)
        {
            Thread.Sleep(1000 * refcnter);
            Dogger.dog.Info($"log from my static ref: {refcnter}");
        }
    }
}