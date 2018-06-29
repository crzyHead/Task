using System;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace TestUnit
{
    public class Loader
    {
        public static void Load()
        {
            Console.WriteLine("Job Name: \nJob Description: "); // Is this a JoJo refference?
        }
        public static void Load(string Url, string FileName, string Directory)
        {
            WebClient wc = new WebClient();
            wc.DownloadFile(Url, Directory + FileName);
            FileStream file = new FileStream(Directory + FileName, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string pattern = @"<p>(?<val>.*?)<\/p>";
            RegexOptions options = RegexOptions.Compiled | RegexOptions.Multiline;
            Regex regex = new Regex(pattern, options);
            Match match = regex.Match(reader.ReadToEnd());
            string result = "";
            while (match.Success)
            {
                result += match.Groups["val"].Value + "\n";
                match = match.NextMatch();
            }
            Console.WriteLine("Description:");
            Console.WriteLine(result);
            reader.Close();
            File.Delete(Directory + FileName);
        }
    }
}
