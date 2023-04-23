using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            cboEstadoCivil.Items.Add("Soltero/a");
            cboEstadoCivil.Items.Add("Casado/a");
            cboEstadoCivil.Items.Add("Divorciado/a");
            cboEstadoCivil.Items.Add("Viudo/a");
        }

        private void rbtOtro_CheckedChanged(object sender, EventArgs e)
        {
            txtOtro.Visible = true;
            lblCompleteOtro.Visible = true;
        }

        private void rbtMasculino_CheckedChanged(object sender, EventArgs e)
        {
            txtOtro.Visible = false;
            lblCompleteOtro.Visible = false;
        }

        private void rbtFemenino_CheckedChanged(object sender, EventArgs e)
        {
            txtOtro.Visible = false;
            lblCompleteOtro.Visible = false;
        }

        private void rbtNoResp_CheckedChanged(object sender, EventArgs e)
        {
            txtOtro.Visible = false;
            lblCompleteOtro.Visible = false;
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            txtEdad.Visible = true;
            DateTime fecha = DateTime.Now;
            int edad = fecha.Year - dtpFechaNacimiento.Value.Year;
            if (dtpFechaNacimiento.Value.Month < DateTime.Now.Month)
            {
                if (dtpFechaNacimiento.Value.Day < DateTime.Now.Day)
                {
                    edad++;
                }
            }
            txtEdad.Text = edad.ToString();
           
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string sexo = "1";
            string estadocivil = "1";   
            if (rbtFemenino.Checked == true) 
            {
                sexo = "Femenino";
            }
            if (rbtMasculino.Checked == true)
            {
                sexo = "Masculino";
            }
            if (rbtNoResp.Checked == true)
            {
                sexo = "No quiere responder";
            }
            if (rbtOtro.Checked == true)
            {
                sexo = txtOtro.Text.ToString();
            }
            if  (cboEstadoCivil.Text == "Soltero/a")
            {
                estadocivil = "Soltero / a";
            }
            else
            {
                if (cboEstadoCivil.Text == "Casado/a")
                {
                    estadocivil = "Casado/a";
                }
                else
                {
                    if (cboEstadoCivil.Text == "Divorciado/a")
                    {
                        estadocivil = "Divorciado/a";
                    }
                    else
                    {
                        if (cboEstadoCivil.Text == "Viudo/a")
                        {
                            estadocivil = "Viudo/a";
                        }
                        else estadocivil = "No Respondió";
                    }
                }
            }
            rbtResumen.Text =("Nombre y Apellido: " + txtNombre.Text.ToString() + ", Edad: " + txtEdad.Text.ToString()  +   ", Sexo: " + sexo + ", Estado Civil: " + estadocivil);
        }

        private void btnClases_Click(object sender, EventArgs e)
        {
            Persona P1 = new Persona();
            P1.Nombre = txtNombre.Text;
            P1.Edad = Int32.Parse(txtEdad.Text);
            if (rbtFemenino.Checked == true)
            {
                P1.Sexo = "Femenino";
            }
            if (rbtMasculino.Checked == true)
            {
                P1.Sexo = "Masculino";
            }
            if (rbtNoResp.Checked == true)
            {
                P1.Sexo = "No quiere responder";
            }
            if (rbtOtro.Checked == true)
            {
                P1.Sexo = txtOtro.Text.ToString();
            }
            if (cboEstadoCivil.Text == "Soltero/a")
            {
                P1.EstadoCivil = "Soltero / a";
            }
            else
            {
                if (cboEstadoCivil.Text == "Casado/a")
                {
                    P1.EstadoCivil = "Casado/a";
                }
                else
                {
                    if (cboEstadoCivil.Text == "Divorciado/a")
                    {
                        P1.EstadoCivil = "Divorciado/a";
                    }
                    else
                    {
                        if (cboEstadoCivil.Text == "Viudo/a")
                        {
                            P1.EstadoCivil = "Viudo/a";
                        }
                        else P1.EstadoCivil = "No Respondió";
                    }
                }
            }
            rbtResumen.Text = ("Nombre y Apellido: " + P1.Nombre.ToString() + ", Edad: " + P1.Edad.ToString() + ", Sexo: " + P1.Sexo.ToString() + ", Estado Civil: " + P1.EstadoCivil.ToString());
        }
    }
}
