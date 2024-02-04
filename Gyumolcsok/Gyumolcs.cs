namespace Gyumolcsok
{
    internal class Gyumolcs
    {
        private int id;
        private string name;
        private int quantity;

        public Gyumolcs()
        {
        }

        public Gyumolcs(int id, string name, int quantity)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}