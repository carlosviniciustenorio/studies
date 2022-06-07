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

            //token container 1 = sp=r&st=2022-06-07T01:50:03Z&se=2022-06-07T09:50:03Z&spr=https&sv=2020-08-04&sr=c&sig=ekN%2FabqgJrQdDVrK41rQAfnWhGWQrR8Yo4qZer7ouXI%3D
            
            azcopy copy 'https://<storagelabtenorio>.blob.core.windows.net/<container1>/<study.txt><sp=r&st=2022-06-07T01:50:03Z&se=2022-06-07T09:50:03Z&spr=https&sv=2020-08-04&sr=c&sig=ekN%2FabqgJrQdDVrK41rQAfnWhGWQrR8Yo4qZer7ouXI%3D>' 'https://<storagelabtenorio>.blob.core.windows.net/<container2>/<studyCMD.txt>'

            destination.StartCopyFromUri(source.Uri);
        }
    }
}