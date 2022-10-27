namespace PostItSharp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlbumsController : ControllerBase
{
  private readonly Auth0Provider _auth0Provider;
  private readonly AlbumsService _albumsService;

  public AlbumsController(Auth0Provider auth0Provider, AlbumsService albumsService)
  {
    _auth0Provider = auth0Provider;
    _albumsService = albumsService;
  }

  [HttpPost]
  [Authorize]
  public async Task<ActionResult<Album>> CreateAlbum([FromBody] Album newAlbum)
  {
    try
    {
      Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      newAlbum.CreatorId = userInfo.Id;
      Album createdAlbum = _albumsService.CreateAlbum(newAlbum);
      createdAlbum.Creator = userInfo;
      return Ok(createdAlbum);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

}