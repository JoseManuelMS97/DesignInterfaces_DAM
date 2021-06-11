using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamenDI_WPF_JoseManuelMonteagudoSanchez
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path = @"G:\VisualStudio\Workspace\ExamenDI_WPF_JoseManuelMonteagudoSanchez\FicheroExamen.txt";
        List<Mensaje> listaMensajes = new List<Mensaje>();

        public MainWindow()
        {
            InitializeComponent();
        }

        //Boton de ENVIAR
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tEstado.Text = "Enviado";

            string contacto = comboContacto.Text;
            DateTime fecha = fechaPicker.SelectedDate.Value;
            string mensaje = tMensaje.Text;
            string estado = "Enviado";

            if (string.IsNullOrEmpty(tMensaje.Text))
            {
                MessageBox.Show("No puede dejar el mensaje vacio.");
            }
            else
            {
                listaMensajes.Add(new Mensaje(contacto, fecha, estado, mensaje));
                MessageBoxResult botonPulsado = MessageBox.Show("¿Deseas introducir otro mensaje?","Enviar Mensaje", MessageBoxButton.YesNo);

                if (botonPulsado == MessageBoxResult.Yes)
                {
                    tMensaje.Text = "";
                    comboContacto.Text = "";
                    tEstado.Text = "";
                }
                else
                {
                    tMensaje.Text = "";
                    fechaPicker.Text = "";
                    comboContacto.Text = "";
                    tEstado.Text = "";

                }
                
            }
            }

        //Boton de GUARDAR
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tEstado.Text = "Guardado";
            string contacto = "Contacto: " + comboContacto.Text;
            string fecha = "Fecha: " + fechaPicker.Text;
            string estado = "Estado: " + tEstado.Text;
            string mensaje = "Mensaje: " + tMensaje.Text;

            if (string.IsNullOrEmpty(tMensaje.Text))
            {
                MessageBox.Show("No puede dejar el mensaje vacio.");
            }
            else{
                try
                {
                    if (File.Exists(path)){
                        using (StreamWriter sw = new StreamWriter(path))
                        {                        
                            sw.WriteLine(contacto);
                            sw.WriteLine(fecha);
                            sw.WriteLine(estado);
                            sw.WriteLine(mensaje);
                            sw.WriteLine();
                        }
                        MessageBox.Show("Mensaje guardado.");
                    }
                    else MessageBox.Show("El fichero no existe.");


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                }
            }
        }


        //Boton BUSCAR
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string nombre = comboContacto.Text;
            Console.WriteLine(nombre);

            Boolean encontrado = false;

            foreach (Mensaje item in listaMensajes)
            {
                if (item.Contact == nombre)
                {
                    tMensaje.Text += item.Mostrar() +"\n";
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                MessageBox.Show("No hay mensajes de ese contacto.");
            }
        }
    }
}
