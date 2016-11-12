namespace xxdswinform.WebReference1
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Web.Services;
    using System.Web.Services.Description;
    using System.Web.Services.Protocols;
    using xxdswinform.Properties;

    [WebServiceBinding(Name="FileServiceSoap", Namespace="http://tempuri.org/"), DesignerCategory("code"), GeneratedCode("System.Web.Services", "4.0.30319.34209"), DebuggerStepThrough]
    public class FileService : SoapHttpClientProtocol
    {
        private SendOrPostCallback studentFileDeleteOperationCompleted;
        private bool useDefaultCredentialsSetExplicitly;

        public event studentFileDeleteCompletedEventHandler studentFileDeleteCompleted;

        public FileService()
        {
            this.Url = Settings.Default.xxdswinform_WebReference_FileService;
            if (this.IsLocalFileSystemWebService(this.Url))
            {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        public void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            if ((url == null) || (url == string.Empty))
            {
                return false;
            }
            Uri uri = new Uri(url);
            return ((uri.Port >= 0x400) && (string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0));
        }

        private void OnstudentFileDeleteOperationCompleted(object arg)
        {
            if (this.studentFileDeleteCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.studentFileDeleteCompleted(this, new studentFileDeleteCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        [SoapDocumentMethod("http://tempuri.org/studentFileDelete", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool studentFileDelete(string filePath, string pwd)
        {
            return (bool) base.Invoke("studentFileDelete", new object[] { filePath, pwd })[0];
        }

        public void studentFileDeleteAsync(string filePath, string pwd)
        {
            this.studentFileDeleteAsync(filePath, pwd, null);
        }

        public void studentFileDeleteAsync(string filePath, string pwd, object userState)
        {
            if (this.studentFileDeleteOperationCompleted == null)
            {
                this.studentFileDeleteOperationCompleted = new SendOrPostCallback(this.OnstudentFileDeleteOperationCompleted);
            }
            base.InvokeAsync("studentFileDelete", new object[] { filePath, pwd }, this.studentFileDeleteOperationCompleted, userState);
        }

        public string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                if (!((!this.IsLocalFileSystemWebService(base.Url) || this.useDefaultCredentialsSetExplicitly) || this.IsLocalFileSystemWebService(value)))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }

        public bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }
            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
    }
}

