using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerQuestionnaire
{
    public class FileHelper
    {
        public static void WriteToFile(User user)
        {
            var serializer = new JsonSerializer();
            string filename = user.FirstName + user.LastName;

            using (var sw = new StreamWriter(filename))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;

                    serializer.Serialize(jw,user);
                }
            }
        }
    }
}
