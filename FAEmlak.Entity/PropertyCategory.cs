using System;
using System.ComponentModel.DataAnnotations;

namespace FAEmlak.Entity
{
    public enum PropertyCategory
    {
        [Display(Name = "Satılık")]
        ForSale = 0,
        [Display(Name = "Kiralık")]
        ForRent,
        [Display(Name = "Günlük Kiralık")]
        DailyRental
    }
}
