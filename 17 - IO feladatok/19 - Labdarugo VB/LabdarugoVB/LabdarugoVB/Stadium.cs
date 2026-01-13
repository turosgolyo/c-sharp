namespace LabdarugoVB;

public class Stadium
{
        public string City { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public int Capacity { get; set; }

        public Stadium(string row)
        {
            string[] data = row.Split(';');
            City = data[0];
            Name1 = data[1];
            Name2 = data[2];
            Capacity = int.Parse(data[3]);
        }
    }