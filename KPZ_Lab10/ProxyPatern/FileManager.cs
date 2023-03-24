namespace KPZ_Lab10.ProxyPatern
{
    // Клас для роботи з файлами
    public class FileManager : IFile
    {
        public string Read(string filename)
        {
            return File.ReadAllText(filename);
        }

        public void Write(string filename, string content)
        {
            File.WriteAllText(filename, content);
        }
    }
}
