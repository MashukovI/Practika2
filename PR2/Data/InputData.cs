namespace PR2.Data
{
    public class InputData
    {
        public int id {  get; set; }

        public string name { get; set; }

        public double Layer_H { get; set; }

        public double T_material { get; set; }

        public double T_gas { get; set; }

        public double V_gas { get; set; }

        public double C_gas { get; set; }

        public double Consum { get; set; }

        public double C_material { get; set; }

        public double Koef { get; set; }

        public double Diam { get; set; }

        public int? UserId { get; set; }

        public DateTime DateAdd { get; set; }

    }
}
