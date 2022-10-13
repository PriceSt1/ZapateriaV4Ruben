using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZapateriaV4.Datos;
using ZapateriaV4.Models;

namespace ZapateriaV4
{
    public partial class Zapateria : Form
    {
        private AccesoZapato acceso = new AccesoZapato();
        public Zapateria()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<Object> zapatos = acceso.obtenerZapatos();
                foreach (Zapato zapato in zapatos)
                {
                    lstZapatos.Items.Add(zapato);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAlta_Click(object sender, EventArgs e)
        {
            try
            {
                acceso.insertarZapato(RecogeDatosPantalla());
                MessageBox.Show(Mensajes.MSG_INSERTADO);
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBaja_Click(object sender, EventArgs e)
        {
            try
            {
                acceso.borrarZapato(RecogeDatosPantalla());
                MessageBox.Show(Mensajes.MSG_BORRADO);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                acceso.modificarZapato(RecogeDatosPantalla());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            vaciarPantalla();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lstZapatos_Click(object sender, EventArgs e)
        {
            enviarDatosPantalla(RecogeDatosPantalla());
        }

        /*
         * ---------------------------------
         * Métodos primitivos
         * ---------------------------------
         */

        private Zapato RecogeDatosPantalla()
        {
            Zapato zapato = new Zapato();
            if (tbMarca.Text != "" || tbColor.Text != "" || tbNombre.Text != "" || tbPrecio.Text != "" || 
                cbxTipo.Text != "")
            {
                zapato.Marca = tbMarca.Text;
                zapato.Nombre = tbNombre.Text;
                zapato.Color = tbColor.Text;
                zapato.Precio = tbPrecio.Text.Replace(".", ",");
                zapato.Precio = zapato.Precio.Replace("€", "");
                zapato.Precio = zapato.Precio.Trim();
                zapato.Formatouno = chbxTela.Checked ? chbxTela.Text : "N/A";
                zapato.Formatodos = chbxPlastico.Checked ? chbxPlastico.Text : "N/A";
                zapato.Formatotres = chbxCuero.Checked ? chbxCuero.Text : "N/A";
                zapato.Tipo = cbxTipo.SelectedIndex.ToString();
                if (rbStock.Checked) 
                {
                    zapato.Estado = "Stock";
                } 
                else if (rbOut.Checked)
                {
                    zapato.Estado = "Out Stock"; 
                }
                else
                {
                    MessageBox.Show(Mensajes.MSG_CAMPOSVACIOS);
                }
            }
            else
            {
                MessageBox.Show(Mensajes.MSG_CAMPOSVACIOS);
            }
            return zapato;
        }

        private void enviarDatosPantalla(Zapato zapato)
        {
            tbColor.Text = zapato.Color;
            tbMarca.Text = zapato.Marca;
            tbNombre.Text = zapato.Nombre;
            tbPrecio.Text = zapato.Precio + "€";
            cbxTipo.Text = zapato.Tipo;
            if (zapato.Estado == "Stock")
            {
                rbStock.Checked = true;
                rbOut.Checked = false;
            }
            else
            {
                rbOut.Checked = true;
                rbStock.Checked = false;
            }

            if (zapato.Formatouno.Equals("Tela")) chbxTela.Checked = true; else chbxTela.Checked = false; 
            if (zapato.Formatodos.Equals("Plastico")) chbxPlastico.Checked = true; else chbxPlastico.Checked = false; 
            if (zapato.Formatotres.Equals("Cuero")) chbxCuero.Checked = true; else chbxCuero.Checked = false; 
        }

        private void vaciarPantalla()
        {
            tbColor.Text = "";
            tbMarca.Text = "";
            tbNombre.Text = "";
            tbPrecio.Text = "";
            cbxTipo.SelectedIndex = 0;
            chbxTela.Checked = false;
            chbxPlastico.Checked = false;
            chbxCuero.Checked = false;
            rbStock.Checked = false;
            rbOut.Checked = false;
        }

    }
}
