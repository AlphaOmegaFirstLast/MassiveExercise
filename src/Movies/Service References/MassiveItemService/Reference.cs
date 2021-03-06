﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MassiveItemService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.massive.co/Assessment")]
    public partial class Item : object
    {
        
        private string GenreField;
        
        private string IdField;
        
        private System.Collections.Generic.List<MassiveItemService.Image> ImagesField;
        
        private string ItemTypeField;
        
        private string TitleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genre
        {
            get
            {
                return this.GenreField;
            }
            set
            {
                this.GenreField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<MassiveItemService.Image> Images
        {
            get
            {
                return this.ImagesField;
            }
            set
            {
                this.ImagesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemType
        {
            get
            {
                return this.ItemTypeField;
            }
            set
            {
                this.ItemTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Image", Namespace="http://schemas.massive.co/Assessment")]
    public partial class Image : object
    {
        
        private string ItemIdField;
        
        private string MimeTypeField;
        
        private string PathField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemId
        {
            get
            {
                return this.ItemIdField;
            }
            set
            {
                this.ItemIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MimeType
        {
            get
            {
                return this.MimeTypeField;
            }
            set
            {
                this.MimeTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NotFoundFaultException", Namespace="http://schemas.massive.co/Assessment/Faults")]
    public partial class NotFoundFaultException : object
    {
        
        private string ItemTypeField;
        
        private string PathField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemType
        {
            get
            {
                return this.ItemTypeField;
            }
            set
            {
                this.ItemTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.massive.co/assessment/api/v1", ConfigurationName="MassiveItemService.ItemService")]
    public interface ItemService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.massive.co/assessment/api/v1/ItemService/ListItems", ReplyAction="http://schemas.massive.co/assessment/api/v1/ItemService/ListItemsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MassiveItemService.Item>> ListItemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.massive.co/assessment/api/v1/ItemService/ListItemsByType", ReplyAction="http://schemas.massive.co/assessment/api/v1/ItemService/ListItemsByTypeResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MassiveItemService.Item>> ListItemsByTypeAsync(string itemType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.massive.co/assessment/api/v1/ItemService/UpdateCount", ReplyAction="http://schemas.massive.co/assessment/api/v1/ItemService/UpdateCountResponse")]
        System.Threading.Tasks.Task UpdateCountAsync(string itemType, long count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.massive.co/assessment/api/v1/ItemService/GetImage", ReplyAction="http://schemas.massive.co/assessment/api/v1/ItemService/GetImageResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MassiveItemService.NotFoundFaultException), Action="http://schemas.massive.co/assessment/api/v1/ItemService/GetImageNotFoundFaultExce" +
            "ptionFault", Name="NotFoundFaultException", Namespace="http://schemas.massive.co/Assessment/Faults")]
        System.Threading.Tasks.Task<byte[]> GetImageAsync(string itemId, string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.massive.co/assessment/api/v1/ItemService/DontCallMe", ReplyAction="http://schemas.massive.co/assessment/api/v1/ItemService/DontCallMeResponse")]
        System.Threading.Tasks.Task<string> DontCallMeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    public interface ItemServiceChannel : MassiveItemService.ItemService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.3.0.0")]
    public partial class ItemServiceClient : System.ServiceModel.ClientBase<MassiveItemService.ItemService>, MassiveItemService.ItemService
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ItemServiceClient() : 
                base(ItemServiceClient.GetDefaultBinding(), ItemServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.WSHttpBinding_ItemService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ItemServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ItemServiceClient.GetBindingForEndpoint(endpointConfiguration), ItemServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ItemServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ItemServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ItemServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ItemServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ItemServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MassiveItemService.Item>> ListItemsAsync()
        {
            return base.Channel.ListItemsAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MassiveItemService.Item>> ListItemsByTypeAsync(string itemType)
        {
            return base.Channel.ListItemsByTypeAsync(itemType);
        }
        
        public System.Threading.Tasks.Task UpdateCountAsync(string itemType, long count)
        {
            return base.Channel.UpdateCountAsync(itemType, count);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetImageAsync(string itemId, string fileName)
        {
            return base.Channel.GetImageAsync(itemId, fileName);
        }
        
        public System.Threading.Tasks.Task<string> DontCallMeAsync()
        {
            return base.Channel.DontCallMeAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WSHttpBinding_ItemService))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WSHttpBinding_ItemService))
            {
                return new System.ServiceModel.EndpointAddress("https://seaweb20160509081450.azurewebsites.net/Api/V1/ItemService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ItemServiceClient.GetBindingForEndpoint(EndpointConfiguration.WSHttpBinding_ItemService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ItemServiceClient.GetEndpointAddress(EndpointConfiguration.WSHttpBinding_ItemService);
        }
        
        public enum EndpointConfiguration
        {
            
            WSHttpBinding_ItemService,
        }
    }
}
