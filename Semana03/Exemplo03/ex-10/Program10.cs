using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSCourse
{
    class Program
    { 
        static void Main(string[] args)
        { 
                string[] arquivos = Directory.GetFiles(@"C:\");

                foreach(var arquivos in arquivos)
                {
                    Console.WriteLine(arquivo);
                }

                Console.ReadKey(true);
        }

    }
}