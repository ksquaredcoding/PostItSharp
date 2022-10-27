namespace PostItSharp.Services;

public class AlbumsService
{
  private readonly AlbumsRepository _albumsRepo;

  public AlbumsService(AlbumsRepository albumsRepo)
  {
    _albumsRepo = albumsRepo;
  }

  internal Album CreateAlbum(Album newAlbum)
  {
    return _albumsRepo.CreateAlbum(newAlbum);
  }
}