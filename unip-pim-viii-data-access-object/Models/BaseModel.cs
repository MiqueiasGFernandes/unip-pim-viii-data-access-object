using System.ComponentModel.DataAnnotations;

namespace unip_pim_viii_data_access_object.Models
{
    public abstract class BaseModel
    {
        [Key]
        public int id { get; set; }
    }
}
