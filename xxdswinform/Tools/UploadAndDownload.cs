namespace xxdswinform.Tools
{
    using System;
    using System.IO;
    using System.Net;

    public class UploadAndDownload
    {
        private static string ftpPassword = "5HjpbwqB";
        private static string ftpServerIP = "202.118.26.80:21";
        private static string ftpUserID = "xxdsExam2";

        public static void DownloadFile(string filePath, string fileName)
        {
            FileStream stream = new FileStream("./temp/" + fileName, FileMode.Create);
            FtpWebRequest request = (FtpWebRequest) WebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + filePath + "/" + fileName));
            request.Method = "RETR";
            request.UseBinary = true;
            request.KeepAlive = false;
            request.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
            FtpWebResponse response = (FtpWebResponse) request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            long contentLength = response.ContentLength;
            int count = 0x800;
            byte[] buffer = new byte[count];
            for (int i = responseStream.Read(buffer, 0, count); i > 0; i = responseStream.Read(buffer, 0, count))
            {
                stream.Write(buffer, 0, i);
            }
            stream.Close();
            responseStream.Close();
            response.Close();
        }

        public static void MakeDir(string dirName)
        {
            FtpWebRequest request = null;
            try
            {
                request = (FtpWebRequest) WebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + dirName));
                request.UseBinary = true;
                request.KeepAlive = false;
                request.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                request.Method = "MKD";
                ((FtpWebResponse) request.GetResponse()).Close();
            }
            catch (Exception)
            {
            }
        }

        public static void Upload(string uriPath, string filePath)
        {
            FileInfo info = new FileInfo(filePath);
            FtpWebRequest request = (FtpWebRequest) WebRequest.Create("ftp://" + ftpServerIP + "/" + uriPath);
            request.UseBinary = true;
            request.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
            request.KeepAlive = false;
            request.Method = "STOR";
            request.ContentLength = info.Length;
            int count = 0x800;
            byte[] buffer = new byte[count];
            FileStream stream = info.OpenRead();
            Stream requestStream = request.GetRequestStream();
            for (int i = stream.Read(buffer, 0, count); i != 0; i = stream.Read(buffer, 0, count))
            {
                requestStream.Write(buffer, 0, i);
            }
            requestStream.Close();
            stream.Close();
        }
    }
}

