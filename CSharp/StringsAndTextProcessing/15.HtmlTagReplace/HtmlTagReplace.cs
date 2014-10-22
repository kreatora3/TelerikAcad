﻿/*Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 
   Sample HTML fragment:
 
 <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course.
 Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
 
  Result:
 
 <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. 
 Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class HtmlTagReplace
{
    static void Main()
    {
        string s = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

        StringBuilder sb = new StringBuilder(s);

        sb = sb.Replace("<a href=\"", "[URL=");
        sb = sb.Replace("\">", "]");
        sb = sb.Replace("</a>", "[/URL]");

        Console.WriteLine(sb.ToString());
        
    }
}

