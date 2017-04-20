//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Micronet_User.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class CardDetail
    {


       [Required(ErrorMessage ="Enter Card No.")]
        [Display(Name = "Credit Card Number")]
       
        [Range(100000000000, 9999999999999999999, ErrorMessage = "Must be between 12 and 19 digits")]
        public long CardNo { get; set; }
        [Required(ErrorMessage ="Enter CVV No.")]
        [Display(Name = "CVV Number")]

        public string CVV_no { get; set; }


        [Display(Name = "Expiry Date")]

        [Required(ErrorMessage ="Enter Expiry Date")]
        public System.DateTime ExpiryDate { get; set; }

        [Display(Name = "Card Holder Name")]

        [Required(ErrorMessage ="Enter Name On Card")]
        public string NameOnCard { get; set; }
    }
}