using System;
using System.Collections.Generic;
using RandomMediaGui.FileDefinitions.Abstraction;

namespace RandomMediaGui.FileDefinitions.Implementation
{
    class FileList
    {
        private List<File> files;

        public FileList(string path, FileType file) {
            files = new SearchDirectory(path, file).getAppropriateFilesInDir();
        }

        public string getRandomFile() {
            Random random = new Random();
            int size = files.Count;
            return size > 0 ? files[random.Next(0, size)].getAbsPath() : "No Results Found";
        }
    }
}
