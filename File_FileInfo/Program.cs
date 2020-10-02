using System;
using System.IO;

namespace File_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * FILE E FILEINFO:
             - Namespace System.IO
            - Realiza operações com arquivos (create, copy, delete, move, open, etc.) e ajuda na criação de objetos FileStream.(Objeto FileStream: é um objeto que encapsula a sequencia de leitura ou escrita em um recurso de entrada e saida, no caso, um arquivo.)

            - File ( A classe file é mais simples, pois simplismente disponibiliza operações estáticas então não é preciso instanciar um objeto para depois chamar as operações pois são estáticas. Ela é mais simples de se utilisar, porém ela realiza verificação de segurança para cada operação chamada, então ela acaba sendo um pouco mais lenta que o fileInfo) 
             
            - FileInfo ( Já essa classe "fileInfo" tem que instanciar um objeto e aí sim chamar as operações apartir dele, e esse objeto já estará atrelado ao arquivo que for aberto e o sistema já será avisado disso, então não sera necessario que o sistema execute uma verificação para cada operação, ficando um pouco mais rápido.)

            * ** IOException (É a superclasse que contém todas as exceções possíveis que podem ocorrer ao tabalhar com arquivos, também pertence ao namespace System.IO.)
              * Exceções possíveis padrão:
              - DirectoryNotFoudException
              - DriveNotFoudException
              - EndOfStremException
              - FileLoadException
              - FileNotFoundException
              - PathTooLongException
              - PipeException
             */

            string sourcePath = @"C:\ProgramasCSharp\ConceitoDeFile_FileInfo\File_FileInfo\file1.txt"; //Caminho para o arquivo criado, se utilisa o "@" para não haver a necessidade de utilizar duas barras na declaração do caminho

            string targetPath = @"C:\ProgramasCSharp\ConceitoDeFile_FileInfo\File_FileInfo\CopyFile1.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); //Instanciando um objeto recebendo como argumento ao arquivo que existe no caminho definido acima.
                fileInfo.CopyTo(targetPath); // . CopyTo - Copia o objeto instanciado acima para outro arquivo definido aqui.
                string[] lines = File.ReadAllLines(sourcePath); // .ReadAllLines serva para ler todas as linha do arquivo e garda-la nesse caso em cada linha do vetor criado.
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
