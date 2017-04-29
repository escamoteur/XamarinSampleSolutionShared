using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinSampleSolutionShared
{
    public partial class FileStorage 
    {
        public string ReadAsStringImplementation(string filename)
        {
            var bytes = ReadAsBytes(filename);
            return Encoding.UTF8.GetString(bytes);
        }

        public byte[] ReadAsBytesImplementation(string filename)
        {
            AssetManager assets = Android.App.Application.Context.Assets;
            using (Stream stream = assets.Open(filename))
            {
                using (var memStream = new MemoryStream())
                {
                    stream.CopyTo(memStream);
                    return memStream.ToArray();
                }
            }
        }

    }
}