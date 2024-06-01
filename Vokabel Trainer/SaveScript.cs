namespace Vokabel_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class SaveScript
    {
        public CConsole cConsole;
        public string path;
        Dictionary<string, string> saved = new Dictionary<string, string>();
        Dictionary<string, Dictionary<string, string>> clases = new Dictionary<string, Dictionary<string, string>>();

        private char[] Readed;
        private int CurrentChar = 0;

        public SaveScript(string Path, CConsole cC)
        {
            this.path = Path;
            this.cConsole = cC;
        }

        public void Read()
        {
            try
            {
                cConsole.WriteLine("SS path: " + path);
                CurrentChar = 0;
                saved.Clear();
                clases.Clear();
                FileStream fs = new FileStream(path, FileMode.Open);
                StreamReader SR = new StreamReader(fs);
                string ThatWhatWeHadeReaded = SR.ReadToEnd();
                Readed = ThatWhatWeHadeReaded.ToCharArray(0, ThatWhatWeHadeReaded.Length);
                SR.Close();
                Analize();
            }
            catch (Exception ex)
            {
                cConsole.WriteLine(ex.Message);
            }
        }
        public string[] getAllClassNames()
        {
            string[] output = new string[0];
            List<string> names = new List<string>();
            foreach (KeyValuePair<string, Dictionary<string, string>> vars in clases)
            {
                names.Add(vars.Key);
            }
            output = names.ToArray();
            return output;
        }
        public void Write(string[] mes, bool append = false)
        {
            if (!append)
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                foreach (string s in mes)
                {
                    sw.WriteLine(s);
                }
                sw.Close();
            }
            else
            {
                FileStream fs = new FileStream(path, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                foreach (string s in mes)
                {
                    sw.WriteLine(s);
                }
                sw.Close();
            }
        }
        public void Write(string ClassName, string[] mes, bool append = false)
        {
            if (!append)
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(ClassName + "(");
                foreach (string s in mes)
                {
                    sw.WriteLine(s);
                }
                sw.WriteLine(")");
                sw.Close();
            }
            else
            {
                FileStream fs = new FileStream(path, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(ClassName + "(");
                foreach (string s in mes)
                {
                    sw.WriteLine(s);
                }
                sw.WriteLine(")");
                sw.Close();
            }
        }
        public void Log()
        {
            foreach (KeyValuePair<string, string> st in saved)
            {
                cConsole.WriteLine(st.Key + " : " + st.Value);
            }
        }
        public void LogAll()
        {
            foreach (KeyValuePair<string, Dictionary<string, string>> vars in clases)
            {
                foreach (KeyValuePair<string, string> keys in vars.Value)
                {
                    cConsole.WriteLine("Class: '" + vars.Key + "' VarName: '" + keys.Key + "' Value: '" + keys.Value + "'");
                }
            }
        }
        public string GetVariable(string VarName)
        {
            string Value = string.Empty;
            foreach (KeyValuePair<string, string> st in saved)
            {
                //cConsole.WriteLine(st.Key + " : " + st.Value);
                if (st.Key == VarName) return st.Value;
            }
            if (Value == string.Empty)
            {
                cConsole.WriteLine("Key Not Found: " + VarName);
                Value = "0";
            }
            return Value;
        }

        public string GetVariable(string VarClass, string VarName)
        {
            bool foundClass = false;

            foreach (KeyValuePair<string, Dictionary<string, string>> vars in clases)
            {
                if (VarClass == vars.Key)
                {
                    foundClass = true;
                    foreach (KeyValuePair<string, string> keys in vars.Value)
                    {
                        if (keys.Key == VarName) return keys.Value;
                    }
                }
            }
            if (foundClass)
                cConsole.WriteLine("Found Class, but not Value. Class Name: '" + VarClass + "' VarName: '" + VarName + "'");
            else cConsole.WriteLine("Found nothing from both. Class Name: '" + VarClass + "' VarName: '" + VarName + "'");
            return "0";
        }
        private string GetVarName()
        {
            string VarName = string.Empty;

            while (true)
            {
                VarName += Readed[CurrentChar];
                CurrentChar++;
                if (Readed[CurrentChar] == ':') break;
                else if (Readed[CurrentChar] == '(') break;
                else if (Readed[CurrentChar] == '\n') break;
            }

            return VarName.Replace("\n", "").Replace(" ", "_");//Never Change the First Replace or System is going to brake; The Second Replaces does effectivly nothing but keep it befor it breaks; Update: It do works and do something
        }
        private string ReadValue()
        {
            string value = string.Empty;

            while (Readed[CurrentChar] != '\n')
            {
                if (Readed[CurrentChar] != '\n')
                {
                    CurrentChar++;
                    value += Readed[CurrentChar];
                }
                else break;
            }

            return value;
        }
        private void Analize()
        {
            try
            {
                string VarName = GetVarName();

                if (Readed[CurrentChar] == ':')
                {
                    saved.Add(VarName, ReadValue());
                    Analize();
                }
                else if (Readed[CurrentChar] == '(')
                {
                    CurrentChar += 2;
                    clases.Add(VarName, Analize2());
                    Analize();
                }
                else
                {
                    CurrentChar++;
                    Analize();
                }
            }
            catch (Exception ex)
            {
                cConsole.WriteLine(ex.Message);
            }
        }
        private Dictionary<string, string> Analize2()
        {
            Dictionary<string, string> RT = new Dictionary<string, string>();

            while (Readed[CurrentChar] != ')')
            {
                string VarName = string.Empty;
                VarName = GetVarName();

                if (Readed[CurrentChar] == ':') RT.Add(VarName, ReadValue());
                else if (Readed[CurrentChar] == '\n') break;
            }

            CurrentChar++;
            return RT;
        }
    }

}
