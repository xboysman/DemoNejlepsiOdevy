using System;

namespace DemoNejlepsiOdevy.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public DateTime VisitDateTime { get; set; }
        public int Age { get; set; }
        public bool WasSatisfied { get; set; }
        public char Sex { get; set; }
    }
}
