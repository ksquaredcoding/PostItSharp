namespace PostItSharp.Models;

public class AlbumMember : IRepoItem<int>
{
  public int id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public string AccountId { get; set; }
  public int AlbumId { get; set; }
}