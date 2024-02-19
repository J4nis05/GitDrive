namespace GitDrive.Interfaces;

/// <summary>
/// Represents a git commit.
/// </summary>
public interface ICommit
{
    /// <summary>
    /// The message of the commit
    /// </summary>
    public string Message { get; internal init; }
    
    /// <summary>
    /// The git commit hash.
    /// </summary>
    public string Hash { get; internal init; }
    
    /// <summary>
    /// The Time the commit was made.
    /// </summary>
    public DateTime TimeStamp { get; internal init; }
}