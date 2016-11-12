namespace xxdswinform.WebReference
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Web.Services;
    using System.Web.Services.Description;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using xxdswinform.Properties;

    [WebServiceBinding(Name="StudentServiceSoap", Namespace="http://tempuri.org/"), DesignerCategory("code"), GeneratedCode("System.Web.Services", "4.0.30319.34209"), DebuggerStepThrough]
    public class StudentService : SoapHttpClientProtocol
    {
        private SendOrPostCallback getCurrentTimeOperationCompleted;
        private SendOrPostCallback getStudentOperationCompleted;
        private SendOrPostCallback updateStudent_gradeOperationCompleted;
        private SendOrPostCallback updateStudent_macOperationCompleted;
        private SendOrPostCallback updateStudentOperationCompleted;
        private bool useDefaultCredentialsSetExplicitly;

        public event getCurrentTimeCompletedEventHandler getCurrentTimeCompleted;

        public event getStudentCompletedEventHandler getStudentCompleted;

        public event updateStudent_gradeCompletedEventHandler updateStudent_gradeCompleted;

        public event updateStudent_macCompletedEventHandler updateStudent_macCompleted;

        public event updateStudentCompletedEventHandler updateStudentCompleted;

        public StudentService()
        {
            this.Url = Settings.Default.xxdswinform_WebReference1_StudentService;
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

        [SoapDocumentMethod("http://tempuri.org/getCurrentTime", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public DateTime getCurrentTime()
        {
            return (DateTime) base.Invoke("getCurrentTime", new object[0])[0];
        }

        public void getCurrentTimeAsync()
        {
            this.getCurrentTimeAsync(null);
        }

        public void getCurrentTimeAsync(object userState)
        {
            if (this.getCurrentTimeOperationCompleted == null)
            {
                this.getCurrentTimeOperationCompleted = new SendOrPostCallback(this.OngetCurrentTimeOperationCompleted);
            }
            base.InvokeAsync("getCurrentTime", new object[0], this.getCurrentTimeOperationCompleted, userState);
        }

        [SoapDocumentMethod("http://tempuri.org/getStudent", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public StudentServiceModel getStudent(string studentId, string pwd)
        {
            return (StudentServiceModel) base.Invoke("getStudent", new object[] { studentId, pwd })[0];
        }

        public void getStudentAsync(string studentId, string pwd)
        {
            this.getStudentAsync(studentId, pwd, null);
        }

        public void getStudentAsync(string studentId, string pwd, object userState)
        {
            if (this.getStudentOperationCompleted == null)
            {
                this.getStudentOperationCompleted = new SendOrPostCallback(this.OngetStudentOperationCompleted);
            }
            base.InvokeAsync("getStudent", new object[] { studentId, pwd }, this.getStudentOperationCompleted, userState);
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

        private void OngetCurrentTimeOperationCompleted(object arg)
        {
            if (this.getCurrentTimeCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.getCurrentTimeCompleted(this, new getCurrentTimeCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OngetStudentOperationCompleted(object arg)
        {
            if (this.getStudentCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.getStudentCompleted(this, new getStudentCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnupdateStudent_gradeOperationCompleted(object arg)
        {
            if (this.updateStudent_gradeCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.updateStudent_gradeCompleted(this, new updateStudent_gradeCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnupdateStudent_macOperationCompleted(object arg)
        {
            if (this.updateStudent_macCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.updateStudent_macCompleted(this, new updateStudent_macCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        private void OnupdateStudentOperationCompleted(object arg)
        {
            if (this.updateStudentCompleted != null)
            {
                InvokeCompletedEventArgs args = (InvokeCompletedEventArgs) arg;
                this.updateStudentCompleted(this, new updateStudentCompletedEventArgs(args.Results, args.Error, args.Cancelled, args.UserState));
            }
        }

        [return: XmlElement("allResult")]
        [SoapDocumentMethod("http://tempuri.org/all", RequestElementName="all", RequestNamespace="http://tempuri.org/", ResponseElementName="allResponse", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool updateStudent(string studentnumber, string mac, bool isregeneration, int status, string pwd)
        {
            return (bool) base.Invoke("updateStudent", new object[] { studentnumber, mac, isregeneration, status, pwd })[0];
        }

        [SoapDocumentMethod("http://tempuri.org/updateStudent_grade", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public int updateStudent_grade(string studentnumber, int grade, string pwd)
        {
            return (int) base.Invoke("updateStudent_grade", new object[] { studentnumber, grade, pwd })[0];
        }

        public void updateStudent_gradeAsync(string studentnumber, int grade, string pwd)
        {
            this.updateStudent_gradeAsync(studentnumber, grade, pwd, null);
        }

        public void updateStudent_gradeAsync(string studentnumber, int grade, string pwd, object userState)
        {
            if (this.updateStudent_gradeOperationCompleted == null)
            {
                this.updateStudent_gradeOperationCompleted = new SendOrPostCallback(this.OnupdateStudent_gradeOperationCompleted);
            }
            base.InvokeAsync("updateStudent_grade", new object[] { studentnumber, grade, pwd }, this.updateStudent_gradeOperationCompleted, userState);
        }

        [return: XmlElement("macResult")]
        [SoapDocumentMethod("http://tempuri.org/mac", RequestElementName="mac", RequestNamespace="http://tempuri.org/", ResponseElementName="macResponse", ResponseNamespace="http://tempuri.org/", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool updateStudent_mac(string studentnumber, string mac, int status, string pwd)
        {
            return (bool) base.Invoke("updateStudent_mac", new object[] { studentnumber, mac, status, pwd })[0];
        }

        public void updateStudent_macAsync(string studentnumber, string mac, int status, string pwd)
        {
            this.updateStudent_macAsync(studentnumber, mac, status, pwd, null);
        }

        public void updateStudent_macAsync(string studentnumber, string mac, int status, string pwd, object userState)
        {
            if (this.updateStudent_macOperationCompleted == null)
            {
                this.updateStudent_macOperationCompleted = new SendOrPostCallback(this.OnupdateStudent_macOperationCompleted);
            }
            base.InvokeAsync("updateStudent_mac", new object[] { studentnumber, mac, status, pwd }, this.updateStudent_macOperationCompleted, userState);
        }

        public void updateStudentAsync(string studentnumber, string mac, bool isregeneration, int status, string pwd)
        {
            this.updateStudentAsync(studentnumber, mac, isregeneration, status, pwd, null);
        }

        public void updateStudentAsync(string studentnumber, string mac, bool isregeneration, int status, string pwd, object userState)
        {
            if (this.updateStudentOperationCompleted == null)
            {
                this.updateStudentOperationCompleted = new SendOrPostCallback(this.OnupdateStudentOperationCompleted);
            }
            base.InvokeAsync("updateStudent", new object[] { studentnumber, mac, isregeneration, status, pwd }, this.updateStudentOperationCompleted, userState);
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

