namespace RandomMediaGui.FileDefinitions.Abstraction
{
    class Video : FileType
    {
        public Video() {
            setName("Video");
            string formats = "*.mp4, *.wav" ;
            setFormats(formats);
        }
    }
}
