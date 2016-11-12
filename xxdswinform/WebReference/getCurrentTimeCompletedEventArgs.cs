namespace xxdswinform.WebReference
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "4.0.30319.34209")]
    public class getCurrentTimeCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal getCurrentTimeCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        public DateTime Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return (DateTime) this.results[0];
            }
        }
    }
}

