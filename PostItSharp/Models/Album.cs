namespace PostItSharp.Models;

public class Album : ICreated, IRepoItem<int>
{
  public string CreatorId { get; set; }
  public Profile Creator { get; set; }
  public int id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public string Title { get; set; }
  public string CoverImg { get; set; }
  public string Category { get; set; }
  public bool Archived { get; set; }
}