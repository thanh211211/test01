using System;

namespace Halliburton.App.Core.SharedKernel
{
    [Serializable]
    public class BaseDTO
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
    }
}
