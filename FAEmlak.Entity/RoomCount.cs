using System;
using System.ComponentModel.DataAnnotations;

namespace FAEmlak.Entity
{
    public enum RoomCount
    {
        [Display(Name = "1+0")]
        One = 0,
        [Display(Name = "1+1")]
        OnePlusOne,
        [Display(Name = "2+1")]
        TwoPlusOne,
        [Display(Name = "3+1")]
        ThreePlusOne,
        [Display(Name = "4+1")]
        FourPlusOne
    }
}
