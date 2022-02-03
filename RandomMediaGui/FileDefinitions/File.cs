namespace RandomMediaGui.FileDefinitions
{
    class File
    {
        protected string name;

        public File(string name) {
            this.name = name;
        }

        public string getAbsPath() {
            return name;
        }
    }
}
