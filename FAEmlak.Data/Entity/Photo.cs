using System;
using System.ComponentModel.DataAnnotations;

namespace FAEmlak.Data
{
    public class Photo
    {
        [Key]
        public long PhotoId { get; set; }
        public string PhotoPath { get; set; }
        public int PropertyId{ get; set; }
        public Property Property { get; set; }
        public bool IsDefault { get; set; }
    }
}
