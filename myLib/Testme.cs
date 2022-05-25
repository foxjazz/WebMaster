using DogManager;
using System.Threading;
using Microsoft.Extensions.Configuration;

namespace myLib
{
    public class Testme
    {
        private IDogger _dog;
        private IConfiguration _conf;
        public Testme(IDogger dogger, IConfiguration conf)
        {
            _conf = conf;
            _dog = dogger;
        }
        public Testme(IDogger dogger){
            _dog = dogger;
            
        }
        public void DoStackLogTest(string test)
        {
            Dogger.dog.Info("test is : " + test);
            
        }
        public void doone(string data)
        {
            _dog.Info(data);
            var section =  _conf.GetSection("AppSettings");
            var data0 = section["appSettingsData1"];
            Dogger.dog.Info(data0);
        }
        public void mystatic(int refcnter)
        {
            Thread.Sleep(1000 * refcnter);
            Dogger.dog.Info($"log from my static ref: {refcnter}");
            // var cm = new ConfigurationManager();
            
        }
    }
}