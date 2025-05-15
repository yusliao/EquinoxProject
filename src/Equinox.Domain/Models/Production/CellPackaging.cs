using System;
using NetDevPack.Domain;

namespace Equinox.Domain.Models.Production
{
    public class CellPackaging : Entity, IAggregateRoot
    {
        public CellPackaging(Guid id, string batchNumber, string cellCode, 
            string packageType, int quantity, string operatorId, 
            DateTime packageDate, string status)
        {
            Id = id;
            BatchNumber = batchNumber;
            CellCode = cellCode;
            PackageType = packageType;
            Quantity = quantity;
            OperatorId = operatorId;
            PackageDate = packageDate;
            Status = status;
        }

        // Empty constructor for EF
        protected CellPackaging() { }

        public string BatchNumber { get; private set; }
        public string CellCode { get; private set; }
        public string PackageType { get; private set; }
        public int Quantity { get; private set; }
        public string OperatorId { get; private set; }
        public DateTime PackageDate { get; private set; }
        public string Status { get; private set; }

        // 业务规则验证
        public bool IsValid()
        {
            return !string.IsNullOrEmpty(BatchNumber) 
                && !string.IsNullOrEmpty(CellCode)
                && Quantity > 0;
        }
    }
} 