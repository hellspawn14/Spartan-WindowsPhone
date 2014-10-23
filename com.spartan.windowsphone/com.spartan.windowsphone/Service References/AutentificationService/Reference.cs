﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace com.spartan.windowsphone.AutentificationService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://authentification.services.server.spartan.com/", ConfigurationName="AutentificationService.AuthentificationService")]
    public interface AuthentificationService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://authentification.services.server.spartan.com/AuthentificationService/chang" +
            "ePassRequest", ReplyAction="http://authentification.services.server.spartan.com/AuthentificationService/chang" +
            "ePassResponse")]
        [System.ServiceModel.DataContractFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc)]
        System.IAsyncResult BeginchangePass(string arg0, string arg1, string arg2, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string EndchangePass(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://authentification.services.server.spartan.com/AuthentificationService/logIn" +
            "Request", ReplyAction="http://authentification.services.server.spartan.com/AuthentificationService/logIn" +
            "Response")]
        [System.ServiceModel.DataContractFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc)]
        System.IAsyncResult BeginlogIn(string arg0, string arg1, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        int EndlogIn(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://authentification.services.server.spartan.com/AuthentificationService/chang" +
            "ePasswordRequest", ReplyAction="http://authentification.services.server.spartan.com/AuthentificationService/chang" +
            "ePasswordResponse")]
        [System.ServiceModel.DataContractFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc)]
        System.IAsyncResult BeginchangePassword(string arg0, string arg1, string arg2, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string EndchangePassword(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AuthentificationServiceChannel : com.spartan.windowsphone.AutentificationService.AuthentificationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class changePassCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public changePassCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class logInCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public logInCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class changePasswordCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public changePasswordCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthentificationServiceClient : System.ServiceModel.ClientBase<com.spartan.windowsphone.AutentificationService.AuthentificationService>, com.spartan.windowsphone.AutentificationService.AuthentificationService {
        
        private BeginOperationDelegate onBeginchangePassDelegate;
        
        private EndOperationDelegate onEndchangePassDelegate;
        
        private System.Threading.SendOrPostCallback onchangePassCompletedDelegate;
        
        private BeginOperationDelegate onBeginlogInDelegate;
        
        private EndOperationDelegate onEndlogInDelegate;
        
        private System.Threading.SendOrPostCallback onlogInCompletedDelegate;
        
        private BeginOperationDelegate onBeginchangePasswordDelegate;
        
        private EndOperationDelegate onEndchangePasswordDelegate;
        
        private System.Threading.SendOrPostCallback onchangePasswordCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public AuthentificationServiceClient() {
        }
        
        public AuthentificationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthentificationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthentificationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthentificationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<changePassCompletedEventArgs> changePassCompleted;
        
        public event System.EventHandler<logInCompletedEventArgs> logInCompleted;
        
        public event System.EventHandler<changePasswordCompletedEventArgs> changePasswordCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult com.spartan.windowsphone.AutentificationService.AuthentificationService.BeginchangePass(string arg0, string arg1, string arg2, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginchangePass(arg0, arg1, arg2, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string com.spartan.windowsphone.AutentificationService.AuthentificationService.EndchangePass(System.IAsyncResult result) {
            return base.Channel.EndchangePass(result);
        }
        
        private System.IAsyncResult OnBeginchangePass(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string arg0 = ((string)(inValues[0]));
            string arg1 = ((string)(inValues[1]));
            string arg2 = ((string)(inValues[2]));
            return ((com.spartan.windowsphone.AutentificationService.AuthentificationService)(this)).BeginchangePass(arg0, arg1, arg2, callback, asyncState);
        }
        
        private object[] OnEndchangePass(System.IAsyncResult result) {
            string retVal = ((com.spartan.windowsphone.AutentificationService.AuthentificationService)(this)).EndchangePass(result);
            return new object[] {
                    retVal};
        }
        
        private void OnchangePassCompleted(object state) {
            if ((this.changePassCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.changePassCompleted(this, new changePassCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void changePassAsync(string arg0, string arg1, string arg2) {
            this.changePassAsync(arg0, arg1, arg2, null);
        }
        
        public void changePassAsync(string arg0, string arg1, string arg2, object userState) {
            if ((this.onBeginchangePassDelegate == null)) {
                this.onBeginchangePassDelegate = new BeginOperationDelegate(this.OnBeginchangePass);
            }
            if ((this.onEndchangePassDelegate == null)) {
                this.onEndchangePassDelegate = new EndOperationDelegate(this.OnEndchangePass);
            }
            if ((this.onchangePassCompletedDelegate == null)) {
                this.onchangePassCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnchangePassCompleted);
            }
            base.InvokeAsync(this.onBeginchangePassDelegate, new object[] {
                        arg0,
                        arg1,
                        arg2}, this.onEndchangePassDelegate, this.onchangePassCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult com.spartan.windowsphone.AutentificationService.AuthentificationService.BeginlogIn(string arg0, string arg1, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginlogIn(arg0, arg1, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        int com.spartan.windowsphone.AutentificationService.AuthentificationService.EndlogIn(System.IAsyncResult result) {
            return base.Channel.EndlogIn(result);
        }
        
        private System.IAsyncResult OnBeginlogIn(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string arg0 = ((string)(inValues[0]));
            string arg1 = ((string)(inValues[1]));
            return ((com.spartan.windowsphone.AutentificationService.AuthentificationService)(this)).BeginlogIn(arg0, arg1, callback, asyncState);
        }
        
        private object[] OnEndlogIn(System.IAsyncResult result) {
            int retVal = ((com.spartan.windowsphone.AutentificationService.AuthentificationService)(this)).EndlogIn(result);
            return new object[] {
                    retVal};
        }
        
        private void OnlogInCompleted(object state) {
            if ((this.logInCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.logInCompleted(this, new logInCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void logInAsync(string arg0, string arg1) {
            this.logInAsync(arg0, arg1, null);
        }
        
        public void logInAsync(string arg0, string arg1, object userState) {
            if ((this.onBeginlogInDelegate == null)) {
                this.onBeginlogInDelegate = new BeginOperationDelegate(this.OnBeginlogIn);
            }
            if ((this.onEndlogInDelegate == null)) {
                this.onEndlogInDelegate = new EndOperationDelegate(this.OnEndlogIn);
            }
            if ((this.onlogInCompletedDelegate == null)) {
                this.onlogInCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnlogInCompleted);
            }
            base.InvokeAsync(this.onBeginlogInDelegate, new object[] {
                        arg0,
                        arg1}, this.onEndlogInDelegate, this.onlogInCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult com.spartan.windowsphone.AutentificationService.AuthentificationService.BeginchangePassword(string arg0, string arg1, string arg2, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginchangePassword(arg0, arg1, arg2, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string com.spartan.windowsphone.AutentificationService.AuthentificationService.EndchangePassword(System.IAsyncResult result) {
            return base.Channel.EndchangePassword(result);
        }
        
        private System.IAsyncResult OnBeginchangePassword(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string arg0 = ((string)(inValues[0]));
            string arg1 = ((string)(inValues[1]));
            string arg2 = ((string)(inValues[2]));
            return ((com.spartan.windowsphone.AutentificationService.AuthentificationService)(this)).BeginchangePassword(arg0, arg1, arg2, callback, asyncState);
        }
        
        private object[] OnEndchangePassword(System.IAsyncResult result) {
            string retVal = ((com.spartan.windowsphone.AutentificationService.AuthentificationService)(this)).EndchangePassword(result);
            return new object[] {
                    retVal};
        }
        
        private void OnchangePasswordCompleted(object state) {
            if ((this.changePasswordCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.changePasswordCompleted(this, new changePasswordCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void changePasswordAsync(string arg0, string arg1, string arg2) {
            this.changePasswordAsync(arg0, arg1, arg2, null);
        }
        
        public void changePasswordAsync(string arg0, string arg1, string arg2, object userState) {
            if ((this.onBeginchangePasswordDelegate == null)) {
                this.onBeginchangePasswordDelegate = new BeginOperationDelegate(this.OnBeginchangePassword);
            }
            if ((this.onEndchangePasswordDelegate == null)) {
                this.onEndchangePasswordDelegate = new EndOperationDelegate(this.OnEndchangePassword);
            }
            if ((this.onchangePasswordCompletedDelegate == null)) {
                this.onchangePasswordCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnchangePasswordCompleted);
            }
            base.InvokeAsync(this.onBeginchangePasswordDelegate, new object[] {
                        arg0,
                        arg1,
                        arg2}, this.onEndchangePasswordDelegate, this.onchangePasswordCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override com.spartan.windowsphone.AutentificationService.AuthentificationService CreateChannel() {
            return new AuthentificationServiceClientChannel(this);
        }
        
        private class AuthentificationServiceClientChannel : ChannelBase<com.spartan.windowsphone.AutentificationService.AuthentificationService>, com.spartan.windowsphone.AutentificationService.AuthentificationService {
            
            public AuthentificationServiceClientChannel(System.ServiceModel.ClientBase<com.spartan.windowsphone.AutentificationService.AuthentificationService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginchangePass(string arg0, string arg1, string arg2, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[3];
                _args[0] = arg0;
                _args[1] = arg1;
                _args[2] = arg2;
                System.IAsyncResult _result = base.BeginInvoke("changePass", _args, callback, asyncState);
                return _result;
            }
            
            public string EndchangePass(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("changePass", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginlogIn(string arg0, string arg1, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = arg0;
                _args[1] = arg1;
                System.IAsyncResult _result = base.BeginInvoke("logIn", _args, callback, asyncState);
                return _result;
            }
            
            public int EndlogIn(System.IAsyncResult result) {
                object[] _args = new object[0];
                int _result = ((int)(base.EndInvoke("logIn", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginchangePassword(string arg0, string arg1, string arg2, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[3];
                _args[0] = arg0;
                _args[1] = arg1;
                _args[2] = arg2;
                System.IAsyncResult _result = base.BeginInvoke("changePassword", _args, callback, asyncState);
                return _result;
            }
            
            public string EndchangePassword(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("changePassword", _args, result)));
                return _result;
            }
        }
    }
}
