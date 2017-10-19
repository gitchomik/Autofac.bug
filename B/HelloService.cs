[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://www.examples.com/wsdl/HelloService.wsdl", ConfigurationName="Hello_PortType")]
public interface Hello_PortType
{
    [System.ServiceModel.OperationContractAttribute(Action="sayHello", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, Use=System.ServiceModel.OperationFormatUse.Encoded)]
    sayHelloResponse sayHello(sayHelloRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="sayHello", ReplyAction="*")]
    System.Threading.Tasks.Task<sayHelloResponse> sayHelloAsync(sayHelloRequest request);
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="sayHello", WrapperNamespace="urn:examples:helloservice", IsWrapped=true)]
public partial class sayHelloRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
    public string firstName;
    
    public sayHelloRequest()
    {
    }
    
    public sayHelloRequest(string firstName)
    {
        this.firstName = firstName;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="sayHelloResponse", WrapperNamespace="urn:examples:helloservice", IsWrapped=true)]
public partial class sayHelloResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
    public string greeting;
    
    public sayHelloResponse()
    {
    }
    
    public sayHelloResponse(string greeting)
    {
        this.greeting = greeting;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface Hello_PortTypeChannel : Hello_PortType, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class Hello_PortTypeClient : System.ServiceModel.ClientBase<Hello_PortType>, Hello_PortType
{
    
    public Hello_PortTypeClient()
    {
    }
    
    public Hello_PortTypeClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public Hello_PortTypeClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public Hello_PortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public Hello_PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    sayHelloResponse Hello_PortType.sayHello(sayHelloRequest request)
    {
        return base.Channel.sayHello(request);
    }
    
    public string sayHello(string firstName)
    {
        sayHelloRequest inValue = new sayHelloRequest();
        inValue.firstName = firstName;
        sayHelloResponse retVal = ((Hello_PortType)(this)).sayHello(inValue);
        return retVal.greeting;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<sayHelloResponse> Hello_PortType.sayHelloAsync(sayHelloRequest request)
    {
        return base.Channel.sayHelloAsync(request);
    }
    
    public System.Threading.Tasks.Task<sayHelloResponse> sayHelloAsync(string firstName)
    {
        sayHelloRequest inValue = new sayHelloRequest();
        inValue.firstName = firstName;
        return ((Hello_PortType)(this)).sayHelloAsync(inValue);
    }
}
