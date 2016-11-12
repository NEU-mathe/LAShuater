namespace xxdswinform.Utils
{
    using System;

    public static class StudentModel
    {
        private static string _calculationnumber;
        private static string _choosenumber;
        private static DateTime _endTime;
        private static int _examCode;
        private static string _gapfillingnumber;
        private static int _grade;
        private static bool _isregeneration = true;
        private static string _mac;
        private static DateTime _startTime;
        private static int _status;
        private static string _studentClass;
        private static string _studentName;
        private static string _studentnumber;

        public static string calculationNumber
        {
            get
            {
                return _calculationnumber;
            }
            set
            {
                _calculationnumber = value;
            }
        }

        public static string chooseNumber
        {
            get
            {
                return _choosenumber;
            }
            set
            {
                _choosenumber = value;
            }
        }

        public static DateTime endTime
        {
            get
            {
                return _endTime;
            }
            set
            {
                _endTime = value;
            }
        }

        public static int examCode
        {
            get
            {
                return _examCode;
            }
            set
            {
                _examCode = value;
            }
        }

        public static string gapfillingNumber
        {
            get
            {
                return _gapfillingnumber;
            }
            set
            {
                _gapfillingnumber = value;
            }
        }

        public static int grade
        {
            get
            {
                return _grade;
            }
            set
            {
                _grade = value;
            }
        }

        public static bool isReGeneration
        {
            get
            {
                return _isregeneration;
            }
            set
            {
                _isregeneration = value;
            }
        }

        public static string mac
        {
            get
            {
                return _mac;
            }
            set
            {
                _mac = value;
            }
        }

        public static DateTime startTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                _startTime = value;
            }
        }

        public static int status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        public static string studentClass
        {
            get
            {
                return _studentClass;
            }
            set
            {
                _studentClass = value;
            }
        }

        public static string studentName
        {
            get
            {
                return _studentName;
            }
            set
            {
                _studentName = value;
            }
        }

        public static string studentNumber
        {
            get
            {
                return _studentnumber;
            }
            set
            {
                _studentnumber = value;
            }
        }
    }
}

