namespace xxdswinform.WebReference
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [GeneratedCode("System.Web.Services", "4.0.30319.34209"), DebuggerStepThrough, DesignerCategory("code")]
    public class updateStudent_macCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal updateStudent_macCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        public bool Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return (bool) this.results[0];
            }
        }
    }
}

