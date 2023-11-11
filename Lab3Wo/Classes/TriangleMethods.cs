using Lab3Wo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Wo.Classes
{
    class TriangleMethods
    {
        public interface IGetable
        {
            (string, string, string) GetInput(string f, string s, string t);
        }

        public static InfTriangle SearchInfo(string f, string s, string t)
        {
            return ApplicationData.db.InfTriangle.FirstOrDefault(u => u.One == f && u.Two == s && u.Three == t);
        }

        public static InfTriangle AddInfo(string f, string s, string t)
        {
            var triangle = GettingTriangle.GetTriangle(f, s, t);
            InfTriangle temp = new InfTriangle();
            temp.One = f;
            temp.Two = s;
            temp.Three = t;
            temp.Type = triangle.Item1;
            temp.Exception = triangle.Item5;
            ApplicationData.db.InfTriangle.Add(temp);
            ApplicationData.db.SaveChanges();

            return temp;
        }

        public static void DeleteInfo(string f, string s, string t)
        {
            InfTriangle triangle = ApplicationData.db.InfTriangle.FirstOrDefault(u => u.One == f && u.Two == s && u.Three == t);
            ApplicationData.db.InfTriangle.Remove(triangle);

        }
    }
}
