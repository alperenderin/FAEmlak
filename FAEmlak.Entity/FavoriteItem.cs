using System;
using System.Collections.Generic;
using System.Text;

namespace FAEmlak.Entity
{
    public class FavoriteItem
    {
        public int FavoriteItemId { get; set; }
        public string UserId { get; set; }
        public int PropertyId { get; set; }
        public Property Property { get; set; }
    }
}
