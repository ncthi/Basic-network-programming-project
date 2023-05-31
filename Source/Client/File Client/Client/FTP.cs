using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection.Metadata;

namespace Client
{

    public class FTP
    {
        private string host = null;
        private string user = null;
        private string pass = null;
        private Stream ftpStream = null;
        private FtpWebRequest ftpRequest = null;
        private FtpWebResponse ftpResponse = null;
        private int bufferSize = 2048;

        public FTP(string hostIP, string username, string password)
        {
            host = hostIP;
            user = username;
            pass = password;
        }

        public void connect()
        {
            try
            {
                ftpRequest = (FtpWebRequest)WebRequest.Create(host);
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;

                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpStream = ftpResponse.GetResponseStream();
                StreamReader reader = new StreamReader(ftpStream);
                Console.WriteLine("SUCCESSFUL CONNECTION TO FTP SERVER");
                reader.Close();
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("CONNECT FAILED - Detail: " + ex.Message);
            }
        }
        public List<string> directoryListSimple(string directory)
        {
            List <string> listDirectory = new List<string>();
            try
            {
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + directory);
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                //
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                // Type of FTP request
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpStream = ftpResponse.GetResponseStream();
                StreamReader ftpReader = new StreamReader(ftpStream);
                string directoryRaw = null;
                try
                {
                    while (ftpReader.Peek() != -1)
                    {
                        string[] path = ftpReader.ReadLine().Split('/');
                        listDirectory.Add(path[path.Length - 1]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                //
                ftpReader.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
                return listDirectory;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return listDirectory;
            }
            
        }
        /* List Directory Contents in Detail (Name, Size, Created, etc.) */
        public List<string> directoryListDetailed(string directory)
        {
            List<string> listDirectory = new List<string>();
            try
            {
                /* Create an FTP Request */
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + directory);
                /* Log in to the FTP Server with the User Name and Password Provided */
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                /* When in doubt, use these options */
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                /* Specify the Type of FTP Request */
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                /* Establish Return Communication with the FTP Server */
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                /* Establish Return Communication with the FTP Server */
                ftpStream = ftpResponse.GetResponseStream();
                /* Get the FTP Server's Response Stream */
                StreamReader ftpReader = new StreamReader(ftpStream);
                /* Store the Raw Response */
                string directoryRaw = null;
                /* Read Each Line of the Response and Append a Pipe to Each Line for Easy Parsing */
                try
                {
                    while (ftpReader.Peek() != -1)
                    {
                        string[] path = ftpReader.ReadLine().Split('/');
                        listDirectory.Add(path[path.Length - 1]);
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                /* Resource Cleanup */
                ftpReader.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            /* Return an Empty string Array if an Exception Occurs */
            return listDirectory;
        }
        public static List<string> ListFile(List<string> list)
        {
            List<string> files = new List<string>();
            foreach (string file in list)
            {
                // Kiểm tra line có phải là tên thư mục hay không
                if (!file.StartsWith("d"))
                {
                    string[] parts = file.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string directoryPath = parts[parts.Length - 1];
                    string directoryName = Path.GetFileName(directoryPath);
                    files.Add(directoryName);
                }
            }
            return files;
        }
        public static List<string> ListDirectory(List<string> list)
        {
            List<string> dirs = new List<string>();
            foreach (string dir in list)
            {
                // Kiểm tra line có phải là tên thư mục hay không
                if (dir.StartsWith("d"))
                {
                    string[] parts = dir.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string directoryPath = parts[parts.Length - 1];
                    string directoryName = Path.GetFileName(directoryPath);
                    dirs.Add(directoryName);
                }
            }
            return dirs;
        }
        // Download function
        public void downloadFile(string remoteFile, string localFile)
        {
            try
            {
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + remoteFile);
                ftpRequest.Credentials = new NetworkCredential(user, pass);

                // When in doubt, use these options 
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;

                // Type of FTP request
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                string fileContents = null;
                try
                {
                    using (ftpResponse = (FtpWebResponse)ftpRequest.GetResponse())
                    {
                        using (Stream responseStream = ftpResponse.GetResponseStream())
                        {
                            using (FileStream fileStream = new FileStream(localFile, FileMode.Create))
                            {
                                byte[] buffer = new byte[1024];
                                int bytesRead = 0;
                                while ((bytesRead = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    fileStream.Write(buffer, 0, bytesRead);
                                }
                            }
                        }
                    }
                    Console.WriteLine("DOWNLOAD SUCCESSFULLY");
                }
                catch
                {
                    Console.WriteLine("DOWNLOAD UNSUCCESSFULLY");
                }


                // Clean resources
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        // Upload File
        public void uploadFile(string remoteFile, string localFile)
        {
            try
            {
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + remoteFile);
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                //
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                // Type of FTP request
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                using (Stream fileStream = File.OpenRead(localFile))
                using (Stream ftpStream = ftpRequest.GetRequestStream())
                {
                    byte[] buffer = new byte[10240];
                    int read;
                    while ((read = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        ftpStream.Write(buffer, 0, read);
                        Console.WriteLine("Uploaded {0} bytes", fileStream.Position);
                    }
                }
                //
                ftpStream.Close();
                ftpRequest = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return;
        }

        // Upload Folder
        public void uploadFolder(string remoteFolder, string localFolder)
        {
            // Tải lên tất cả các tệp tin trong thư mục cục bộ lên máy chủ FTP
            foreach (string file in Directory.GetFiles(localFolder))
            {
                string remoteFile = remoteFolder + "/" + Path.GetFileName(file);
                uploadFile(remoteFile, file);
            }

            // Tải lên tất cả các thư mục con trong thư mục cục bộ lên máy chủ FTP
            foreach (string subFolder in Directory.GetDirectories(localFolder))
            {
                string remoteSubFolder = remoteFolder + "/" + Path.GetFileName(subFolder);
                createDirectory(remoteSubFolder); // Tạo thư mục trên máy chủ FTP nếu chưa có
                uploadFolder(remoteSubFolder, subFolder); // Đệ quy để tải lên tất cả các tệp tin và thư mục con
            }
        }

        // Delete file function
        public void delete(string deletePath)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host + "/" + deletePath);
            request.Credentials = new NetworkCredential(user, pass);
            request.UseBinary = true;
            request.UsePassive = true;
            request.KeepAlive = true;

            bool isFile = false;
            try
            {
                request.Method = WebRequestMethods.Ftp.GetFileSize;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    isFile = true;
                    response.Close();
                }
            }
            catch { }

            if (isFile)
            {
                request.Method = WebRequestMethods.Ftp.DeleteFile;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    response.Close();
                }
            }
            else
            {
                request.Method = WebRequestMethods.Ftp.RemoveDirectory;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    response.Close();
                }
            }
        }


        // Rename File 
        public void rename(string currentFileNameAndPath, string newFileName)
        {
            try
            {
                ftpRequest = (FtpWebRequest)WebRequest.Create(host + "/" + currentFileNameAndPath);
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                // When in doubt, use these options 
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                // Type of FTP request
                ftpRequest.Method = WebRequestMethods.Ftp.Rename;
                // Rename
                ftpRequest.RenameTo = newFileName;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                // Clean resource 
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return;
        }

        // Copy File
        public MemoryStream copy(string copyFile)
        {
            ftpRequest = (FtpWebRequest)WebRequest.Create(host + "/" + copyFile);
            ftpRequest.Credentials = new NetworkCredential(user, pass);
            ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
            ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            ftpStream = ftpResponse.GetResponseStream();

            MemoryStream memoryStream = new MemoryStream();

            int buffLength = 2048;
            byte[] byteBuffer = new byte[buffLength];

            int bytesRead = ftpStream.Read(byteBuffer, 0, buffLength);

            if (bytesRead > 0)
            {
                while (bytesRead > 0)
                {
                    memoryStream.Write(byteBuffer, 0, bytesRead);
                    bytesRead = ftpStream.Read(byteBuffer, 0, buffLength);
                }
            }

            ftpStream.Close();
            ftpResponse.Close();
            ((IDisposable)ftpResponse).Dispose();

            return memoryStream;
        }


        // Paste File
        public void paste(string pasteFile, MemoryStream memoryStream)
        {
            ftpRequest = (FtpWebRequest)WebRequest.Create(host + "/" + pasteFile);
            ftpRequest.Credentials = new NetworkCredential(user, pass);
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
            ftpStream = ftpRequest.GetRequestStream();

            // Copy data from the memory stream to the FTP stream
            byte[] buffer = memoryStream.ToArray();
            ftpStream.Write(buffer, 0, buffer.Length);

            // Dispose of the memory stream
            memoryStream.Dispose();
            ftpStream.Close();
            ftpStream.Dispose();
        }

        //Browse all files that have been stored in FTP server
        public string[] browseFile(string directory)
        {
            try
            {
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + directory);
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                // Thay đổi phương thức của yêu cầu FTP để lấy danh sách các tệp tin
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpStream = ftpResponse.GetResponseStream();
                StreamReader ftpReader = new StreamReader(ftpStream);
                // Lưu kết quả
                string directoryRaw = null;
                // Đọc từng dòng của kết quả và lấy tên tệp tin
                try
                {
                    while (ftpReader.Peek() != -1)
                    {
                        directoryRaw += ftpReader.ReadLine() + "|";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                ftpReader.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
                try
                {
                    string[] directoryList = directoryRaw.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    return directoryList;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine("NO FILE AVAILABLE"); }
            // Trả về mảng chuỗi rỗng nếu xảy ra lỗi
            return new string[] { "" };
        }
       

        //Create a new directory on FTP server
        public void createDirectory(string newDirectory)
        {
            try
            {
                ftpRequest = (FtpWebRequest)WebRequest.Create(host + "/" + newDirectory);
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                // When in doubt, use these options 
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                // Type of FTP request
                ftpRequest.Method = WebRequestMethods.Ftp.MakeDirectory;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                // Clean resources
                ftpRequest = null;
                ftpResponse.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<string> getDirectory(string path)
        {
            List<string> directories = new List<string>();
            try
            {
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + path);
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;

                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpStream = ftpResponse.GetResponseStream();
                StreamReader reader = new StreamReader(ftpStream);
                string line = reader.ReadLine();
                while (line != null)
                {
                    directories.Add(line);
                    line = reader.ReadLine();
                }

                reader.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return directories;
        }

        //Lấy đường ở thư mục đang làm việc hiện tại
        public string WorkingDirectory()
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host);
            request.Credentials = new NetworkCredential(user,pass);
            request.Method = WebRequestMethods.Ftp.PrintWorkingDirectory;
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                return response.StatusDescription;
            }
        }
    }
    
}


