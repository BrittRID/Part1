namespace ContactsWebApp.Models
{
    public class Contacts
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Sphere { get; set; }
        public string Cylinder { get; set; }
        public string Axis { get; set; }
        public string BaseCurve { get; set; }
        public double Dia { get; set; }

        //Can not add a plus or minus symbol 
       public string MF { get; set; }
        public Contacts()
        {

        }
       

    }
}
