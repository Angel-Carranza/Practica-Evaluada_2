using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE2GL11_CL19037
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //mensajes de ayuda para el usuario
            ttAyuda.SetToolTip(txtTem, "Ingrese la temperatura, del dia que se le solocita");
            ttAyuda.SetToolTip(lblDia, "Dia de la semana del cual se solicita la temperatura");
            ttAyuda.SetToolTip(nudDia, "1. Domingo.\n2. Lunes.\n3. Martes.\n4. Miercoles.\n5. Jueves.\n6. Viernes.\n7. Sabado.");
            ttAyuda.SetToolTip(groupBox4, "Condicion del clima.\nCantidad de dias con temperatura mayor a 30°.\nPromedio de temperaturasmenores a 25°.");
            ttAyuda.SetToolTip(groupBox2, "Datos de entrada");
            ttAyuda.SetToolTip(groupBox5, "Si desea cambiar algun valor de temperatura eliga el dia e ingrese el valor de la temperatura, posteriormente presione 'cambiar'");

            txtTem.Focus();
        }
        //evento para agregar temperaturas
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtTem.Text != string.Empty)
            {
                epError.Clear();
                int cont;
                int.TryParse(lblContador.Text, out cont);

                if (cont == 0)
                {
                    cont++;
                    lblDiaD.Text = txtTem.Text;
                    lblContador.Text = cont.ToString();
                    lblDia.Text = "Lunes";
                }
                else if (cont == 1)
                {
                    cont++;
                    lblDiaL.Text = txtTem.Text;
                    lblContador.Text = cont.ToString();
                    lblDia.Text = "Martes";
                }
                else if (cont == 2)
                {
                    cont++;
                    lblDiaM.Text = txtTem.Text;
                    lblContador.Text = cont.ToString();
                    lblDia.Text = "Miercoles";
                }
                else if (cont == 3)
                {
                    cont++;
                    lblDiaX.Text = txtTem.Text;
                    lblContador.Text = cont.ToString();
                    lblDia.Text = "Jueves";
                }
                else if (cont == 4)
                {
                    cont++;
                    lblDiaJ.Text = txtTem.Text;
                    lblContador.Text = cont.ToString();
                    lblDia.Text = "Viernes";
                }
                else if (cont == 5)
                {
                    cont++;
                    lblDiaV.Text = txtTem.Text;
                    lblContador.Text = cont.ToString();
                    lblDia.Text = "Sabado";
                }
                else if (cont == 6)
                {
                    cont++;
                    lblDiaS.Text = txtTem.Text;
                    lblContador.Text = cont.ToString();
                }
                //mansaje de error
                else 
                   if (cont == 7)
                {
                    MessageBox.Show("Ya se han llenado todos los datos, puede proceder a operar con ellos o puede cambiar el dato que desee");
                }
                //mensaje de error
            }
            else
                if (txtTem.Text == string.Empty)
            {
                MessageBox.Show("DEBE LLENAR TODO LOS CAMPOS PARA PODER CONTINUAR");
                epError.SetError(txtTem, "Campo obligatorio");
            }
            txtTem.Clear();
            txtTem.Focus();
        }
        //evento para hacer las evaluaciones pertientes
        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            EvaluarDias verificar = new EvaluarDias();
            int conteo = 0, cuentaSuma = 0;
            double sumaFria = 0;
            if (lblDiaD.Text != "-" && lblDiaL.Text != "-" && lblDiaM.Text != "-" && lblDiaX.Text != "-" && lblDiaJ.Text != "-" && lblDiaV.Text != "-" && lblDiaS.Text != "-")
            {
                epError.Clear();
                //evaluacion de temperaturas mas frias, tomando 30° como el limite  
                //de temperaturas frias y conteo de temperaturas mayores a 30°
                for (int j = 1; j <= 7; j++)
                {
                    int.TryParse(lblCantTrein.Text, out conteo);
                    if (j == 1)
                    {
                        verificar.Dia = double.Parse(lblDiaD.Text);
                        verificar.Caliente = conteo;
                        lblCantTrein.Text = verificar.ConteoCaluroso().ToString();
                        lblCondicionD.Text = verificar.Condicion() + "";
                        if (lblCondicionD.Text == "Frio")
                        {
                            lblTemFD.Text = lblDiaD.Text;
                        }
                    }
                    else if (j == 2)
                    {
                        verificar.Dia = double.Parse(lblDiaL.Text);
                        verificar.Caliente = conteo;
                        lblCantTrein.Text = verificar.ConteoCaluroso().ToString();
                        lblCondicionL.Text = verificar.Condicion() + "";
                        if (lblCondicionL.Text == "Frio")
                        {
                            lblTemFL.Text = lblDiaL.Text;
                        }
                    }
                    else if (j == 3)
                    {
                        verificar.Dia = double.Parse(lblDiaM.Text);
                        verificar.Caliente = conteo;
                        lblCantTrein.Text = verificar.ConteoCaluroso().ToString();
                        lblCondicionM.Text = verificar.Condicion() + "";
                        if (lblCondicionM.Text == "Frio")
                        {
                            lblTemFM.Text = lblDiaM.Text;
                        }
                    }
                    else if (j == 4)
                    {
                        verificar.Dia = double.Parse(lblDiaX.Text);
                        verificar.Caliente = conteo;
                        lblCantTrein.Text = verificar.ConteoCaluroso().ToString();
                        lblCondicionX.Text = verificar.Condicion() + "";
                        if (lblCondicionX.Text == "Frio")
                        {
                            lblTemFX.Text = lblDiaX.Text;
                        }
                    }
                    else if (j == 5)
                    {
                        verificar.Dia = double.Parse(lblDiaJ.Text);
                        verificar.Caliente = conteo;
                        lblCantTrein.Text = verificar.ConteoCaluroso().ToString();
                        lblCondicionJ.Text = verificar.Condicion() + "";
                        if (lblCondicionJ.Text == "Frio")
                        {
                            lblTemFJ.Text = lblDiaJ.Text;
                        }
                    }
                    else if (j == 6)
                    {
                        verificar.Dia = double.Parse(lblDiaV.Text);
                        verificar.Caliente = conteo;
                        lblCantTrein.Text = verificar.ConteoCaluroso().ToString();
                        lblCondicionV.Text = verificar.Condicion() + "";
                        if (lblCondicionV.Text == "Frio")
                        {
                            lblTemFV.Text = lblDiaV.Text;
                        }
                    }
                    else if (j == 7)
                    {
                        verificar.Dia = double.Parse(lblDiaS.Text);
                        verificar.Caliente = conteo;
                        lblCantTrein.Text = verificar.ConteoCaluroso().ToString();
                        lblCondicionS.Text = verificar.Condicion() + "";
                        if (lblCondicionS.Text == "Frio")
                        {
                            lbltemFS.Text = lblDiaS.Text;
                        }
                    }
                }
                //conteo de dias con temperatura menor a 25°
                for (int j = 1; j <= 7; j++)
                {
                    if (float.Parse(lblDiaD.Text) <= 25)
                    {
                        sumaFria = sumaFria + float.Parse(lblDiaD.Text);
                        cuentaSuma++;
                    }
                    if (float.Parse(lblDiaL.Text) <= 25)
                    {
                        sumaFria = sumaFria + float.Parse(lblDiaL.Text);
                        cuentaSuma++;
                    }
                    if (float.Parse(lblDiaM.Text) <= 25)
                    {
                        sumaFria = sumaFria + float.Parse(lblDiaM.Text);
                        cuentaSuma++;
                    }
                    if (float.Parse(lblDiaX.Text) <= 25)
                    {
                        sumaFria = sumaFria + float.Parse(lblDiaX.Text);
                        cuentaSuma++;
                    }
                    if (float.Parse(lblDiaJ.Text) <= 25)
                    {
                        sumaFria = sumaFria + float.Parse(lblDiaJ.Text);
                        cuentaSuma++;
                    }
                    if (float.Parse(lblDiaV.Text) <= 25)
                    {
                        sumaFria = sumaFria + float.Parse(lblDiaV.Text);
                        cuentaSuma++;
                    }
                    if (float.Parse(lblDiaS.Text) <= 25)
                    {
                        sumaFria = sumaFria + float.Parse(lblDiaS.Text);
                        cuentaSuma++;
                    }
                }
                verificar.Frio = sumaFria;
                verificar.ConteoFrio = cuentaSuma;
                lblPromMeV.Text = verificar.PromedioFrio().ToString();
            }
            //mensaje de error
            else
            if (lblDiaD.Text == "-" || lblDiaL.Text == "-" || lblDiaM.Text == "-" || lblDiaX.Text == "-" || lblDiaJ.Text == "-" || lblDiaV.Text == "-" || lblDiaS.Text == "-")
            {
                MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS PARA PODER CONTINUAR");
                epError.SetError(groupBox2, "debe llenar estos campos para poder continuar");
                txtTem.Clear();
                txtTem.Focus();
            }
        }
        //evento para controlar una entrada de solo numeros
        private void txtTem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                epError.SetError(txtTem, ("ESTE CAMPO SOLO ADMITE NUMEROS"));
                e.Handled = true;
                return;
            }
            else
            {
                epError.Clear();
            }
        }
        //evento para cambiar alguna temperatura
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (txtTem.Text != string.Empty)
            {
                epError.Clear();
                if (nudDia.Value == 1)
                {
                    lblDiaD.Text = txtTem.Text;
                    txtTem.Clear();
                    nudDia.Value = 0;
                }
                else if (nudDia.Value == 2)
                {
                    lblDiaL.Text = txtTem.Text;
                    txtTem.Clear();
                    nudDia.Value = 0;
                }
                else if (nudDia.Value == 3)
                {
                    lblDiaM.Text = txtTem.Text;
                    txtTem.Clear();
                    nudDia.Value = 0;
                }
                else if (nudDia.Value == 4)
                {
                    lblDiaX.Text = txtTem.Text;
                    txtTem.Clear();
                    nudDia.Value = 0;
                }
                else if (nudDia.Value == 5)
                {
                    lblDiaJ.Text = txtTem.Text;
                    txtTem.Clear();
                    nudDia.Value = 0;
                }
                else if (nudDia.Value == 6)
                {
                    lblDiaV.Text = txtTem.Text;
                    txtTem.Clear();
                    nudDia.Value = 0;
                }
                else if (nudDia.Value == 7)
                {
                    lblDiaS.Text = txtTem.Text;
                    txtTem.Clear();
                    nudDia.Value = 0;
                }
                else if (nudDia.Value == 0)
                {
                    MessageBox.Show("Eliga que numero desea cambiar", "Advertencia");
                    epError.SetError(nudDia, "campo obligatorio");
                }
            }
            else if (txtTem.Text == string.Empty)
            {
                MessageBox.Show("No se ha agregado un valor para cambiar", "Advertencia");
                epError.SetError(txtTem, "Campo obligatorio");
            }
            txtTem.Focus();
        }
        //evento para limpiar los datos ingresados y los datos procesados
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lblContador.Text = "-";
            lblCantTrein.Text = "0";
            lblCondicionD.Text = "-";
            lblCondicionL.Text = "-";
            lblCondicionM.Text = "-";
            lblCondicionX.Text = "-";
            lblCondicionJ.Text = "-";
            lblCondicionV.Text = "-";
            lblCondicionS.Text = "-";
            lblDiaD.Text = "-";
            lblDiaL.Text = "-";
            lblDiaM.Text = "-";
            lblDiaX.Text = "-";
            lblDiaJ.Text = "-";
            lblDiaV.Text = "-";
            lblDiaS.Text = "-";
            lblTemFD.Text = "-";
            lblTemFL.Text = "-";
            lblTemFM.Text = "-";
            lblTemFX.Text = "-";
            lblTemFJ.Text = "-";
            lblTemFV.Text = "-";
            lbltemFS.Text = "-";
            lblPromMeV.Text = "-";
            txtTem.Focus();
            epError.Clear();
        }
    }
}

