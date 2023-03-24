using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_Lab10.ProxyPatern
{
    // Клас-проксі для роботи з файлами
    public class FileProxy : IFile
    {
        private IFile _file;

        public FileProxy(IFile file)
        {
            _file = file;
        }

        public string Read(string filename)
        {
            if (!CanAccessFile(filename))
            {
                MessageBox.Show($"Access to file {filename} is denied.");
                return null;
            }
            else
            {
                try
                {
                    string content = _file.Read(filename);

                    return content;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }        
        }

        public void Write(string filename, string content)
        {
            if (CanWrite(filename))
            {
                MessageBox.Show($"Access to file {filename} is denied.");
            }
            else
            {

                try
                {
                    _file.Write(filename, content);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

       
        private bool CanWrite(string filename)
        {
            try
            {
                var fileInfo = new FileInfo(filename);

                return fileInfo.IsReadOnly;
            }
            catch
            {
                return false;
            }
        }

        private bool CanAccessFile(string filename)
        {
            try
            {
                var fileInfo = new FileInfo(filename);

                return fileInfo.Exists;
            }
            catch
            {
                return false;
            }
        }

    }
}
