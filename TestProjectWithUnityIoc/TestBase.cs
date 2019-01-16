using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace TestProjectWithUnityIoc
{
    public class TestBase
    {
        public XDocument ReadXml(string path)
        {
            return XDocument.Load(path);
        }

        public void Log(string message)
        {
            System.Diagnostics.Debug.WriteLine($"\n{ message}");
        }

        public bool CommonResponseValidator(string resultNode)
        {
            var expectedResults = ReadXml(@"ResponseData\Common.xml").ToString();
            return CompareXml(expectedResults, resultNode);
        }

        public bool CompareXml(string expectedXml, string resultXml)
        {
            Log("EXPECTED RESULT");
            Log(expectedXml);
            Log("RESPONSE RESULT");
            Log(resultXml);
            var orginalXmlHash = ConvertStringToHash(expectedXml);
            var resultXmlHash = ConvertStringToHash(resultXml);
            return (orginalXmlHash == resultXmlHash);
        }

        private string ConvertStringToHash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
