namespace xxdswinform.Tools
{
    using System;
    using System.IO;
    using System.Net;

    public class UploadAndDownload2
    {
        private static string ftpPassword = "3P8wW0vC";
        private static string ftpServerIP = "202.118.26.80:21";
        private static string ftpUserID = "xxdsExam1";

        public static void DownloadFile(string filePath, string fileName)
        {
            //FileStream stream = new FileStream("./temp/" + fileName, FileMode.Create);
            File.Copy(@"xxdsExam1\" + filePath + "\\" + fileName, @"temp\" + fileName,true);
            //FtpWebRequest request = (FtpWebRequest) WebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + filePath + "/" + fileName));
            //request.Method = "RETR";
            //request.UseBinary = true;
            //request.KeepAlive = false;
            //request.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
            //FtpWebResponse response = (FtpWebResponse) request.GetResponse();
            //Stream responseStream = response.GetResponseStream();
            //long contentLength = response.ContentLength;
            //int count = 0x800;
            //byte[] buffer = new byte[count];
            //for (int i = responseStream.Read(buffer, 0, count); i > 0; i = responseStream.Read(buffer, 0, count))
            //{
            //    stream.Write(buffer, 0, i);
            //}
            //stream.Close();
            //responseStream.Close();
            //response.Close();
        }
    }
}

