//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetWalletData
    {
        public int Id { get; set; }
        public string user_id { get; set; }
        public string address { get; set; }
        public string label { get; set; }
        public string available_balance { get; set; }
        public string pending_received_balance { get; set; }
        public string is_segwit { get; set; }
        public Nullable<bool> is_requested { get; set; }
        public string message { get; set; }
    }
}
