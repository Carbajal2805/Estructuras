namespace PruebaSistematica
{
    public partial class Form1 : Form
    {
        int i ;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int precio = 0;
            string categoria= "";
            string tipo = cboTipo.Text;
            switch (tipo)
            {
                case "03-12":
                    precio = 10;
                    categoria = "NIÑO";
                    break;
                case "13-59":
                    precio = 25;
                    categoria = "ADULTO";
                    break;
                case "60++":
                    precio = 20;
                    categoria = "Tercera Edad";
                    break;
            }
            ListViewItem fila = new ListViewItem(categoria);
            fila.SubItems.Add(precio.ToString("0.00"));
            lvMostrar.Items.Add(fila);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Capturando los Datos
            int cantidad = int .Parse(txtCantidad.Text);
            string tipo = cboTipo.Text;
             string categoria = "";
            int precio = 0;
            double descuento = 0;
            switch (tipo)
            {
                case "03-12": precio = 10;
                    descuento = 20.0/ 100;
                    categoria = "Niño";

                    break;
                case "13-59": precio = 25;
                    descuento = 5.0 / 100;
                    categoria = "Adulto";
                    break;
                case "60++": precio = 15;
                    descuento = 10.0 / 100;
                    categoria ="Tercera Edad";
                    break;
            } double subTotal = precio * cantidad;
            double descount = subTotal * descuento;
            double montoTotal = subTotal - descount;
            ListViewItem fila1 = new ListViewItem(categoria);
            fila1.SubItems.Add(precio.ToString());
            fila1.SubItems.Add(cantidad.ToString());
            fila1.SubItems.Add(subTotal.ToString());
            fila1.SubItems.Add(descount.ToString());
            fila1.SubItems.Add(montoTotal.ToString());
            lvDatos.Items.Add(fila1);

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            double totalNeto = 0;
            for ( i = 0; i < lvDatos.Items.Count; i++)
            {
                if (lvDatos.Items[i].SubItems[0].Text != null)
                {
                    totalNeto += double.Parse(lvDatos.Items[i].SubItems[3].Text);
                }
            }
            i = 0;
            double totalDescuento = 0;
            while (i < lvDatos.Items.Count)
            {
                totalDescuento += double.Parse(lvDatos.Items[i].SubItems[4].Text);
                i++;
            }
            ListViewItem fila = new ListViewItem(totalNeto.ToString("0.00"));
            fila.SubItems.Add(totalDescuento.ToString("0.00"));
            lvMontos.Items.Add(fila);
        }


        private void btnRegistro_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            cboTipo.Text = "(Seleccione su Categoria)";
            cboTipo.Focus();
        }

        private void btnEsta_Click(object sender, EventArgs e)
        {
            i = 0;
            double montoNiño = 0, montoAdulto = 0, montoTercera = 0;
            do
            {
                if (lvDatos.Items[i].SubItems[0].Text == "Niño")
                {
                    montoNiño += double.Parse(lvDatos.Items[i].SubItems[5].Text);
                }
                else if (lvDatos.Items[i].SubItems[0].Text == "Adulto")
                {
                    montoAdulto += double.Parse(lvDatos.Items[i].SubItems[5].Text);
                }
                else if (lvDatos.Items[i].SubItems[0].Text == "Tercera Edad")
                {
                    montoTercera += double.Parse(lvDatos.Items[i].SubItems[5].Text);
                }

            } while (i < lvDatos.Items.Count);
            lvEstadisticas.Items.Clear();
            string[] elementoFila = new string[2];
            ListViewItem row;
            elementoFila[0] = "NIÑO";
            elementoFila[1] = montoNiño.ToString("0.00");
            row= new ListViewItem(elementoFila);
            lvEstadisticas.Items.Add(row);
            elementoFila[0] = "ADULTO";
            elementoFila[1] = montoAdulto.ToString("0.00");
            row = new ListViewItem(elementoFila);
            lvEstadisticas.Items.Add(row);
            elementoFila[0] = "Tercera Edad";
            elementoFila[1] = montoTercera.ToString("0.00");
            row = new ListViewItem(elementoFila);
            lvEstadisticas.Items.Add(row);
        }
    }
}