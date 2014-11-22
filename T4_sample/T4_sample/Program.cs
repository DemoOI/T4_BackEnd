using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace T4_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //連上PTT網站取回文章資料
            List<Post> posts = new List<Post>();
            posts.Add(new Post()
            {
                Date = "date",
                Author = "author",
                Subject = "subject"
            });

            //將文章資料當成參數傳給T4
            RTT4 t = new RTT4(posts);
            //執行TransformText()即可取得結果
            Console.WriteLine(t.TransformText());
            Console.Read();
        }

    }
}
