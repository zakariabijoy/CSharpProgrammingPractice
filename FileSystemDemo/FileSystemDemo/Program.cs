using System;
using System.IO;

namespace FileSystemDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\Zakaria\Downloads\Compressed";

            //string[] dirs = Directory.GetDirectories(rootPath,"*",SearchOption.AllDirectories);

            //foreach (var dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}


            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

            //foreach (var file in files)
            //{
            //    //Console.WriteLine(file);
            //    //Console.WriteLine(Path.GetFileName(file));
            //    //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //    //Console.WriteLine(Path.GetDirectoryName(file));

            //    var info = new FileInfo(file);
            //    Console.WriteLine($"{Path.GetFileName(file)} : {info.Length} bytes");
            //}

            //string newPath = @"C:\Users\Zakaria\Downloads\Compressed\SubFolderA\SubFolderC";
            //Directory.CreateDirectory(newPath);
            //bool directoryExists = Directory.Exists(newPath);

            //if (directoryExists)
            //{
            //    Console.WriteLine("directory Exists");

            //}
            //else
            //{
            //    Console.WriteLine("directory don't exists");
            //    Directory.CreateDirectory(newPath);
            //}

            //var files = Directory.GetFiles(rootPath);
            //string destinationPath = @"C:\Users\Zakaria\Downloads\Compressed\SubFolderA\";

            //foreach (string file in files)
            //{
            //    File.Copy(file, $"{destinationPath}{Path.GetFileName(file)}", true);
            //} 

            //foreach (string file in files)
            //{
            //    File.Move(file, $"{destinationPath}{Path.GetFileName(file)}");
            //}


            var files = Directory.GetFiles(rootPath, "*folder*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine(file);
                //Console.WriteLine(Path.GetFileName(file));
                //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                //Console.WriteLine(Path.GetDirectoryName(file));

                //var info = new FileInfo(file);
                //Console.WriteLine($"{Path.GetFileName(file)} : {info.Length} bytes");
            }

        }
    }
}
