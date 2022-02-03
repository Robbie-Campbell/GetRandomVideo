namespace RandomMediaGui.FileDefinitions.Abstraction
{
    class Word : FileType
    {
        public Word() {
            setName("Word");
            string formats = "*.docx";
            setFormats(formats);
        }
    }
}
