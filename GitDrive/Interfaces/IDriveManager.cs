namespace GitDrive.Interfaces;

/// <summary>
/// Manages the initialization of new <see cref="IDrive"/> instances.
/// </summary>
public interface IDriveManager
{
    /// <summary>
    /// Get all available repository paths.
    /// </summary>
    public string[] Drives { get; }
    
    /// <summary>
    /// Get an <see cref="IDrive"/> instance for a Drive by path. 
    /// </summary>
    /// <param name="path">The path to the git repository.</param>
    /// <returns>Instance of <see cref="IDrive"/></returns>
    public IDrive GetDriveByPath(string path);
    
    /// <summary>
    /// Get an <see cref="IDrive"/> instance for a Drive by id. 
    /// </summary>
    /// <param name="id">The id of the Drive.</param>
    /// <returns>Instance of <see cref="IDrive"/></returns>
    public IDrive GetDriveByIndex(int id);
}