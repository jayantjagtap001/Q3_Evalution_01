public class FileCompressor
{
    public void Compress(string textFile)
    {
        Console.WriteLine($"Compressing text file: {textFile}");
    }

    public void Compress(byte[] imageData)
    {
        Console.WriteLine("Compressing image data.");
    }

    public void Compress(VideoFile video)
    {
        Console.WriteLine($"Compressing video file: {video.FileName}");
    }
}

public class VideoFile
{
    public string FileName { get; set; }
    public VideoFile(string fileName)
    {
        FileName = fileName;
    }
}

public class CompressorTest
{
   public static void Main(string[] args)
    {
        FileCompressor compressor = new FileCompressor();

        compressor.Compress("document.txt");

        byte[] imageData = new byte[100];
        compressor.Compress(imageData);

        VideoFile video = new VideoFile("movie.mp4");
        compressor.Compress(video);
    }
}
