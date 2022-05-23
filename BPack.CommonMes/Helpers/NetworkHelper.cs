using System;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Net;

namespace BPack.CommonMes.Helpers
{
    public static class NetworkHelper
    {
        public static ManagementObjectCollection getPrinters(string printerName)
        {
            var scope = new ManagementScope(@"\root\cimv2");
            scope.Connect();

            string query = "SELECT * FROM Win32_Printer WHERE Name='" + printerName + "'";
            var managementObjectCollection = new ManagementObjectSearcher(query).Get();

            return managementObjectCollection;
        }

        /// <summary>
        /// managementObject.Properties["Name"]
        /// managementObject.Properties["PortNumber"]
        /// managementObject.Properties["HostAddress"]
        /// </summary>
        /// <param name="portName"></param>
        /// <returns></returns>
        public static ManagementObject getNetworkPrinter(string printerName)
        {
            var scope = new ManagementScope(@"\root\cimv2");
            scope.Connect();

            var printers = getPrinters(printerName);
            foreach (var printer in printers)
            {
                var portName = printer.Properties["PortName"].Value;

                string query = "SELECT * FROM Win32_TCPIPPrinterPort WHERE Name='" + portName + "'";
                var managementObjectCollection = new ManagementObjectSearcher(query).Get();

                if (managementObjectCollection != null)
                {
                    var managementObject = new ManagementObjectSearcher(query).Get().OfType<ManagementObject>().FirstOrDefault();
                    return managementObject;
                }
            }

            return null;
        }

        public static IPEndPoint CreateIPEndPoint(string endPoint)
        {
            string[] ep = endPoint.Split(':');
            if (ep.Length != 2) throw new FormatException("Invalid endpoint format");
            IPAddress ip;
            if (!IPAddress.TryParse(ep[0], out ip))
            {
                throw new FormatException("Invalid ip-adress");
            }
            int port;
            if (!int.TryParse(ep[1], NumberStyles.None, NumberFormatInfo.CurrentInfo, out port))
            {
                throw new FormatException("Invalid port");
            }
            return new IPEndPoint(ip, port);
        }
    }
}
