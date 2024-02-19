namespace GitDrive.Interfaces;

/// <summary>
/// Used to manage a git repository.
/// </summary>
public interface IDrive
{
    /// <summary>
    /// Create a commit.
    /// </summary>
    public void MakeBackup(string message);
    
    /// <summary>
    /// Get all commits in the repository
    /// </summary>
    public ICommit[] BackupPoints { get; }
    
    /// <summary>
    /// Checkout into a commit.
    /// </summary>
    /// <param name="commitHash">The hash of the commit to check out into.</param>
    public void Restore(string commitHash);
}