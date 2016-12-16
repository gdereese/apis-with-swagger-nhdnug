namespace SwaggerDemo.Api.Models
{
    public class CreateWidgetRequest
    {
        public Color ButtonColor { get; set; }

        public string Name { get; set; }

        public int GearCount { get; set; }

        public int SpinnerCount { get; set; }
    }
}