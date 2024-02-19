namespace GitDrive.Interfaces;

internal interface IStorage
{
    internal bool AddDrive(string path);
    internal string[] GetAvailableDrives();
}