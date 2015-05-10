using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sudoku
{
    [Serializable]
    public class Person : ISerializable
    {
        public string Name { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public int Time { get; set; }

        public Person()
        {
            Name = "";
            Minutes = 0;
            Seconds = 0;
            Time = 0;
        }

        public Person(string name, string time)
        {
            Name = name;
            string[] split = time.Split(':');
            Minutes = Convert.ToInt32(split[0]);
            Seconds = Convert.ToInt32(split[1]);
            Time = Minutes * 60 + Seconds;
        }

        private Person(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            Minutes = info.GetInt32("Minutes");
            Seconds = info.GetInt32("Seconds");
            Time = info.GetInt32("Time");
        }

        public void GetObjectData(SerializationInfo inf, StreamingContext con)
        {
            inf.AddValue("Name", Name);
            inf.AddValue("Minutes", Minutes);
            inf.AddValue("Seconds", Seconds);
            inf.AddValue("Time", Time);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("{0, -10}{1:00}:{2:00}\n", Name, Minutes, Seconds));

            return stringBuilder.ToString();
        }       
    }

}
