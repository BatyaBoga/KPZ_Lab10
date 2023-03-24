
namespace KPZ_Lab10.ProxyPatern
{
    // Інтерфейс для роботи з файлами
    public interface IFile
    {
        string Read(string filename);
        void Write(string filename, string content);
    }
}
