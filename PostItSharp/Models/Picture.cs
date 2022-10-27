namespace PostItSharp.Models;

public class Picture : ICreated, IRepoItem<int>
{
  public string CreatorId { get; set; }
  public Profile Creator { get; set; }
  public int id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public string ImgUrl { get; set; }
  public int AlbumId { get; set; }
}
