using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnosticoTecnicoBasico.Common
{
    public static class Utilities
    {
        private static int seed = Environment.TickCount;
        private static Random r = new Random(seed);

        public static string GenerarIdUnicoDiagnostico()
        {
            string idUnico = DateTime.Now.Year.ToString() +
                             DateTime.Now.Month.ToString().PadLeft(2, '0') +
                             DateTime.Now.Day.ToString().PadLeft(2, '0') +
                             DateTime.Now.Hour.ToString().PadLeft(2, '0') +
                             DateTime.Now.Minute.ToString().PadLeft(2, '0') +
                             DateTime.Now.Second.ToString().PadLeft(2, '0') +
                             r.Next(0001, 9999).ToString().PadLeft(4, '0') +
                             r.Next(0001, 9999).ToString().PadLeft(4, '0');

            return idUnico;
        }
    }
}
