using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Toy
{
    public class Toy
    {

        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }


        private string Notes;


        public override string ToString()
        {
            return $"{Name} is manufactured by {Manufacturer} and costs {Price.ToString("C")} and can be found on aisle {GetAisle()}. {GetNotes()}";
        }

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = "";
            Price = 0;
            Notes = string.Empty;
        }

        public Toy(string notes)
        {
            Manufacturer = string.Empty;
            Name = "";
            Price = 0;
            Notes = notes;
        }

        public string GetNotes()
        {
            return Notes;
        }

        public void AddNote(string note)
        {
            Notes += "\n" + note;
        }

        public string GetAisle()
        {
            string aisle;
            Random rand = new Random();
            aisle = "" + Manufacturer.ToUpper()[0] + rand.Next(1, 25);

            return aisle;
        }

    }

}

