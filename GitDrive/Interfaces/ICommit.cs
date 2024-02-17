namespace GitDrive.Interfaces;

/// <summary>
/// Represents a git commit.
/// </summary>
public interface ICommit
{
    /// <summary>
    /// The message of the commit
    /// </summary>
    public string Message { init; get; }
    
    /// <summary>
    /// The git commit hash.
    /// </summary>
    public string Hash { init; get; }
    
    /// <summary>
    /// The Time the commit was made.
    /// </summary>
    public DateTime TimeStamp { init; get; }
}