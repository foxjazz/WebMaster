using Serilog;
namespace DogManager
{
    public class Dogger : IDogger, IDisposable
    {
        private ILogger Log;
        public static Dogger dog;
        public Dogger()
        {
            Log = new Serilog.LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.File(@"x:\logs\log.log")
                .CreateLogger();
            dog = this;

        }
        public void Info(string message)
        {
            Log.Error(message);
            
        }
        public void Error(string message)
        {
            Log.Error(message);
        }
        public void Warning(string message)
        {
            Log.Warning(message);
        }
        public void Dispose()
        {
            
        }
    }
}