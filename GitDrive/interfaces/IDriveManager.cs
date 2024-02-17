namespace GitDrive;

public interface IDriveManager
{
    public string[] Drives { get; }
    public IDrive GetDriveByPath(string path);
    public IDrive GetDriveByIndex(int index);
}