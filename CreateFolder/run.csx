using System.Net;
using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{   

    //Get request body
    dynamic price = await req.Content.ReadAsAsync<object>();
    log.Info(string.Format("The item price received is '{0}'.",price.ToString()));    


    string pricecurrency;
    pricecurrency = String.Format( "{0:C}", price.ToString() );
    
    //Console.WriteLine("{0:C}", price);  
    //pricecurrency = String.Format( "{0:C}", 60000 );
    return req.CreateResponse(HttpStatusCode.OK, pricecurrency);

}
