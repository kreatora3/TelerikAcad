/*Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 
 * Example:
 * <html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skillful .NET software engineers.</p></body>
</html>

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class HTMLTextExtract
{

    static void Main(string[] args)
    {
        string html = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a> aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body> </html> ";

        string patternTitle = "<title>(.*?)</title>";
        Console.WriteLine("Title: {0}", Regex.Match(html, patternTitle).Groups[1].ToString());

        string patternBody = "<body>(.*)</body>";
        string patternInnerBody = ">(.*?)<";
        string body = Regex.Match(html, patternBody).Groups[1].ToString();
        foreach (Match match in Regex.Matches(body, patternInnerBody))
        {
            Console.Write(match.Groups[1].ToString());
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

