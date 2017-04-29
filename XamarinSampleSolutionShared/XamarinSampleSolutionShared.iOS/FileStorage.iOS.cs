using System.IO;

namespace XamarinSampleSolutionShared
{
    public partial class FileStorage
    {
        public byte[] ReadAsBytesImplementation(string filename)
        {
            var data = File.ReadAllBytes(filename);

            return data;
        }

        public string ReadAsStringImplementation(string filename)
        {
            var data = ReadAsBytes(filename);

            if (data == null)
                return string.Empty;

            return System.Text.Encoding.UTF8.GetString(data);
        }

    }
}