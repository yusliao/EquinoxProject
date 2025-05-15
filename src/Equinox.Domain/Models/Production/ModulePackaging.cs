using System;
using NetDevPack.Domain;

namespace Equinox.Domain.Models.Production
{
    public class ModulePackaging : Entity, IAggregateRoot
    {
        public ModulePackaging(Guid id, string batchNumber, string moduleCode,
            string packCode, string packageType, int quantity, string operatorId,
            DateTime packageDate, string status)
        {
            Id = id;
            BatchNumber = batchNumber;
            ModuleCode = moduleCode;
            PackCode = packCode;
            PackageType = packageType;
            Quantity = quantity;
            OperatorId = operatorId;
            PackageDate = packageDate;
            Status = status;
        }

        // Empty constructor for EF
        protected ModulePackaging() { }

        public string BatchNumber { get; private set; }
        public string ModuleCode { get; private set; }
        public string PackCode { get; private set; }
        public string PackageType { get; private set; }
        public int Quantity { get; private set; }
        public string OperatorId { get; private set; }
        public DateTime PackageDate { get; private set; }
        public string Status { get; private set; }

        // 业务规则验证
        public bool IsValid()
        {
            return !string.IsNullOrEmpty(BatchNumber)
                && !string.IsNullOrEmpty(ModuleCode)
                && !string.IsNullOrEmpty(PackCode)
                && Quantity > 0;
        }
    }
} 