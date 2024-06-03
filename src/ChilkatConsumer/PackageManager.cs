using System;

namespace ChilkatConsumer
{
    public class PackageManager
    {
        //Create a method which uses chilkat library to zip a list of file names received as input
        public void ZipFiles(string[] fileNames)
        {
            //Create a new zip object
            Chilkat.Zip zip = new Chilkat.Zip();

            //Set the zip file name
            zip.FileName = "output.zip";

            //Create a new zip file
            zip.NewZip(zip.FileName);

            //Add the files to the zip
            foreach (string fileName in fileNames)
            {
                zip.AppendOneFileOrDir(fileName, false);
            }

            //Write the zip file
            zip.WriteZipAndClose();
        }
    }
}
