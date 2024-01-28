namespace Secundus_API.Entities;

public class Game
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public required int SondreScore { get; set; }
    public required int ErnstScore { get; set; }
    public required int PetterScore { get; set; }
}
