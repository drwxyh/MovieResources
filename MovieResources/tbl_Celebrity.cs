//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieResources
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Celebrity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Celebrity()
        {
            this.tbl_MarkCeleb = new HashSet<tbl_MarkCeleb>();
            this.tbl_Work = new HashSet<tbl_Work>();
        }
    
        public string celeb_Id { get; set; }
        public string celeb_Name { get; set; }
        public string celeb_Aka { get; set; }
        public string celeb_NameEn { get; set; }
        public string celeb_AkaEn { get; set; }
        public string celeb_Gender { get; set; }
        public string celeb_Pro { get; set; }
        public string celeb_Birthday { get; set; }
        public string celeb_Deathday { get; set; }
        public string celeb_BornPlace { get; set; }
        public string celeb_Family { get; set; }
        public string celeb_Avatar { get; set; }
        public string celeb_Works { get; set; }
        public string celeb_DoubanID { get; set; }
        public string celeb_IMDbID { get; set; }
        public string celeb_Summary { get; set; }
        public string celeb_Create { get; set; }
        public Nullable<byte> celeb_Status { get; set; }
        public string celeb_Note { get; set; }
        public Nullable<System.DateTime> celeb_Time { get; set; }
        public Nullable<System.DateTime> celeb_AlterTime { get; set; }
    
        public virtual tbl_UserAccount tbl_UserAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MarkCeleb> tbl_MarkCeleb { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Work> tbl_Work { get; set; }
    }
}