namespace PostItSharp.Repositories;
public class AlbumsRepository : BaseRepository
{
  public AlbumsRepository(IDbConnection db) : base(db)
  {
  }

  internal Album CreateAlbum(Album newAlbum)
  {
    var sql = @"
    INSERT INTO albums(title, coverImg, creatorId, category)
    VALUES(@Title, @CoverImg, @CreatorId, @Category);
    SELECT LAST_INSERT_ID();
    ";
    int albumId = _db.ExecuteScalar<int>(sql, newAlbum);
    newAlbum.id = albumId;
    return newAlbum;
  }
}