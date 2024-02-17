namespace GitDrive;

public interface IDrive
{
    public void MakeBackup();
    public ICommit[] BackupPoints { get; }
    public void Restore(string commitHash);
}