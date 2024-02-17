namespace GitDrive;

public interface ICommit
{
    public string Name { init; get; }
    public string Hash { init; get; }
    public DateTime TimeStamp { init; get; }
}