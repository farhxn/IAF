//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace final.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class review
    {
        public int r_id { get; set; }
        [Display (Name = "Leave A Comment")]
        public string r_comment { get; set; }
        [Display(Name = "Picture")]
        public string r_picture { get; set; }
        [Display(Name = "Username")]
        public string r_username { get; set; }
    }
}
