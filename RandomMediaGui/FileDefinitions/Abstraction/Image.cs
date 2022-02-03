namespace RandomMediaGui.FileDefinitions.Abstraction
{
    class ImageFile : FileType
    {
        public ImageFile() {
            setName("ImageFile");
            string formats = "*.jpg, *.png";
            setFormats(formats);
        }
    }
}
