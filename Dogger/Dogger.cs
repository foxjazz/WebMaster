using System.ComponentModel;
using System.Diagnostics;
using Serilog;
using System.Diagnostics.Tracing;
namespace DogManager
{
    public class Dogger : IDogger, IDisposable
    {
        private ILogger Log;
        public static Dogger dog;
        public Dogger()
        {
            if (Dogger.dog == null)
            {
                Log = new Serilog.LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.File(@"x:\logs\log2.log")
                .CreateLogger();
            
                dog = this;
            }

        }

        private string getReleventInfo()
        {
            StackTrace st = new StackTrace(true);
            int cntr = 0;
            var filename = st.GetFrame(0).GetFileName();
            foreach (var stack in st.GetFrames())
            {
                
                var nfn = stack.GetFileName();
                if (nfn != filename)
                {
                    break;
                    
                }

                cntr++;
            }
            
            var sf = st.GetFrame(cntr);
            var fn = sf.GetFileName();
            return fn + " : " + sf.GetFileLineNumber() + " : ";
        }
        public void Info(string message)
        {
            string mout = getReleventInfo() + message;            
            Log.Information(mout);
            
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