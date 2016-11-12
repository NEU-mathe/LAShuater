namespace xxdswinform.WebReference
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("System.Xml", "4.0.30319.34230"), DebuggerStepThrough, DesignerCategory("code"), XmlType(Namespace="http://tempuri.org/")]
    public class StudentServiceModel
    {
        private string calculationnumberField;
        private string choosenumberField;
        private DateTime currenttimeField;
        private DateTime endtimeField;
        private int examcodeField;
        private string gapfillingnumberField;
        private int gradeField;
        private bool isregenerationField;
        private string macField;
        private DateTime starttimeField;
        private int statusField;
        private string studentclassField;
        private string studentnameField;
        private string studentnumberField;
        private int versionField;

        public string calculationnumber
        {
            get
            {
                return this.calculationnumberField;
            }
            set
            {
                this.calculationnumberField = value;
            }
        }

        public string choosenumber
        {
            get
            {
                return this.choosenumberField;
            }
            set
            {
                this.choosenumberField = value;
            }
        }

        public DateTime currenttime
        {
            get
            {
                return this.currenttimeField;
            }
            set
            {
                this.currenttimeField = value;
            }
        }

        public DateTime endtime
        {
            get
            {
                return this.endtimeField;
            }
            set
            {
                this.endtimeField = value;
            }
        }

        public int examcode
        {
            get
            {
                return this.examcodeField;
            }
            set
            {
                this.examcodeField = value;
            }
        }

        public string gapfillingnumber
        {
            get
            {
                return this.gapfillingnumberField;
            }
            set
            {
                this.gapfillingnumberField = value;
            }
        }

        public int grade
        {
            get
            {
                return this.gradeField;
            }
            set
            {
                this.gradeField = value;
            }
        }

        public bool isregeneration
        {
            get
            {
                return this.isregenerationField;
            }
            set
            {
                this.isregenerationField = value;
            }
        }

        public string mac
        {
            get
            {
                return this.macField;
            }
            set
            {
                this.macField = value;
            }
        }

        public DateTime starttime
        {
            get
            {
                return this.starttimeField;
            }
            set
            {
                this.starttimeField = value;
            }
        }

        public int status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        public string studentclass
        {
            get
            {
                return this.studentclassField;
            }
            set
            {
                this.studentclassField = value;
            }
        }

        public string studentname
        {
            get
            {
                return this.studentnameField;
            }
            set
            {
                this.studentnameField = value;
            }
        }

        public string studentnumber
        {
            get
            {
                return this.studentnumberField;
            }
            set
            {
                this.studentnumberField = value;
            }
        }

        public int version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }
}

