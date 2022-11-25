namespace firstMVCproject.Models
{
    public class Pens
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public static List<Pens> PensList = new List<Pens>();

        public Pens() { }
        public Pens(int id, string name, float price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public static  List<Pens> getPens()
        {
            Pens p1 = new Pens();

            p1.Id = 100;
            p1.Name = "Parker";
            p1.Price = 90;
            PensList.Add(p1);

            Pens p2 = new Pens();
            p2.Id = 102;
            p2.Name = "Hero";
            p2.Price = 100;
            PensList.Add(p2);

            Pens p3 = new Pens();
            p3.Id = 104;
            p3.Name = "Fountain";
            p3.Price = 70;
            PensList.Add(p3);

            Pens p4 = new Pens();
            p4.Id = 105;
            p4.Name = "Bigtank";
            p4.Price = 190;
            PensList.Add(p4);

            return PensList;
        }
    }
}
