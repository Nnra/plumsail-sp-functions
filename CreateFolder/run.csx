using System.Net;
using System;
using System.Linq;


public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{   

    //Get request body
    double price = await req.Content.ReadAsAsync<double>();
    log.Info(string.Format("The item price received is '{0}'.",price.ToString()));    

    string pricecurrency;
    pricecurrency = String.Format( "{0} => {1}", C, price.ToString( C ) );
    Console.WriteLine( "Numeric String Format: " );
    Console.WriteLine( String.Format( "{0} => {1}", C, price.ToString( C ) ) );   
    return req.CreateResponse(HttpStatusCode.OK, pricecurrency);
    
}
