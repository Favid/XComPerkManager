using Ini;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XcomPerkManager.Import
{
    public class SoldierClassImporter
    {
        private string filePath { get; set; }
        private IniFile iniFile { get; set; }

        public SoldierClassImporter()
        {
            this.filePath = "";
            this.iniFile = null;
        }

        public SoldierClassImporter(string filePath)
        {
            this.filePath = filePath;
            this.iniFile = new IniFile(filePath);
        }

        public void import()
        {
            if(filePath == "" || iniFile == null)
            {
                return;
            }

            string[] iniClassPairs = IniFile.ReadKeyValuePairs("XComGame.X2SoldierClass_DefaultClasses", filePath);

            List<string> classNames = new List<string>();

            foreach(string iniClassPair in iniClassPairs)
            {
                classNames.Add(iniClassPair.Split('=')[1]);
            }

            foreach(string className in classNames)
            {
                string[] iniClassDatas = IniFile.ReadKeyValuePairs(className + " X2SoldierClassTemplate", filePath);

                List<Tuple<string, string>> classDatas = new List<Tuple<string, string>>();
                foreach (string iniClassData in iniClassDatas)
                {
                    int splitIndex = iniClassData.IndexOf('=');

                    if(splitIndex > 0)
                    {
                        string[] temp = new string[2];
                        temp[0] = iniClassData.Substring(0, splitIndex);
                        temp[1] = iniClassData.Substring(splitIndex + 1);
                        if (temp.Length >= 2)
                        {
                            Tuple<string, string> t = new Tuple<string, string>(temp[0], temp[1]);
                            classDatas.Add(t);
                        }
                    }
                    
                }

                List<string> allowedWeapons = classDatas.Where(x => x.Item1 == "+AllowedWeapons").Select(y => y.Item2).ToList();
                
            }
        }

    }
}
