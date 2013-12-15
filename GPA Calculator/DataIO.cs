using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GPA_Calculator
{
    public static class DataIO
    {
        public static void SaveCurrentClasses(List<Class> classes)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (StreamReader sr = new StreamReader(ms))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ms, classes);
                    ms.Position = 0;
                    byte[] buffer = new byte[(int)ms.Length];
                    ms.Read(buffer, 0, buffer.Length);
                    Properties.Settings.Default.ClassesCurrent = Convert.ToBase64String(buffer);
                }
            }
            Properties.Settings.Default.Save();
        }

        public static void SaveHistoricClasses(List<Class> classes)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (StreamReader sr = new StreamReader(ms))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ms, classes);
                    ms.Position = 0;
                    byte[] buffer = new byte[(int)ms.Length];
                    ms.Read(buffer, 0, buffer.Length);
                    Properties.Settings.Default.ClassHistory = Convert.ToBase64String(buffer);
                }
            }
            Properties.Settings.Default.Save();
        }

        public static List<Class> LoadCurrentClasses()
        {
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(Properties.Settings.Default.ClassesCurrent)))
            {
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    return (List<Class>)bf.Deserialize(ms);
                }
                catch
                {
                    return new List<Class>();
                }
            }
        }

        public static List<Class> LoadHistoricClasses()
        {
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(Properties.Settings.Default.ClassHistory)))
            {
                BinaryFormatter bf = new BinaryFormatter();

                try
                {
                    return (List<Class>)bf.Deserialize(ms);
                }
                catch
                {
                    return new List<Class>();//return empty list
                }
            }
        }
    }
}
