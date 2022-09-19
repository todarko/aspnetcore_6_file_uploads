using System.ComponentModel.DataAnnotations.Schema;

namespace UploadFiles.Data
{
    public class AppFile
    {
        public Guid? Id { get; set; } = null;
        public string Name { get; set; }
        [NotMapped]
        public virtual IFormFile? FormFile { get; set; } = null;
    }
    public class MultiAppFile
    {
        public string Name { get; set; }
        public List<IFormFile> Files { get; set; }
    }
}
