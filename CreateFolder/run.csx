using System.Net;
using System;
using System.Linq;


public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{   

    //Get request body
    double price = await req.Content.ReadAsAsync<double>();
    log.Info(string.Format("The item price received is '{0}'.",price.ToString()));    


    string pricecurrency;
    pricecurrency = String.Format( "{0:C}", price.ToString( ) );
    Console.WriteLine("{0:C}", price);  
    return req.CreateResponse(HttpStatusCode.OK, pricecurrency);
    
}
