//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webAppDevi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BikeBrand
    {
        public BikeBrand()
        {
            this.BikePhotos = new HashSet<BikePhoto>();
        }
    
        public int BikeBrandId { get; set; }
        public string BikeBrandName { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual ICollection<BikePhoto> BikePhotos { get; set; }
    }
}
