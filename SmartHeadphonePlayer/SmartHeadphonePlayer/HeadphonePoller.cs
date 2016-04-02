using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;

namespace SmartHeadphonePlayer
{
    class HeadphonePoller:IObservable<bool>
    {
        IList<IObserver<bool>> observers;

        public HeadphonePoller()
        {
            observers = new List<IObserver<bool>>();
        }

        string baseURL = "https://api.particle.io/v1/devices/";
        string deviceID = "330035000347343337373738";
        string eventsQuery = "/digitalread?access_token=";
        string accessToken = "235ad2c91cac25aa4950542f1f9e4c21e8dab041";

        public void Run()
        {
            for(;;)
            {
                var request = WebRequest.Create(this.getEventsURL());
                request.Method = "GET";
                using (var response = request.GetResponse())
                {
                    StreamReader stredr = new StreamReader(response.GetResponseStream());
                    string responseBody = stredr.ReadToEnd();
                    JObject json = JObject.Parse(responseBody);
                    int? returnValue = json["return_value"].CreateReader().ReadAsInt32();
                    if(returnValue == 0 || returnValue == 1)
                    {
                        foreach(IObserver<bool> observer in observers)
                        {
                            observer.OnNext(returnValue == 1);
                        }
                    }
                }
            }
        }

        private string getEventsURL()
        {
            return baseURL + deviceID + eventsQuery + accessToken;
        }

        public IDisposable Subscribe(IObserver<bool> observer)
        {
            observers.Add(observer);
            return null;
        }
    }
}
