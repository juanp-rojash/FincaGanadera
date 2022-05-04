using ProyectoFincaGanadera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGraficaFinca
{
    public partial class Form1 : Form
    {
        Finca F = new Finca();

        Feria Exposicion = new Feria();

        Estandar p1 = new Estandar(350, "Potrero #1", 1, 2);
        Estandar p2 = new Estandar(350, "Potrero #2", 3, 4);
        Estandar p3 = new Estandar(350, "Potrero #3", 5, 6);
        Estandar p4 = new Estandar(350, "Potrero #4", 1, 6);
        Estandar p5 = new Estandar(350, "Potrero #5", 0, 0);
        Estandar p6 = new Estandar(350, "Potrero #6", 0, 0);
        Estandar p7 = new Estandar(350, "Potrero #7", 0, 0);
        Estandar p8 = new Estandar(350, "Potrero #8", 0, 0);
        Estandar p0 = new Estandar(350, "PotreroNulo", 0, 0);
        Especial E = new Especial(100, "Potrero especial");

        public Form1()
        {
            InitializeComponent();
            
            tabPage1.Text = "Agregar";
            tabPage2.Text = "Vacunar";
            tabPage3.Text = "Transferir a potrero especial";
            tabPage4.Text = "Mover reses";

            p1.Ganado.AddRange(p1.añadir_res(31, "1"));
            p1.Ganado.AddRange(p1.añadir_res(31, "2"));
            F.Establo.Add(p1);

            p2.Ganado.AddRange(p2.añadir_res(31, "3"));
            p2.Ganado.AddRange(p2.añadir_res(31, "4"));
            F.Establo.Add(p2);
           
            p3.Ganado.AddRange(p3.añadir_res(31, "5"));
            p3.Ganado.AddRange(p3.añadir_res(31, "6"));
            F.Establo.Add(p3);
 
            p4.Ganado.AddRange(p4.añadir_res(32, "1"));
            p4.Ganado.AddRange(p4.añadir_res(32, "6"));
            F.Establo.Add(p4);

            F.Establo.Add(p5);
            
            F.Establo.Add(p6);
            
            F.Establo.Add(p7);
            
            F.Establo.Add(p8);

            lbPotreros.DataSource = F.Establo;
           
            F.Establo.Add(E);
        }

        private void LbPotreros_SelectedIndexChanged(object sender, EventArgs e)
        {
            Estandar pSeleccionado = (Estandar)lbPotreros.SelectedItem;
            lbGanado.DataSource = pSeleccionado.Ganado;

            label1.Text = pSeleccionado.Nombre;
            label3.Text = pSeleccionado.Nombre;
            label8.Text = pSeleccionado.Nombre;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int16.Parse(txtbCantidadR.Text) > 0)
                {
                    Estandar pSeleccionado = (Estandar)lbPotreros.SelectedItem;

                    pSeleccionado.Ganado.AddRange(pSeleccionado.añadir_res(short.Parse(txtbCantidadR.Text), nudRaza.Value.ToString()));

                    txtbCantidadR.Text = "";

                    lbGanado.DataSource = p0.Ganado;
                    lbGanado.DataSource = pSeleccionado.Ganado;
                }
                else MessageBox.Show("Ingrese de manera correcta los datos");
            }
            catch(Exception E)
            {
                MessageBox.Show("Error en el boton agregar " + E);
            }
        }

        private void BtnVacunar_Click(object sender, EventArgs e)
        {
            try
            {
                Estandar pSeleccionado = (Estandar)lbPotreros.SelectedItem;
                int contador = 0;

                foreach(Res T in pSeleccionado.Ganado)
                {
                    if (T.Id[0].Equals('V'))
                    {

                    }
                    else
                    {
                        contador++;
                    }
                }

                if (contador >= 10)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        foreach (Res T in pSeleccionado.Ganado)
                        {
                            if (T.Id[0].Equals('V'))
                            {

                            }
                            else
                            {
                                T.vacunar();
                                break;
                            }
                        }
                    }
                }
                else MessageBox.Show("Para la vacunacion, es como minimo, 10 reses en el potrero");

                lbGanado.DataSource = p0.Ganado;
                lbGanado.DataSource = pSeleccionado.Ganado;
            }
            catch (Exception E)
            {
                MessageBox.Show("Error en el boton Vacunar " + E);
            }
        }

        private void BtnTrasladarEsp_Click(object sender, EventArgs e)
        {
            Res rSeleccionado = (Res)lbGanado.SelectedItem;

            Estandar pSeleccionado = (Estandar)lbPotreros.SelectedItem;

            pSeleccionado.Ganado.Remove(rSeleccionado);

            E.Ganado.Add(rSeleccionado);

            lbGanado.DataSource = p0.Ganado;
            lbGanado.DataSource = pSeleccionado.Ganado;

            lbEspecial.DataSource = p0.Ganado;
            lbEspecial.DataSource = E.Ganado;
        }

        private void BtnMover_Click(object sender, EventArgs e)
        {
            Res rSelecionado = (Res)lbGanado.SelectedItem;

            Estandar pSeleccionado = (Estandar)lbPotreros.SelectedItem;

            if (nudPotrero.Value == 1)
            {
                pSeleccionado.cambiar_potrero(rSelecionado, p1);
            }
            else if (nudPotrero.Value == 2)
            {
                pSeleccionado.cambiar_potrero(rSelecionado, p2);
            }
            else if (nudPotrero.Value == 3)
            {
                pSeleccionado.cambiar_potrero(rSelecionado, p3);
            }
            else if (nudPotrero.Value == 4)
            {
                pSeleccionado.cambiar_potrero(rSelecionado, p4);
            }
            else if (nudPotrero.Value == 5)
            {
                pSeleccionado.cambiar_potrero(rSelecionado, p5);
            }
            else if (nudPotrero.Value == 6)
            {
                pSeleccionado.cambiar_potrero(rSelecionado, p6);
            }
            else if (nudPotrero.Value == 7)
            {
                pSeleccionado.cambiar_potrero(rSelecionado, p7);
            }
            else if (nudPotrero.Value == 8)
            {
                pSeleccionado.cambiar_potrero(rSelecionado, p8);
            }
            else
            {

            }

            lbGanado.DataSource = p0.Ganado;
            lbGanado.DataSource = pSeleccionado.Ganado;
        }

        private void BtnEnviarFeria_Click(object sender, EventArgs e)
        {
            //List<Res> R = new List<Res>();

            E.cantidad_camiones();

            Exposicion.Carro = E.Carro;

            lbFeria.DataSource = lbEspecial.DataSource;

            lbEspecial.DataSource = p0.Ganado;          

            MessageBox.Show("Para el transporte del ganado a la feria, se necesitaron " + Exposicion.Carro.Count + " camion(es)");
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            E.cargar_camion();

            Exposicion.Carro = E.Carro;

            Exposicion.venta_res();

            lbFeria.DataSource = p0.Ganado;          

            lbVentas.DataSource = p0.Ganado;
            lbVentas.DataSource = Exposicion.Ganancias;

            E.Carro.Clear();
            E.Ganado.Clear();
            Exposicion.Carro.Clear();
        }

        private void LbVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Venta vSelecionada = (Venta)lbVentas.SelectedItem;

            label13.Text = vSelecionada.CantidadR_Vendidas.ToString();
            label15.Text = vSelecionada.Valor_total.ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            label13.Text = "__";
            label15.Text = "__";
        }
    }
}
