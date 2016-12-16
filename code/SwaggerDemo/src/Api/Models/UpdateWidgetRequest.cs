namespace SwaggerDemo.Api.Models
{
    using System;

    public class UpdateWidgetRequest
    {
        public Color ButtonColor { get; set; }

        public DateTimeOffset? Deactivated { get; set; }

        public string Name { get; set; }

        public int GearCount { get; set; }

        public int SpinnerCount { get; set; }
    }
}