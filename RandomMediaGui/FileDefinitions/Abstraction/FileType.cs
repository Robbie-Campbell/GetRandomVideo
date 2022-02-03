namespace RandomMediaGui.FileDefinitions.Abstraction
{
    public abstract class FileType
    {
        private string name;
        private string formats;

        protected void setName(string name) {
            this.name = name;
        }
        
        protected void setFormats(string formats) {
            this.formats = formats;
        }

        public string getName() {
            return name;
        }

        public string getFormats() {
            return formats;
        }
    }
}
