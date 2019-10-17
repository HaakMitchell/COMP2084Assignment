using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MitchJson
{
    class JsonMitch
    {
        string jsonValue = @"{'email':'new-email@hubspot.com', 'firstname': 'Mike', 'lastname': 'Dog'}";

        public Student JsonWorker()
        {
            Student s = JsonConvert.DeserializeObject<Student>(jsonValue);

            return s;
        }

        public void ReadJsonFile(string filename)
        {
            using (FileStream fileStream = new FileStream(filename, FileMode.Open))
            using (StreamReader streamRreader = new StreamReader(fileStream))
            {
                jsonValue = streamRreader.ReadToEnd();
            }
        }
    }
}
