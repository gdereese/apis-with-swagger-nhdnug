namespace SwaggerDemo.Api.Controllers
{
    using System;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Models;

    [Route("Widgets")]
    public class WidgetController : Controller
    {
        [HttpPost]
        public IActionResult Create(CreateWidgetRequest widget)
        {
            if (!this.ModelState.IsValid)
                return this.BadRequest(this.ModelState);

            var random = new Random();
            var newWidget = new Widget
            {
                ButtonColor = widget.ButtonColor,
                Name = widget.Name,
                Deactivated = null,
                GearCount = widget.GearCount,
                ID = random.Next(),
                SpinnerCount = widget.SpinnerCount
            };

            return this.CreatedAtRoute("GetWidget", new {id = newWidget.ID}, newWidget);
        }

        [HttpGet("{id:int}", Name = "GetWidget")]
        public IActionResult Get(int id)
        {
            if (!this.ModelState.IsValid)
                return this.BadRequest(this.ModelState);

            var random = new Random();
            return this.Ok(new Widget
            {
                ButtonColor = Color.Black, 
                Name = "Whatchamacallit", 
                Deactivated = null,
                GearCount = random.Next(), 
                ID = random.Next(),
                SpinnerCount = random.Next()
            });
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var random = new Random();
            var widgets = Enumerable.Range(1, 10).Select(n => new Widget
            {
                ButtonColor = (Color)random.Next(1, 7), 
                Deactivated = DateTimeOffset.FromUnixTimeMilliseconds(new Random().Next()),
                GearCount = random.Next(),
                ID = random.Next(),
                Name = $"Widget {n}",
                SpinnerCount = random.Next()
            });

            return this.Ok(widgets);
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(UpdateWidgetRequest widget)
        {
            if (!this.ModelState.IsValid)
                return this.BadRequest(this.ModelState);

            return this.NoContent();
        }
    }
}