using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lesson4_Task3
{
    class Login
    {
        string[] myL;
        public bool LOGGED=false;
        static string fName= "loginData.txt";
        public Login(string l, string p)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(fName);
                myL = new string[2];
                for (int i = 0; i < 2; i++)
                    myL[i] = Convert.ToString(streamReader.ReadLine());

                LOGGED = checkLogin(l, p, myL[0], myL[1]);

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден!!!");
                StreamWriter streamWriter = new StreamWriter(fName);

                streamWriter.WriteLine("aaa1");
                streamWriter.WriteLine("aaa2");

                Console.WriteLine("Файл создан!!!login: aaa1 password: aaa2");
                streamWriter.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                streamReader?.Close();

            }
        }

        static bool checkLogin(string l1,string p1,string l2, string p2)
        {
            if (l1==l2 && p1==p2) {
                return true;
            }

            return false;
        }

    }
}
