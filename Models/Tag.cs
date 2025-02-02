using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PageEF.Models{

[Table ("Tag")]
public class Tag{

    public int Id {get; set;}
    public string Name {get; set;}
    public string Slug {get; set;}

}
}