//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Poprigunchick.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AgentPriorityHistory
    {
        public int ID { get; set; }
        public int AgentID { get; set; }
        public System.DateTime ChangeDate { get; set; }
        public int PriorityValue { get; set; }
    
        public virtual Agent Agent { get; set; }
    }
}
