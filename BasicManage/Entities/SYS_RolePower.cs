//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BasicManage.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class SYS_RolePower
    {
        [Key]
        public string PowerId { get; set; }
        public string RoleId { get; set; }
        public string NodeId { get; set; }
    }
}
