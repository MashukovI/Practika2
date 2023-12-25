namespace PR2Library1
{
    public class PR2Lib
    {
        public PR2OutputData Calc(PR2InputData data)
        {
            var rows = new List<PR2OutputRow>();
            var rows1 = new List<PR2OutputRow>();


            double m = Math.Round((data.C_material * data.Consum) / (data.C_gas * data.V_gas * 3.14 * (Math.Pow(data.Diam / 2, 2))), 4);

            double y0 = Math.Round((data.Koef * data.Layer_H) / (data.V_gas * data.C_gas * 1000), 4);

            double Y0 = Math.Round(1 - (m * Math.Exp(((m - 1) * y0) / m)), 4);

        
            for (double i = 0; i <= data.Layer_H; i += 0.5)
            {
                double Y = Math.Round(((data.Koef * i) / (data.V_gas * data.C_gas * 1000)), 4);
                double exp1 = Math.Round(1 - Math.Exp(((m - 1) * Y) / m), 4);
                double mexp = Math.Round(1 - m * Math.Exp(((m - 1) * Y) / m), 4);
                double B = Math.Round(exp1/(1 - m * Math.Exp(((m - 1) * y0) / m)), 4);
                double O = Math.Round(mexp / (1 - m * Math.Exp(((m - 1) * y0) / m)), 4);
                double t = Math.Round(data.T_material + (data.T_gas - data.T_material) * B, 0);
                double T = Math.Round(data.T_material + (data.T_gas - data.T_material) * O, 0);
                double Tnt = Math.Abs(T - t);

                rows.Add(new PR2OutputRow { 
                    X = i,                  
                    tmal = t,
                    Tbol = T,
                    Tnt = Tnt

                });
            }


            return new PR2OutputData

            {
                Rows = rows,
                
                Proizv = Y0
            };
                
        }
    }
}
