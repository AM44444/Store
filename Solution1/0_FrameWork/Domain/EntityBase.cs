using System;
using System.Runtime.InteropServices.ComTypes;

namespace _0_FrameWork.Domain
{
    public class EntityBase
    {
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }

        public EntityBase()
        {
            CreationDate = DateTime.Now;
        }
    }
}
