using System;

namespace Donut.Core.SharedKernel
{
    public abstract class AggregateRoot : BaseEntity
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public void UpdateAudit(int userId)
        {
            if (Id > 0)
            {
                UpdatedBy = userId;
                UpdatedDate = DateTime.UtcNow;
            }
            else
            {
                CreatedBy = userId;
                CreatedDate = DateTime.UtcNow;
            }
        }
    }
}
