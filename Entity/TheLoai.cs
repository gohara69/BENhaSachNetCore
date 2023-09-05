using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NhaSachDotNet.Entity
{
    public class TheLoai
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string tenTheLoai { get; set; }

        public virtual ICollection<Sachs> dsSach { get; set; }
    }
}
