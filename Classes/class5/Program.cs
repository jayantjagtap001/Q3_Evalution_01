using System;

public class MusicPlaylist
{
    private class SongNode
    {
        public string Song { get; set; }
        public SongNode Next { get; set; }
        public SongNode Prev { get; set; }

        public SongNode(string song)
        {
            Song = song;
            Next = null;
            Prev = null;
        }
    }

    private SongNode head;
    private SongNode tail;
    private SongNode current;

    public MusicPlaylist()
    {
        head = null;
        tail = null;
        current = null;
    }

    public void AddSong(string song)
    {
        SongNode newNode = new SongNode(song);
        if (head == null)
        {
            head = tail = current = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
    }

    public void RemoveCurrentSong()
    {
        if (current == null)
        {
            Console.WriteLine("No song is currently playing.");
            return;
        }

        if (current == head) head = current.Next;
        if (current == tail) tail = current.Prev;

        if (current.Prev != null) current.Prev.Next = current.Next;
        if (current.Next != null) current.Next.Prev = current.Prev;

        Console.WriteLine($"Removed: {current.Song}");
        current = current.Next ?? head;
    }

    public void PlayNext()
    {
        if (current?.Next != null)
        {
            current = current.Next;
            Console.WriteLine($"Playing next: {current.Song}");
        }
        else
        {
            Console.WriteLine("No next song to play.");
        }
    }

    public void PlayPrevious()
    {
        if (current?.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine($"Playing previous: {current.Song}");
        }
        else
        {
            Console.WriteLine("No previous song to play.");
        }
    }

    public void ShowPlaylist()
    {
        var temp = head;
        Console.WriteLine("Playlist:");
        while (temp != null)
        {
            Console.WriteLine($"- {temp.Song}");
            temp = temp.Next;
        }
    }

    public static void Main(string[] args)
    {
        MusicPlaylist playlist = new MusicPlaylist();
        playlist.AddSong("Song A");
        playlist.AddSong("Song B");
        playlist.AddSong("Song C");

        playlist.ShowPlaylist();

        playlist.PlayNext();
        playlist.RemoveCurrentSong();
        playlist.ShowPlaylist();
        playlist.PlayPrevious();
    }
}
