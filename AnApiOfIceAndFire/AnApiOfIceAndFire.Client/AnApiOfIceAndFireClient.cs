using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AnApiOfIceAndFire.Client
{
    public class AnApiOfIceAndFireClient
    {
        private readonly HttpClient client;

        public AnApiOfIceAndFireClient() 
        {
            this.client = HttpClientFactory.Create();
            this.client.BaseAddress = new Uri("https://anapioficeandfire.com/api/");
            this.client.Timeout = new TimeSpan(0, 0, 30);
            this.client.DefaultRequestHeaders.Clear();
        }
    }
}
