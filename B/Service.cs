using System;
using System.ServiceModel;
using Autofac;

public class Service
{
    public void Request()
    {
        var binding = new BasicHttpBinding();
        var endpoint = new EndpointAddress(new Uri("http://127.0.0.1:7897/prepaidreg?wsdl"));
        var channelFactory = new ChannelFactory<Hello_PortType>(binding, endpoint);
        var serviceClient = channelFactory.CreateChannel();
        serviceClient.sayHello(new sayHelloRequest("hello"));
        channelFactory.Close();                
    }     
}
