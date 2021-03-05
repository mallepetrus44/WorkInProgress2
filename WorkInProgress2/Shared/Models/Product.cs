using System;
using System.ComponentModel.DataAnnotations;
using WorkInProgress2.Shared.Models.ProductExtra;

namespace WorkInProgress2.Shared.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "Naam product")]
        public string ProductName { get; set; }
        [Display(Name = "Aanmaakdatum")]
        public DateTime DateAdded { get; set; }


        /// <summary>
        /// All TABS => ProductExtra(s)
        /// </summary>
        /// 

        public AssortimentCode AssortimentCode { get; set; }
        public BorgingListeria BorgingListeria { get; set; }
        public Briefing Briefing { get; set; }
        public Comments Comments { get; set; }
        public ComponentNumberFood ComponentNumberFood { get; set; }
        public ComponentNumberPressed ComponentNumberPressed { get; set; }
        public DangerInProces DangerInProces { get; set; }
        public DesignStatus DesignStatus { get; set; }
        public Finnished Finnished { get; set; }
        public FoodProductNumber FoodProductNumber { get; set; }
        public GS1_Xxtract GS1_Xxtract { get; set; }
        public IntroWeek IntroWeek { get; set; }
        public LabelInfo LabelInfo { get; set; }
        public NoodEtiket NoodEtiket { get; set; }
        public Order Order { get; set; }
        public PO_ReceptCheck PO_ReceptCheck { get; set; }
        public PressStatus PressStatus { get; set; }
        public QA_AkkoordRB QA_AkkoordRB { get; set; }
        public QA_Check QA_Check { get; set; }
        public StatusColumn1 Status1 { get; set; }
        public StatusColumn2 Status2 { get; set; }
        public StatusStansmes StatusMes { get; set; }

    }
}
   