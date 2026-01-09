using System;
using System.Drawing;
using System.Reflection.Metadata;
using System.Windows.Forms;
using WinFormsFinalProject;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using WinFormsFinalProyect;
using System.Data;
using System.Xml.Schema;

namespace Forms_individuales_proyecto
{


    public partial class Frm_Carrito : Form

    {
        private bool isOpening; // Controla si Pnl_Info se abre o cierra
        private bool openingID; // Controla si PnlAddData se abre o cierra
        private bool isIDPanelClosed = false; // Variable para controlar si se cierra el panel ID
        private bool openingOXXO; // Controla si Pnl_oxxo se abre o cierra

        private string User;

        private float TOTAL;

        public Frm_Carrito(string user)
        {
            InitializeComponent();
            User = user;
            AdmonDB obj = new AdmonDB();
            obj.Connect();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("NOMBRE", typeof(string));
            tabla.Columns.Add("PRECIO", typeof(float));
            foreach (var item in FormMainPage.listaPeliculas)
            {
                Products aux = obj.consultaProductos(item.id);

                // Agregar filas al DataTable
                tabla.Rows.Add(aux.Name, aux.Precio);

            }
            foreach (var item in FormMainPage.listaDulces)
            {
                Sweets aux = obj.consultarDulce(item.id);
                // Agregar filas al DataTable
                tabla.Rows.Add(aux.Name, aux.Price);
            }
            grid_productos.DataSource = tabla;
            obj.Disconnect();
        }

        private void Frm_Carrito_Load(object sender, EventArgs e)
        {
            // Configuración inicial de los paneles
            timer3.Interval = 10; // Velocidad del timer3
            timer2.Interval = 10; // Velocidad del timer2

            PnlAddData.Width = 1; // Ancho mínimo inicial para evitar ocultar controles
            PnlAddData.Visible = false; // Inicia oculto

            Pnl_Info.Width = 0; // Panel de Info inicia cerrado
            Pnl_Info.Visible = false;

            Pnl_oxxo.Width = 1; // Ancho mínimo inicial
            Pnl_oxxo.Visible = false; // Inicia oculto

        }

        private void ActualizarVisibilidad()
        {
            // Verificar si todos los paneles están completamente cerrados
            bool todosCerrados = (PnlAddData.Width == 0 || !PnlAddData.Visible) &&
                                 (Pnl_Info.Width == 0 || !Pnl_Info.Visible) &&
                                 (Pnl_oxxo.Width == 0 || !Pnl_oxxo.Visible);

            // Mostrar u ocultar elementos en función del estado de los paneles
            Pnl_Total.Visible = todosCerrados;
            Pnl_Pagos.Visible = todosCerrados;
            lbl_metodos.Visible = todosCerrados;
            lbl_iva.Visible = todosCerrados;


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int panelSpeed = 30;
            int panelTargetWidth = 315;

            if (openingOXXO)
            {
                // Abrir el panel
                if (Pnl_oxxo.Width < panelTargetWidth)
                {
                    Pnl_oxxo.Width += panelSpeed;
                    Pnl_oxxo.Left -= panelSpeed;
                }
                else
                {
                    Pnl_oxxo.Width = panelTargetWidth;
                    timer1.Stop();
                }
            }
            else
            {
                // Cerrar el panel
                if (Pnl_oxxo.Width > 0)
                {
                    Pnl_oxxo.Width -= panelSpeed;
                    Pnl_oxxo.Left += panelSpeed;
                }
                else
                {
                    Pnl_oxxo.Width = 0;
                    Pnl_oxxo.Visible = false;
                    timer1.Stop();
                }
            }

            ActualizarVisibilidad(); // Actualizar visibilidad durante la animación
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int panelSpeed = 30;
            int panelTargetWidth = 315;

            if (openingID)
            {
                // Abrir el panel
                if (PnlAddData.Width < panelTargetWidth)
                {
                    PnlAddData.Width += panelSpeed;
                    PnlAddData.Left -= panelSpeed;
                }
                else
                {
                    PnlAddData.Width = panelTargetWidth;
                    timer2.Stop();
                }
            }
            else
            {
                // Cerrar el panel
                if (PnlAddData.Width > 0)
                {
                    PnlAddData.Width -= panelSpeed;
                    PnlAddData.Left += panelSpeed;
                }
                else
                {
                    PnlAddData.Width = 0;
                    PnlAddData.Visible = false;
                    timer2.Stop();
                }
            }

            ActualizarVisibilidad(); // Actualizar visibilidad durante la animación
        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            int panelSpeed = 30;
            int panelTargetWidth = 400;

            if (isOpening)
            {
                // Abrir el panel
                if (Pnl_Info.Width < panelTargetWidth)
                {
                    Pnl_Info.Width += panelSpeed;
                }
                else
                {
                    Pnl_Info.Width = panelTargetWidth;
                    timer3.Stop();
                }
            }
            else
            {
                // Cerrar el panel
                if (Pnl_Info.Width > 0)
                {
                    Pnl_Info.Width -= panelSpeed;
                }
                else
                {
                    Pnl_Info.Width = 0;
                    Pnl_Info.Visible = false;
                    timer3.Stop();
                }
            }

            ActualizarVisibilidad(); // Actualizar visibilidad durante la animación
        }


        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Pnl_Info.Visible && Pnl_Info.Width > 0)
            {
                isOpening = false;
                timer3.Start();
            }

