using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SkillTreeHomework.ViewModels.Home
{
    public class IndexViewModel
    {
        /// <summary>
        /// 收支類型
        /// </summary>
        public Type Type { get; set; }
        /// <summary>
        /// 收支紀錄
        /// </summary>
        public List<BillingData> BillingDatas { get; set; } = new List<BillingData>();
    }

    /// <summary>
    /// 收支紀錄
    /// </summary>
    public class BillingData
    {
        /// <summary>
        /// 收支類別
        /// </summary>
        public Type Type { get; set; }
        /// <summary>
        /// 收支日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 收支金額
        /// </summary>
        public int Amount { get; set; }
    }

    /// <summary>
    /// 收支類型
    /// </summary>
    public enum Type
    {
        [Display(Name = "請選擇")]
        請選擇 = 0,
        [Display(Name = "支出")]
        支出,
        [Display(Name = "收入")]
        收入
    }
}