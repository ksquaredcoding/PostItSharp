namespace PostItSharp.Interfaces;

public interface IRepoItem<T>
{
  T id { get; set; }
  DateTime CreatedAt { get; set; }
  DateTime UpdatedAt { get; set; }
}