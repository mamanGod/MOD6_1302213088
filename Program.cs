// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    public string Username { get; }

    private int id;
    string title;
    int playCount;
    int TotalVideoPLay;
    private List<SayaTubeVideo> uploadedVideos;
    string sayaTubeUser;

    public SayaTubeVideo(string a)
    {
        this.title = a;
        Random r = new Random();
        id = r.Next(10000, 99999);
        this.playCount = 0;
    }

    public void increasePlayCount(int pt)
    {
        this.playCount += pt;
    }

    public void printVideosDetails()
    {
        Console.WriteLine("id           : " + this.id);
        Console.WriteLine("title        : " + this.title);
        Console.WriteLine("playCount   :  " + this.playCount);
    }

    public sayaTubeUser(string username)
    {
        Debug.Assert(username != null);
        Debug.Assert(username.Length <= 100);
        Username = username;
        id = new Random().Next(10000, 100000);
        uploadedVideos= new List<SayaTubeVideo>();

        

    }

    public
}
