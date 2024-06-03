using ChilkatConsumer;

namespace ChilkatSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("trying to zip the files");

                var packageManager = new PackageManager();
                packageManager.ZipFiles(new string[] { "file1.txt", "file2.txt" });

                Console.WriteLine("Zipped the files successfully");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to zip the files");

                Console.WriteLine(e);

                Console.ReadLine();
            }
        }
    }
}
