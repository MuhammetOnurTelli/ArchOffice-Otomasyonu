using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchOffice
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VeritabaniKurulum.Hazirla();
            Veriler.VarsayilanYoneticiEkle();
            Veriler.EksikMusterileriEkle();
            Veriler.VarsayilanMimarEkle();
            Veriler.VarsayilanMalzemeleriEkle();
            Application.Run(new Formlar.GirisForm());
        }
    }
}
