﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34003
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Ce code source a été automatiquement généré par Microsoft.VSDesigner, Version 4.0.30319.34003.
// 
#pragma warning disable 1591

namespace Voyage.WebServiceVol {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Service1Soap", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getVolsOperationCompleted;
        
        private System.Threading.SendOrPostCallback getVilleDepartOperationCompleted;
        
        private System.Threading.SendOrPostCallback getVilleArriveeOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::Voyage.Properties.Settings.Default.Voyage_WebServiceVol_Service1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getVolsCompletedEventHandler getVolsCompleted;
        
        /// <remarks/>
        public event getVilleDepartCompletedEventHandler getVilleDepartCompleted;
        
        /// <remarks/>
        public event getVilleArriveeCompletedEventHandler getVilleArriveeCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getVols", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getVols(string VilleD, string VilleA, System.DateTime Date) {
            object[] results = this.Invoke("getVols", new object[] {
                        VilleD,
                        VilleA,
                        Date});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void getVolsAsync(string VilleD, string VilleA, System.DateTime Date) {
            this.getVolsAsync(VilleD, VilleA, Date, null);
        }
        
        /// <remarks/>
        public void getVolsAsync(string VilleD, string VilleA, System.DateTime Date, object userState) {
            if ((this.getVolsOperationCompleted == null)) {
                this.getVolsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetVolsOperationCompleted);
            }
            this.InvokeAsync("getVols", new object[] {
                        VilleD,
                        VilleA,
                        Date}, this.getVolsOperationCompleted, userState);
        }
        
        private void OngetVolsOperationCompleted(object arg) {
            if ((this.getVolsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getVolsCompleted(this, new getVolsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getVilleDepart", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] getVilleDepart() {
            object[] results = this.Invoke("getVilleDepart", new object[0]);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void getVilleDepartAsync() {
            this.getVilleDepartAsync(null);
        }
        
        /// <remarks/>
        public void getVilleDepartAsync(object userState) {
            if ((this.getVilleDepartOperationCompleted == null)) {
                this.getVilleDepartOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetVilleDepartOperationCompleted);
            }
            this.InvokeAsync("getVilleDepart", new object[0], this.getVilleDepartOperationCompleted, userState);
        }
        
        private void OngetVilleDepartOperationCompleted(object arg) {
            if ((this.getVilleDepartCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getVilleDepartCompleted(this, new getVilleDepartCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getVilleArrivee", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] getVilleArrivee(string VilleDepart) {
            object[] results = this.Invoke("getVilleArrivee", new object[] {
                        VilleDepart});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void getVilleArriveeAsync(string VilleDepart) {
            this.getVilleArriveeAsync(VilleDepart, null);
        }
        
        /// <remarks/>
        public void getVilleArriveeAsync(string VilleDepart, object userState) {
            if ((this.getVilleArriveeOperationCompleted == null)) {
                this.getVilleArriveeOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetVilleArriveeOperationCompleted);
            }
            this.InvokeAsync("getVilleArrivee", new object[] {
                        VilleDepart}, this.getVilleArriveeOperationCompleted, userState);
        }
        
        private void OngetVilleArriveeOperationCompleted(object arg) {
            if ((this.getVilleArriveeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getVilleArriveeCompleted(this, new getVilleArriveeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void getVolsCompletedEventHandler(object sender, getVolsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getVolsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getVolsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void getVilleDepartCompletedEventHandler(object sender, getVilleDepartCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getVilleDepartCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getVilleDepartCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void getVilleArriveeCompletedEventHandler(object sender, getVilleArriveeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getVilleArriveeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getVilleArriveeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591