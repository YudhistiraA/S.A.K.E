namespace SAKEWeb.Models
{
    public class SakeViewModel
    {
        public string Nama { get; set; }
        public int Posisi { get; set; }
        public int Lembur { get; set; }

        public double TunjanganDasar { get; set; }
        public double BonusLembur { get; set; }
        public double TotalBonusAkhir { get; set; }
        public string StatusKinerja { get; set; }
    }
}
