using System;
using System.Linq;
using System.Threading.Tasks;
using Dropbox.Api;
using System.IO;
using Dropbox.Api.Files;
using Aspose.Zip;

namespace DownloadAFile
{
    /// <summary>
    /// This program will teach you how to download files from dropbox account
    /// </summary>
    class Program
    {
        static readonly string token = "k3hxVmw2r4gAAAAAAAAAAXs_1DtXrPtn75RwUX0IZhAKr7toz44nRD3DxJPTrZgt41";
        static readonly string dbx_source_folder = "/CSI/XiaoMaGeDecode/encrypted";
        static readonly string dbx_destination_folder = "/CSI/XiaoMaGeDecode/decrypted";
        static readonly string unzipped_folder = "Unzipped Files";
        static readonly string zipped_folder = "Zipped Files";

        static void Main(string[] args)
        {
            var task = Task.Run((Func<Task>)Program.Run);
            task.Wait();
        }
        static async Task Run()
        {
            // 0. If zipped_folder does not exist, create such folder
            Directory.CreateDirectory(zipped_folder);

            // 1.Download encrypted files from DBX
            using (var dbx = new DropboxClient(token))
            {
                var list = await dbx.Files.ListFolderAsync(dbx_source_folder);
                foreach (var item in list.Entries.Where(i => i.IsFile))
                {
                    Console.WriteLine("F{0,8} {1}", item.AsFile.Size, item.Name);
                    using (var response = await dbx.Files.DownloadAsync(dbx_source_folder + "/" + item.Name))
                    {
                        var s = response.GetContentAsByteArrayAsync();
                        s.Wait();
                        var d = s.Result;
                        File.WriteAllBytes(zipped_folder + "/" + item.Name, d);
                    }
                }
            }

            // 2. Decode encrypted files into decrypted files
            DirectoryInfo TheZippedFolder = new DirectoryInfo(zipped_folder);
            foreach (FileInfo NextFile in TheZippedFolder.GetFiles())
                using (FileStream zipFile = File.Open(zipped_folder + "/" + NextFile.Name, FileMode.Open))
                using (var archive = new Archive(zipFile, new ArchiveLoadOptions() { DecryptionPassword = "biaoge_ceph" }))
                    archive.ExtractToDirectory(unzipped_folder);

            // 3. Upload the decrypted files to the DBX
            DirectoryInfo TheUnZippedFolder = new DirectoryInfo(unzipped_folder);
            using (var dbx = new DropboxClient(token))
                foreach (FileInfo NextFile in TheUnZippedFolder.GetFiles())
                    using (var mem = new MemoryStream(File.ReadAllBytes(unzipped_folder + "/" + NextFile.Name)))
                        dbx.Files.UploadAsync(dbx_destination_folder + "/" + NextFile.Name, WriteMode.Overwrite.Instance, body: mem).Wait();
        }
    }
}
