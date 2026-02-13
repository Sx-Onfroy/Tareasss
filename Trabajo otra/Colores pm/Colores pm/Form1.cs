namespace Colores_pm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Rojo");
            comboBox1.Items.Add("Verde");
            comboBox1.Items.Add("Azul");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                label1.Text = "Opción seleccionada: Opción 1";
            else if (radioButton2.Checked)
                label1.Text = "Opción seleccionada: Opción 2";
            else if (radioButton3.Checked)
                label1.Text = "Opción seleccionada: Opción 3";
            else
                label1.Text = "No seleccionaste ninguna opción";
        }
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Rojo")
                this.BackColor = Color.Red;
            else if (comboBox1.SelectedItem.ToString() == "Verde")
                this.BackColor = Color.Green;
            else if (comboBox1.SelectedItem.ToString() == "Azul")
                this.BackColor = Color.Blue;
        }

    }
}


