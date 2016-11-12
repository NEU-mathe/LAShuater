namespace xxdswinform.WebReference
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    [DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "4.0.30319.34209")]
    public class getStudentCompletedEventArgs : AsyncCompletedEventArgs
    {
        private object[] results;

        internal getStudentCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
        {
            this.results = results;
        }

        public StudentServiceModel Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return (StudentServiceModel) this.results[0];
            }
        }
    }
}

