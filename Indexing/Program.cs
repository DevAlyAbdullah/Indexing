// This Application should rename all folder's files to a specific name and numbers
// example name_01, name_02, etc ...

string directory = "D:\\Media\\Gallery\\Images\\Background";
string[] filesNames = Directory.GetFiles(directory);
string newFileName = "\\bg";
string dotJPG = ".jpg";
string dotPNG = ".png";


int i = 1;
foreach (string fileName in filesNames)
{
    string loweredFileName = fileName.ToLower();
    if (loweredFileName.EndsWith(dotJPG))
    {
        if (i < 10)
        {
            File.Move(loweredFileName, directory + newFileName + "_00" + i + dotJPG);
        }
        else if (i >= 10)
        {
            File.Move(loweredFileName, directory + newFileName + "_0" + i + dotJPG);
        }
        else if (i >= 100)
        {
            File.Move(loweredFileName, directory + newFileName + "_" + i + dotJPG);
        }
        i++;
    }
    else if (loweredFileName.EndsWith(dotPNG))
    {
        if (i < 10)
        {
            File.Move(loweredFileName, directory + newFileName + "_00" + i + dotPNG);
        }
        else if (i >= 10)
        {
            File.Move(loweredFileName, directory + newFileName + "_0" + i + dotPNG);
        }
        else if (i >= 100)
        {
            File.Move(loweredFileName, directory + newFileName + "_" + i + dotPNG);
        }
        i++;
    }
}

Console.WriteLine($"You have successfully edited {i} files");