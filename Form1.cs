namespace Modul3_103022400073
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {

            string inNilaiAwalText = nilaiAwal.Text;

            if (satuanAwal.SelectedIndex == -1 || satuanAkhir.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }
            else if (string.IsNullOrEmpty(inNilaiAwalText))
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            string selectedSatuanAwal = satuanAwal.SelectedItem.ToString();
            int inNilaiAwal = int.Parse(inNilaiAwalText);
            int inCelcius = 0;

            switch (selectedSatuanAwal)
            {
                case "Celcius":
                    inCelcius = inNilaiAwal;
                    break;
                case "Fahrenheit":
                    inCelcius = (inNilaiAwal - 32) * 5 / 9;
                    break;
                case "Kelvin":
                    inCelcius = inNilaiAwal - 273;
                    break;
                case "Reamur":
                    inCelcius = inNilaiAwal * 5 / 4;
                    break;
                defauilt:
                    MessageBox.Show("Pilihan satuan tidak ada!");
                    return;
            }

            string selectedSatuanAkhir = satuanAkhir.SelectedItem.ToString();
            int convertResult = 0;
            switch (selectedSatuanAkhir)
            {
                case "Celcius":
                    convertResult = inCelcius;
                    break;
                case "Fahrenheit":
                    convertResult = 9 / 5 * inCelcius + 32;
                    break;
                case "Kelvin":
                    convertResult = inCelcius + 273;
                    break;
                case "Reamur":
                    convertResult = 4 / 5 * inCelcius;
                    break;
                defauilt:
                    MessageBox.Show("Pilihan satuan tidak ada!");
                    return;
            }

            nilaiAkhir.Text = convertResult.ToString();
        }


    }
}
