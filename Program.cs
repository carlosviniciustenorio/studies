using Azure.Storage.Blobs.Specialized;
using studies.Colecoes.Pilha;
using studies.Record;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using static studies.Iterator.Class1;

namespace studies
{
    class Program
    {
        static void Main()
        {
            var connectionString = "";
            var source = new BlockBlobClient(connectionString, "container1", "study.txt");
            var destination = new BlockBlobClient(connectionString, "container2", "study-copy.txt");

            destination.StartCopyFromUri(source.Uri);
        }
    }
}