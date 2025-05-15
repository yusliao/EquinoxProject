using System;
using System.ComponentModel.DataAnnotations;

namespace Equinox.Application.ViewModels.Production
{
    public class CellPackagingViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "批次号是必需的")]
        [Display(Name = "批次号")]
        public string BatchNumber { get; set; }

        [Required(ErrorMessage = "电芯编码是必需的")]
        [Display(Name = "电芯编码")]
        public string CellCode { get; set; }

        [Required(ErrorMessage = "包装类型是必需的")]
        [Display(Name = "包装类型")]
        public string PackageType { get; set; }

        [Required(ErrorMessage = "数量是必需的")]
        [Range(1, int.MaxValue, ErrorMessage = "数量必须大于0")]
        [Display(Name = "数量")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "操作员ID是必需的")]
        [Display(Name = "操作员")]
        public string OperatorId { get; set; }

        [Required(ErrorMessage = "包装日期是必需的")]
        [Display(Name = "包装日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        public DateTime PackageDate { get; set; }

        [Required(ErrorMessage = "状态是必需的")]
        [Display(Name = "状态")]
        public string Status { get; set; }
    }
} 