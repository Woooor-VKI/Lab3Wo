using Lab3Wo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Wo.Classes
{
    public class Controller
    {
        public interface ISend
        {
            void SendInfo(InfTriangle triangle);
        }
        public class Send : ISend
        {
            public void SendInfo(InfTriangle triangle)
            {
                Console.WriteLine($"Отправка данных: {triangle.One} {triangle.Two} {triangle.Three} {triangle.Type}");
            }
        }

        public static InfTriangle GetControl(string f, string s, string t)
        {
            if (TriangleMethods.SearchInfo(f, s, t) == null) TriangleMethods.AddInfo(f, s, t);
            Send send = new Send();
            send.SendInfo(TriangleMethods.SearchInfo(f, s, t));
            return TriangleMethods.SearchInfo(f, s, t);
        }
    }
}
 