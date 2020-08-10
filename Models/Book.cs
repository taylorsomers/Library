using System.Collections.Generic;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.Authors = new HashSet<Author>();
      this.Copies = new HashSet<Copy>();
      this.CopyCount = this.Copies.Count;
    }

    public int BookId { get; set; }

    public int CopyCount { get; set; }

    public string BookTitle { get; set; }

    public string BookGenre { get; set; }

    public virtual ICollection<Author> Authors { get; set; }

    public virtual ICollection<Copy> Copies { get; set; }
  }
}