            PnlAddData.Left = this.Width;
            PnlAddData.Width = 0;
            PnlAddData.Visible = true; // Mostrar panel
            openingID = true;
            timer2.Start();

            ActualizarVisibilidad(); // Actualizar visibilidad al abrir el panel
        }






        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            isOpening = false; // Indica que se va a cerrar Pnl_Info
            timer3.Start(); // Iniciar animación
        }

        private void btn_cancel_id_Click(object sender, EventArgs e)
        {
            openingID = false;
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMainPage mainpage = new FormMainPage(User, 0);
            this.Hide();
            mainpage.ShowDialog();
        }

        private void Btn_Close_oxxo_Click(object sender, EventArgs e)
        {
            openingOXXO = false; // Indica que se va a cerrar Pnl_Info
            timer1.Start(); // Iniciar animación
        }

        private void Pnl_Total_Paint(object sender, PaintEventArgs e)
        {

        }
        /*
        private void Btn_Efectivo_Click(object sender, EventArgs e)
        {
            // Mostrar el mensaje
            MessageBox.Show("Gracias por elegir pago en efectivo. Por favor, complete el pago en caja.",
                            "Pago en Efectivo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            //GENERAR NOTA
            //Nombre de la tienda, logotipo, eslogan, fecha, hora,
            //datos de cada producto comprado, cantidad comprada, precio
            //Aumentar total de la nota con 6% de impuesto
            //iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.LETTER);
            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string imgURL = Path.Combine(projectDir, "Resources\\download.jpg");
            iTextSharp.text.Image imgBMP = iTextSharp.text.Image.GetInstance(imgURL);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pdfPath = Path.Combine(desktopPath, "NotaComp.pdf");
            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));

            //Abrir
            doc.AddTitle("NotaPago");
            doc.AddCreator("Equipo 1");
            doc.Open();
            //Estilos
            iTextSharp.text.Font Font8 = new iTextSharp.text.Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL));
            iTextSharp.text.Font FontB8 = new iTextSharp.text.Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD));
            iTextSharp.text.Font FontB12 = new iTextSharp.text.Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD));
            PdfPCell cVacio = new PdfPCell(new Phrase(""));
            cVacio.Border = 0;
            doc.Open();

            PdfPTable Table1 = new PdfPTable(4);
            PdfPCell col1;
            PdfPCell col2;
            PdfPCell col3;
            PdfPCell col4;
            PdfPCell col5;
            PdfPCell col6;
            int ILine;
            int iFile;
            Table1.WidthPercentage = 95;

            #region "Tabla1-Encabezado"
            imgBMP.ScaleToFit(80.0F, 110.0F);
            imgBMP.SpacingBefore = 20.0F;
            imgBMP.SpacingAfter = 10.0F;
            doc.Add(imgBMP);

            Table1.AddCell(cVacio);
            col2 = new PdfPCell(new Phrase("CINE SHARP VIEW", FontB8));
            col2.Border = 0;
            Table1.AddCell(col2);
            Table1.AddCell(cVacio);
            col3 = new PdfPCell(new Phrase("NOTA DE COMPRA", FontB8));
            col3.Border = 0;
            Table1.AddCell(col3);

            Table1.AddCell(cVacio);
            col2 = new PdfPCell(new Phrase("No hay nada más sharp que nuestras pantallas", Font8));
            col2.Border = 0;
            Table1.AddCell(col2);
            Table1.AddCell(cVacio);
            col3 = new PdfPCell(new Phrase("ELECTRONICA", FontB8));
            col3.Border = 0;
            Table1.AddCell(col3);

            Table1.AddCell(cVacio);
            col2 = new PdfPCell(new Phrase(""));
            col2.Border = 0;
            Table1.AddCell(col2);
            Table1.AddCell(cVacio);
            col3 = new PdfPCell(new Phrase("RUC: XXXXXXXXXXX", FontB8));
            col3.Border = 0;
            Table1.AddCell(col3);

            Table1.AddCell(cVacio);
            col2 = new PdfPCell(new Phrase("www.XXXXXXX.com.pe", Font8));
            col2.Border = 0;
            Table1.AddCell(col2);
            Table1.AddCell(cVacio);
            col3 = new PdfPCell(new Phrase(" F001-00004", FontB12));
            col3.Border = 0;
            Table1.AddCell(col3);
            doc.Add(Table1);
            #endregion

            #region "Tabla2-Cliente"
            PdfPTable table2 = new PdfPTable(4);
            table2.WidthPercentage = 95;
            table2.AddCell(cVacio);
            table2.AddCell(cVacio);
            table2.AddCell(cVacio);
            table2.AddCell(cVacio);
            col1 = new PdfPCell(new Phrase(" "));
            col1.Border = 0;
            table2.AddCell(col1);
            col2 = new PdfPCell(new Phrase(" "));
            col2.Border = 0;
            table2.AddCell(col2);

            col3 = new PdfPCell(new Phrase("Fecha: " + DateTime.Now.ToShortDateString(), FontB8));
            col3.Border = 0;
            table2.AddCell(col3);
            col4 = new PdfPCell(new Phrase("Hora: " + DateTime.Now.ToShortTimeString(), Font8));
            col4.Border = 0;
            table2.AddCell(col4);
            doc.Add(table2);
            #endregion

            #region "Tabla3-Cabecera"
            PdfPTable table3 = new PdfPTable(7);
            table3.WidthPercentage = 95;
            col1 = new PdfPCell(new Phrase("ITEM", FontB8));
            col1.Border = 0;
            table3.AddCell(col1);
            col2 = new PdfPCell(new Phrase("NOM", FontB8));
            col2.Border = 0;
            table3.AddCell(col2);
            col3 = new PdfPCell(new Phrase("DESC", FontB8));
            col3.Border = 0;
            table3.AddCell(col3);
            col4 = new PdfPCell(new Phrase("CANT", FontB8));
            col4.Border = 0;
            table3.AddCell(col4);
            col5 = new PdfPCell(new Phrase("PRE UNIT", FontB8));
            col5.Border = 0;
            col5.HorizontalAlignment = 2;
            table3.AddCell(col5);
            col6 = new PdfPCell(new Phrase("TOTAL", FontB8));
            col6.Border = 0;
            col6.HorizontalAlignment = 2;
            table3.AddCell(col6);
            table3.AddCell(cVacio);
            doc.Add(table3);
            #endregion

            #region "Tabla4-Detalle"
            PdfPTable table4 = new PdfPTable(7);
            table4.WidthPercentage = 95;

            float totalArt = 0;
            float Total = 0;
            float TotalPagar = 0;

            AdmonDB obj = new AdmonDB();
            obj.Connect();
            //Bought tickets (products)
            foreach (var articulo in FormMainPage.listaPeliculas)
            {
                Products aux = obj.consultaProductos(articulo.id);
                totalArt = aux.Precio * articulo.cant;

                col1 = new PdfPCell(new Phrase(aux.Id.ToString(), Font8));
                col1.Border = 0;
                table4.AddCell(col1);
                col2 = new PdfPCell(new Phrase(aux.Name, Font8));
                col2.Border = 0;
                table4.AddCell(col2);
                col3 = new PdfPCell(new Phrase(aux.About, Font8));
                col3.Border = 0;
                table4.AddCell(col3);
                col4 = new PdfPCell(new Phrase(articulo.cant.ToString(), Font8));
                col4.Border = 0;
                table4.AddCell(col4);
                col5 = new PdfPCell(new Phrase(aux.Precio.ToString(), Font8));
                col5.Border = 0;
                col5.HorizontalAlignment = 2;
                table4.AddCell(col5);
                col6 = new PdfPCell(new Phrase(totalArt.ToString(), Font8));
                col6.Border = 0;
                col6.HorizontalAlignment = 2;
                table4.AddCell(col6);
                table4.AddCell(cVacio);
                Total += totalArt;

                obj.modificarCantidadProducto(aux.Id, (aux.Stock - articulo.cant));
            }
            //Bought food (Sweets)
            foreach (var articulo in FormMainPage.listaDulces)
            {
                Sweets aux = obj.consultarDulce(articulo.id);
                totalArt = aux.Price * articulo.cant;
                col1 = new PdfPCell(new Phrase(aux.Id.ToString(), Font8));
                col1.Border = 0;
                table4.AddCell(col1);
                col2 = new PdfPCell(new Phrase(aux.Name, Font8));
                col2.Border = 0;
                table4.AddCell(col2);
                col3 = new PdfPCell(new Phrase(aux.About, Font8));
                col3.Border = 0;
                table4.AddCell(col3);
                col4 = new PdfPCell(new Phrase(articulo.cant.ToString(), Font8));
                col4.Border = 0;
                table4.AddCell(col4);
                col5 = new PdfPCell(new Phrase(aux.Price.ToString(), Font8));
                col5.Border = 0;
                col5.HorizontalAlignment = 2;
                table4.AddCell(col5);
                col6 = new PdfPCell(new Phrase(totalArt.ToString(), Font8));
                col6.Border = 0;
                col6.HorizontalAlignment = 2;
                table4.AddCell(col6);
                table4.AddCell(cVacio);
                Total += totalArt;

                obj.modificarCantidadDulce(aux.Id, (aux.Stock - articulo.cant));
            }
            obj.Disconnect();
            doc.Add(table4);
            #endregion
            TotalPagar = Total + (6 * Total / 100);
            doc.Add(new Paragraph("Total: ", FontB8));
            doc.Add(new Phrase(Total.ToString(), FontB8));
            doc.Add(new Paragraph("Total a pagar: ", FontB8));
            doc.Add(new Phrase((TotalPagar).ToString(), FontB8));

            doc.Close();
            writer.Close();
            MessageBox.Show("Nota generada!");

            FormMainPage.listaPeliculas.Clear();
            FormMainPage.listaDulces.Clear();

            obj.Connect();
            List<Users> buscaUsuario = new List<Users>();
            buscaUsuario = obj.consultaUsuarios();
            int idUser = 0;
            float ogMonto = 0;
            foreach (var item in buscaUsuario)
            {
                if (item.Nombre == User)
                {
                    idUser = item.Id;
                    ogMonto = item.Monto;
                }
            }
            obj.modificarMontoUser(idUser, (ogMonto + TotalPagar));
            obj.Disconnect();
        }
        */
        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grid_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // Verificar que todos los TextBox tengan datos
            if (string.IsNullOrWhiteSpace(this.textBox2.Text) ||
                string.IsNullOrWhiteSpace(this.textBox3.Text) ||
                string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Pago realizado.");
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Clear();
                isOpening = false;
                timer3.Start();
            }
        }

        private void BtnTarjeta_Click(object sender, EventArgs e)
        {
            AdmonDB obj = new AdmonDB();
            obj.Connect();
            float Total = 0;
            foreach (var item in FormMainPage.listaPeliculas)
            {
                Products aux = obj.consultaProductos(item.id);
                Total += aux.Precio * item.cant;
            }
            foreach (var item in FormMainPage.listaDulces)
            {
                Sweets aux = obj.consultarDulce(item.id);
                Total += aux.Price * item.cant;
            }
            obj.Disconnect();
            string valoresFila = "";
            int cantidadRigistros = grid_productos.Rows.Count;
            for (int i = 0; i < cantidadRigistros; i++)
            {
                DataGridViewRow fila = grid_productos.Rows[i];
                // Recorrer todas las celdas de la fila
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    valoresFila += celda.Value?.ToString() ?? "N/A"; // Manejar valores nulos
                    valoresFila += "\t "; // Agregar separador
                }
                // Quitar el último separador (opcional)
                if (valoresFila.EndsWith(", "))
                {
                    valoresFila = valoresFila.Remove(valoresFila.Length - 2);
                }
                valoresFila += "\n";
            }

            MessageBox.Show(
                $"\t\tCine Sharp View.\nNo hay nada más sharp que nuestras pantallas!\nFecha y hora: {DateTime.Now}\n\nProducto\t\t\t\tPrecio\n" + valoresFila + "\n\nTotal:" + Total.ToString() + "\nPor favor, complete el pago en Oxxo.\nRecuerde guardar el recibo.",
                "Nota",
                MessageBoxButtons.OK
            );

            if (PnlAddData.Visible && PnlAddData.Width > 0)
            {
                openingID = false;
                timer2.Start();
            }

            Pnl_Info.Left = 0;
            Pnl_Info.Width = 0;
            Pnl_Info.Visible = true; // Mostrar panel
            isOpening = true;
            timer3.Start();

            ActualizarVisibilidad(); // Actualizar visibilidad al abrir el panel
        }
        private void Btn_OXXO_Click(object sender, EventArgs e)
        {
            AdmonDB obj = new AdmonDB();
            obj.Connect();
            float Total = 0;
            foreach (var item in FormMainPage.listaPeliculas)
            {
                Products aux = obj.consultaProductos(item.id);
                Total += aux.Precio * item.cant;
            }
            foreach (var item in FormMainPage.listaDulces)
            {
                Sweets aux = obj.consultarDulce(item.id);
                Total += aux.Price * item.cant;
            }
            obj.Disconnect();
            string valoresFila = "";
            int cantidadRigistros = grid_productos.Rows.Count;
            for (int i = 0; i < cantidadRigistros; i++)
            {
                DataGridViewRow fila = grid_productos.Rows[i];
                // Recorrer todas las celdas de la fila
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    valoresFila += celda.Value?.ToString() ?? "N/A"; // Manejar valores nulos
                    valoresFila += "\t "; // Agregar separador
                }
                // Quitar el último separador (opcional)
                if (valoresFila.EndsWith(", "))
                {
                    valoresFila = valoresFila.Remove(valoresFila.Length - 2);
                }
                valoresFila += "\n";
            }

            MessageBox.Show(
                $"\t\tCine Sharp View.\nNo hay nada más sharp que nuestras pantallas!\nFecha y hora: {DateTime.Now}\n\nProducto\t\t\t\tPrecio\n" + valoresFila + "\n\nTotal:" + Total.ToString() + "\nPor favor, complete el pago en Oxxo.\nRecuerde guardar el recibo.",
                "Nota",
                MessageBoxButtons.OK
            );
            // Cerrar otros paneles si están abiertos
            if (PnlAddData.Visible && PnlAddData.Width > 0)
            {
                openingID = false;
                timer2.Start();
            }

            if (Pnl_Info.Visible && Pnl_Info.Width > 0)
            {
                isOpening = false;
                timer3.Start();
            }

            // Abrir o cerrar Pnl_oxxo
            Pnl_oxxo.Left = this.Width;
            Pnl_oxxo.Width = 0;
            Pnl_oxxo.Visible = true;
            openingOXXO = true; // Indica que se va a abrir
            timer1.Start();

            ActualizarVisibilidad(); // Actualizar visibilidad al abrir el panel
        }

        private void Btn_Efectivo_Click(object sender, EventArgs e)
        {


            AdmonDB obj = new AdmonDB();
            obj.Connect();
            float Total = 0;
            foreach (var item in FormMainPage.listaPeliculas)
            {
                Products aux = obj.consultaProductos(item.id);
                Total += aux.Precio * item.cant;
            }
            foreach (var item in FormMainPage.listaDulces)
            {
                Sweets aux = obj.consultarDulce(item.id);
                Total += aux.Price * item.cant;
            }
            obj.Disconnect();
            string valoresFila = "";
            int cantidadRigistros = grid_productos.Rows.Count;
            for (int i = 0; i < cantidadRigistros; i++)
            {
                DataGridViewRow fila = grid_productos.Rows[i];
                // Recorrer todas las celdas de la fila
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    valoresFila += celda.Value?.ToString() ?? "N/A"; // Manejar valores nulos
                    valoresFila += "\t "; // Agregar separador
                }
                // Quitar el último separador (opcional)
                if (valoresFila.EndsWith(", "))
                {
                    valoresFila = valoresFila.Remove(valoresFila.Length - 2);
                }
                valoresFila += "\n";
            }

            MessageBox.Show(
                $"\t\tCine Sharp View.\nNo hay nada más sharp que nuestras pantallas!\nFecha y hora: {DateTime.Now}\n\nProducto\t\t\t\tPrecio\n" + valoresFila + "\n\nTotal:" + Total.ToString() + "\nPor favor, complete el pago en Oxxo.\nRecuerde guardar el recibo.",
                "Nota",
                MessageBoxButtons.OK
            );


            // Mostrar el mensaje
            MessageBox.Show("Gracias por elegir pago en efectivo. Por favor, complete el pago en caja.",
                            "Pago en Efectivo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            //GENERAR NOTA
            //Nombre de la tienda, logotipo, eslogan, fecha, hora,
            //datos de cada producto comprado, cantidad comprada, precio
            //Aumentar total de la nota con 6% de impuesto
            //iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.LETTER);
            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string imgURL = Path.Combine(projectDir, "Resources\\download.jpg");
            iTextSharp.text.Image imgBMP = iTextSharp.text.Image.GetInstance(imgURL);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pdfPath = Path.Combine(desktopPath, "NotaComp.pdf");
            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));

            //Abrir
            doc.AddTitle("NotaPago");
            doc.AddCreator("Equipo 1");
            doc.Open();
            //Estilos
            iTextSharp.text.Font Font8 = new iTextSharp.text.Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL));
            iTextSharp.text.Font FontB8 = new iTextSharp.text.Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD));
            iTextSharp.text.Font FontB12 = new iTextSharp.text.Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD));
            PdfPCell cVacio = new PdfPCell(new Phrase(""));
            cVacio.Border = 0;
            doc.Open();

            PdfPTable Table1 = new PdfPTable(4);
            PdfPCell col1;
            PdfPCell col2;
            PdfPCell col3;
            PdfPCell col4;
            PdfPCell col5;
            PdfPCell col6;
            int ILine;
            int iFile;
            Table1.WidthPercentage = 95;

            #region "Tabla1-Encabezado"
            imgBMP.ScaleToFit(80.0F, 110.0F);
            imgBMP.SpacingBefore = 20.0F;
            imgBMP.SpacingAfter = 10.0F;
            doc.Add(imgBMP);

            Table1.AddCell(cVacio);
            col2 = new PdfPCell(new Phrase("CINE SHARP VIEW", FontB8));
            col2.Border = 0;
            Table1.AddCell(col2);
            Table1.AddCell(cVacio);
            col3 = new PdfPCell(new Phrase("NOTA DE COMPRA", FontB8));
            col3.Border = 0;
            Table1.AddCell(col3);

            Table1.AddCell(cVacio);
            col2 = new PdfPCell(new Phrase("No hay nada más sharp que nuestras pantallas", Font8));
            col2.Border = 0;
            Table1.AddCell(col2);
            Table1.AddCell(cVacio);
            col3 = new PdfPCell(new Phrase("ELECTRONICA", FontB8));
            col3.Border = 0;
            Table1.AddCell(col3);

            Table1.AddCell(cVacio);
            col2 = new PdfPCell(new Phrase(""));
            col2.Border = 0;
            Table1.AddCell(col2);
            Table1.AddCell(cVacio);
            col3 = new PdfPCell(new Phrase("RUC: XXXXXXXXXXX", FontB8));
            col3.Border = 0;
            Table1.AddCell(col3);

            Table1.AddCell(cVacio);
            col2 = new PdfPCell(new Phrase("www.XXXXXXX.com.pe", Font8));
            col2.Border = 0;
            Table1.AddCell(col2);
            Table1.AddCell(cVacio);
            col3 = new PdfPCell(new Phrase(" F001-00004", FontB12));
            col3.Border = 0;
            Table1.AddCell(col3);
            doc.Add(Table1);
            #endregion

            #region "Tabla2-Cliente"
            PdfPTable table2 = new PdfPTable(4);
            table2.WidthPercentage = 95;
            table2.AddCell(cVacio);
            table2.AddCell(cVacio);
            table2.AddCell(cVacio);
            table2.AddCell(cVacio);
            col1 = new PdfPCell(new Phrase(" "));
            col1.Border = 0;
            table2.AddCell(col1);
            col2 = new PdfPCell(new Phrase(" "));
            col2.Border = 0;
            table2.AddCell(col2);

            col3 = new PdfPCell(new Phrase("Fecha: " + DateTime.Now.ToShortDateString(), FontB8));
            col3.Border = 0;
            table2.AddCell(col3);
            col4 = new PdfPCell(new Phrase("Hora: " + DateTime.Now.ToShortTimeString(), Font8));
            col4.Border = 0;
            table2.AddCell(col4);
            doc.Add(table2);
            #endregion

            #region "Tabla3-Cabecera"
            PdfPTable table3 = new PdfPTable(7);
            table3.WidthPercentage = 95;
            col1 = new PdfPCell(new Phrase("ITEM", FontB8));
            col1.Border = 0;
            table3.AddCell(col1);
            col2 = new PdfPCell(new Phrase("NOM", FontB8));
            col2.Border = 0;
            table3.AddCell(col2);
            col3 = new PdfPCell(new Phrase("DESC", FontB8));
            col3.Border = 0;
            table3.AddCell(col3);
            col4 = new PdfPCell(new Phrase("CANT", FontB8));
            col4.Border = 0;
            table3.AddCell(col4);
            col5 = new PdfPCell(new Phrase("PRE UNIT", FontB8));
            col5.Border = 0;
            col5.HorizontalAlignment = 2;
            table3.AddCell(col5);
            col6 = new PdfPCell(new Phrase("TOTAL", FontB8));
            col6.Border = 0;
            col6.HorizontalAlignment = 2;
            table3.AddCell(col6);
            table3.AddCell(cVacio);
            doc.Add(table3);
            #endregion

            #region "Tabla4-Detalle"
            PdfPTable table4 = new PdfPTable(7);
            table4.WidthPercentage = 95;

            float totalArt = 0;
            Total = 0;
            float TotalPagar = 0;

            //AdmonDB obj = new AdmonDB();
            obj.Connect();
            //Bought tickets (products)
            foreach (var articulo in FormMainPage.listaPeliculas)
            {
                Products aux = obj.consultaProductos(articulo.id);
                totalArt = aux.Precio * articulo.cant;

                col1 = new PdfPCell(new Phrase(aux.Id.ToString(), Font8));
                col1.Border = 0;
                table4.AddCell(col1);
                col2 = new PdfPCell(new Phrase(aux.Name, Font8));
                col2.Border = 0;
                table4.AddCell(col2);
                col3 = new PdfPCell(new Phrase(aux.About, Font8));
                col3.Border = 0;
                table4.AddCell(col3);
                col4 = new PdfPCell(new Phrase(articulo.cant.ToString(), Font8));
                col4.Border = 0;
                table4.AddCell(col4);
                col5 = new PdfPCell(new Phrase(aux.Precio.ToString(), Font8));
                col5.Border = 0;
                col5.HorizontalAlignment = 2;
                table4.AddCell(col5);
                col6 = new PdfPCell(new Phrase(totalArt.ToString(), Font8));
                col6.Border = 0;
                col6.HorizontalAlignment = 2;
                table4.AddCell(col6);
                table4.AddCell(cVacio);
                Total += totalArt;

                obj.modificarCantidadProducto(aux.Id, (aux.Stock - articulo.cant));
            }
            //Bought food (Sweets)
            foreach (var articulo in FormMainPage.listaDulces)
            {
                Sweets aux = obj.consultarDulce(articulo.id);
                totalArt = aux.Price * articulo.cant;
                col1 = new PdfPCell(new Phrase(aux.Id.ToString(), Font8));
                col1.Border = 0;
                table4.AddCell(col1);
                col2 = new PdfPCell(new Phrase(aux.Name, Font8));
                col2.Border = 0;
                table4.AddCell(col2);
                col3 = new PdfPCell(new Phrase(aux.About, Font8));
                col3.Border = 0;
                table4.AddCell(col3);
                col4 = new PdfPCell(new Phrase(articulo.cant.ToString(), Font8));
                col4.Border = 0;
                table4.AddCell(col4);
                col5 = new PdfPCell(new Phrase(aux.Price.ToString(), Font8));
                col5.Border = 0;
                col5.HorizontalAlignment = 2;
                table4.AddCell(col5);
                col6 = new PdfPCell(new Phrase(totalArt.ToString(), Font8));
                col6.Border = 0;
                col6.HorizontalAlignment = 2;
                table4.AddCell(col6);
                table4.AddCell(cVacio);
                Total += totalArt;

                obj.modificarCantidadDulce(aux.Id, (aux.Stock - articulo.cant));
            }
            obj.Disconnect();
            doc.Add(table4);
            #endregion
            TotalPagar = Total + (6 * Total / 100);
            doc.Add(new Paragraph("Total: ", FontB8));
            doc.Add(new Phrase(Total.ToString(), FontB8));
            doc.Add(new Paragraph("Total a pagar: ", FontB8));
            doc.Add(new Phrase((TotalPagar).ToString(), FontB8));

            doc.Close();
            writer.Close();
            MessageBox.Show("Nota generada!");

            FormMainPage.listaPeliculas.Clear();
            FormMainPage.listaDulces.Clear();

            obj.Connect();
            List<Users> buscaUsuario = new List<Users>();
            buscaUsuario = obj.consultaUsuarios();
            int idUser = 0;
            float ogMonto = 0;
            foreach (var item in buscaUsuario)
            {
                if (item.Nombre == User)
                {
                    idUser = item.Id;
                    ogMonto = item.Monto;
                }
            }
            obj.modificarMontoUser(idUser, (ogMonto + TotalPagar));
            obj.Disconnect();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            FormMainPage.listaDulces.Clear();
            FormMainPage.listaPeliculas.Clear();
            //grid_productos.Update();
        }
    }
}
