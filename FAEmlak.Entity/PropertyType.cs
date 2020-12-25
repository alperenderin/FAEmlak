using System;
using System.ComponentModel.DataAnnotations;

namespace FAEmlak.Entity
{
    public enum PropertyType
    {
        [Display(Name = "Konut")]
        Residental = 0,
        [Display(Name = "İş Yeri")]
        Commercial,
        [Display(Name = "Arsa")]
        Land,
        [Display(Name = "Bina")]
        Buildings
    }
}
