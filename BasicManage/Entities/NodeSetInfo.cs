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

    public partial class NodeSetInfo
    {
        [Key]
        public string Id { get; set; }
        public string NodeName { get; set; }
        public string NodeUrl { get; set; }
        public string NodeType { get; set; }
        public string ParentNode { get; set; }
        public Nullable<int> NodeNum { get; set; }
        public string Status { get; set; }
    }
}
