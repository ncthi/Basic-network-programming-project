using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text.RegularExpressions;

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
                    string directoryPath = "";
                    string format = @"\d{1,2}:\d{1,2}"; // Định dạng của phần tử cần tìm

                    List<string> tempList = new List<string>();
                    bool found = false;
                    int index = -1;

                    for (int i = 0; i < parts.Length; i++)
                    {
                        if (Regex.IsMatch(parts[i], format))
                        {
                            found = true;
                            index = i;
                            break;
                        }
                    }

                    if (found)
                    {
                        for (int i = index + 1; i < parts.Length; i++)
                        {
                            tempList.Add(parts[i]);
                        }
                    }

                    directoryPath = string.Join(" ", tempList.ToArray());
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
                    string directoryPath = "";
                    string format = @"\d{1,2}:\d{1,2}"; // Định dạng của phần tử cần tìm

                    List<string> tempList = new List<string>();
                    bool found = false;
                    int index = -1;

                    for (int i = 0; i < parts.Length; i++)
                    {
                        if (Regex.IsMatch(parts[i], format))
                        {
                            found = true;
                            index = i;
                            break;
                        }
                    }

                    if (found)
                    {
                        for (int i = index + 1; i < parts.Length; i++)
                        {
                            tempList.Add(parts[i]);
                        }
                    }

                    directoryPath = string.Join(" ", tempList.ToArray());
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
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + remoteFile);
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

        // Download Folder
        public void downloadFolder(string remoteFolder, string localFolder)
        {
            try
            {
                // Tạo đường dẫn đến thư mục cần tải xuống trên máy chủ FTP
                string remoteFolderUrl = host + "/" + remoteFolder;

                // Tạo đường dẫn đến thư mục đích để lưu tệp tin và thư mục
                string localFolderFullPath = Path.GetFullPath(localFolder);

                // Tạo đường dẫn đến thư mục đích cho thư mục hiện tại
                string currentLocalFolder = Path.Combine(localFolderFullPath, Path.GetFileName(remoteFolder));
                Directory.CreateDirectory(currentLocalFolder);

                // Tạo yêu cầu lấy danh sách các tệp tin và thư mục trong thư mục cần tải xuống
                FtpWebRequest listRequest = (FtpWebRequest)WebRequest.Create(remoteFolderUrl);
                listRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                listRequest.Credentials = new NetworkCredential(user, pass);

                // Lấy danh sách các tệp tin và thư mục trong thư mục cần tải xuống
                List<string> lines = new List<string>();
                using (FtpWebResponse listResponse = (FtpWebResponse)listRequest.GetResponse())
                using (Stream responseStream = listResponse.GetResponseStream())
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    while (!reader.EndOfStream)
                    {
                        lines.Add(reader.ReadLine());
                    }
                }

                // Tải xuống tất cả các tệp tin và thư mục con trong thư mục cần tải xuống
                foreach (string line in lines)
                {
                    string[] tokens = line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                    string name = tokens[8];
                    string permissions = tokens[0];
                    string remoteUrl = remoteFolderUrl + "/" + name;
                    string localPath = Path.Combine(currentLocalFolder, name);

                    if (permissions[0] == 'd')
                    {
                        // Đệ quy tải xuống tất cả các thư mục con trong thư mục cần tải xuống
                        downloadFolder(remoteFolder + "/" + name, currentLocalFolder);
                    }
                    else
                    {
                        // Tải xuống tệp tin
                        FtpWebRequest downloadRequest = (FtpWebRequest)WebRequest.Create(remoteUrl);
                        downloadRequest.Credentials = new NetworkCredential(user, pass);
                        downloadRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                        using (Stream downloadStream = downloadRequest.GetResponse().GetResponseStream())
                        using (FileStream localFileStream = new FileStream(localPath, FileMode.Create))
                        {
                            downloadStream.CopyTo(localFileStream);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {
                    Console.WriteLine("Folder does not exist: " + remoteFolder);
                }
                else
                {
                    Console.WriteLine("Failed to download folder: " + remoteFolder + " - " + response.StatusCode + " - " + response.StatusDescription);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to download folder: " + remoteFolder + " - " + ex.Message);
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
        public void deleteFile(string deleteFile)
        {
            try
            {
                ftpRequest = (FtpWebRequest)WebRequest.Create(host + "/" + deleteFile);
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                // When in doubt, use these options
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                // Type of FTP request
                ftpRequest.Method = WebRequestMethods.Ftp.DeleteFile;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                // Clean resources
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return;
        }
        public void deleteFolder(string folder)
        {
            try
            {

                // Tạo đường dẫn đến thư mục cần xóa trên máy chủ FTP
                string deleteFolderUrl = host + "/" + folder;

                // Tạo yêu cầu lấy danh sách các tệp tin và thư mục trong thư mục cần xóa
                FtpWebRequest listRequest = (FtpWebRequest)WebRequest.Create(deleteFolderUrl);
                listRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                listRequest.Credentials = new NetworkCredential(user, pass);

                // Lấy danh sách các tệp tin và thư mục trong thư mục cần xóa
                List<string> lines = new List<string>();
                using (FtpWebResponse listResponse = (FtpWebResponse)listRequest.GetResponse())
                using (Stream responseStream = listResponse.GetResponseStream())
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    while (!reader.EndOfStream)
                    {
                        lines.Add(reader.ReadLine());
                    }
                }

                // Xóa tất cả các tệp tin và thư mục con trong thư mục cần xóa
                foreach (string line in lines)
                {
                    string[] tokens = line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                    string name = tokens[8];
                    string permissions = tokens[0];
                    string deleteUrl = deleteFolderUrl + "/" + name;

                    if (permissions[0] == 'd')
                    {
                        // Đệ quy xóa tất cả các thư mục con trong thư mục cần xóa
                        deleteFolder(deleteFolder + "/" + name);
                    }
                    else
                    {
                        // Xóa tệp tin
                        FtpWebRequest deleteRequest = (FtpWebRequest)WebRequest.Create(deleteUrl);
                        deleteRequest.Credentials = new NetworkCredential(user, pass);
                        deleteRequest.Method = WebRequestMethods.Ftp.DeleteFile;
                        using (FtpWebResponse deleteResponse = (FtpWebResponse)deleteRequest.GetResponse())
                        {
                            Console.WriteLine("File deleted successfully: " + deleteUrl);
                        }
                    }
                }

                // Xóa thư mục cần xóa
                FtpWebRequest deleteFolderRequest = (FtpWebRequest)WebRequest.Create(deleteFolderUrl);
                deleteFolderRequest.Credentials = new NetworkCredential(user, pass);
                deleteFolderRequest.Method = WebRequestMethods.Ftp.RemoveDirectory;
                using (FtpWebResponse deleteFolderResponse = (FtpWebResponse)deleteFolderRequest.GetResponse())
                {
                    Console.WriteLine("Folder deleted successfully: " + deleteFolderUrl);
                }
            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {
                    Console.WriteLine("Folder does not exist: " + deleteFolder);
                }
                else
                {
                    Console.WriteLine("Failed to delete folder: " + deleteFolder + " - " + response.StatusCode + " - " + response.StatusDescription);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to delete folder: " + deleteFolder + " - " + ex.Message);
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
        public (MemoryStream, string) copyFile(string copyFile)
        {
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(host + "/" + copyFile);
            ftpRequest.Credentials = new NetworkCredential(user, pass);
            ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
            FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            Stream ftpStream = ftpResponse.GetResponseStream();

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

            // Lấy tên tệp tin từ đường dẫn
            string filename = Path.GetFileName(copyFile);

            return (memoryStream, filename);
        }

        // Paste File
        public void paste(string currentPath, MemoryStream memoryStream, string filename)
        {
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(host + "/" + currentPath + "/" + filename);
            ftpRequest.Credentials = new NetworkCredential(user, pass);
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
            Stream ftpStream = ftpRequest.GetRequestStream();

            // Copy data from the memory stream to the FTP stream
            byte[] buffer = memoryStream.ToArray();
            ftpStream.Write(buffer, 0, buffer.Length);
            ftpStream.Flush();

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


