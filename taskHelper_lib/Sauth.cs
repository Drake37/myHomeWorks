using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace taskHelper_lib
{
    public struct Sauth
    {
        private string _login;
        private string _passw;

        public string L => _login;
        public string P => _passw;


        public Sauth(string file)
        {
            _login = ""; _passw = "";
            SetData(file);
        }
        public void SetData(string file)
        {
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    _login = sr.ReadLine();
                    _passw = sr.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("File not found");                
            }
        }
        public bool IsDataValid()
        {
            return _login == "root" && _passw == "GeekBrains";
        }
    }
}
