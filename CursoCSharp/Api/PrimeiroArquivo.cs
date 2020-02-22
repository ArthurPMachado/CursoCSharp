using System;
using System.IO;

namespace CursoCSharp.Api {
    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }

    class PrimeiroArquivo {
        public static void Executar() {
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if(!File.Exists(path)) {
                using(StreamWriter stream = File.CreateText(path)) {
                    stream.WriteLine("Esse é");
                    stream.WriteLine("o nosso");
                    stream.WriteLine("primeiro");
                    stream.WriteLine("arquivo!");
                }
            }
            using(StreamWriter stream = File.AppendText(path)) {
                stream.WriteLine("");
                stream.WriteLine("É possível");
                stream.WriteLine("adicionar");
                stream.WriteLine("mais texto");
            }
        }
    }
}
