namespace MultiShop.Data
{
    public class Slider: BaseEntity, IOrder
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Image { get; set; }
        public int SliderPosition { get; set; }
        public DateTime CrationDate { get; set; }
        public int? Order { get; set ; }
    }   

}
