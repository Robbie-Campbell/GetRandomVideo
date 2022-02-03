using System.IO;
using System.Collections.Generic;
using System.Linq;
using RandomMediaGui.FileDefinitions.Abstraction;

namespace RandomMediaGui.FileDefinitions.Implementation
{
    class SearchDirectory
    {
        protected string path;
        protected FileType file;

        public SearchDirectory(string path, FileType file) {
            this.path = path;
            this.file = file;
        }

        public List<File> getAppropriateFilesInDir() {
            List<File> returnVal = new List<File>();
            foreach (string path in Directory.GetFiles(this.path, "*.*", SearchOption.AllDirectories).Where(s => file.getFormats().Contains(Path.GetExtension(s).ToLower()))){
                returnVal.Add(new File(path));
            }
            return returnVal;
        }
    }
}
