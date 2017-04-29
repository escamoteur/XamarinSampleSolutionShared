using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinSampleSolutionShared
{

    public partial class FileStorage
    {

        // This is a stupid example for a platform independent method
        string ReadUpperString(string filename)
        {
            return ReadAsString(filename).ToUpper();
        }

        string ReadAsString(string filename)
        {
            return ReadAsString(filename);
        }

        byte[] ReadAsBytes(string filename)
        {
            return ReadAsBytesImplementation(filename);
        }

    }
}
