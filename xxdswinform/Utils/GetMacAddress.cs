namespace xxdswinform.Utils
{
    using System;
    using System.Management;

    public class GetMacAddress
    {
        public string getmac()
        {
            ManagementObjectCollection instances = new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
            string str = "";
            foreach (ManagementObject obj2 in instances)
            {
                if ((bool) obj2["IPEnabled"])
                {
                    str = obj2["MacAddress"].ToString();
                }
            }
            return str;
        }
    }
}

