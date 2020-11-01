using BussinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminInterno
{
    public partial class Admin : Form
    {
        private Titular _titular = new Titular();
        private BusTitular _busTitular = new BusTitular();

        public Admin()
        {
            InitializeComponent();

            dGVAdmin.ColumnCount = 8;
            dGVAdmin.Columns[0].HeaderText = "Adicional";
            dGVAdmin.Columns[1].HeaderText = "Apellido";
            dGVAdmin.Columns[2].HeaderText = "Nombre";
            dGVAdmin.Columns[3].HeaderText = "CUIL";
            dGVAdmin.Columns[4].HeaderText = "DNI";
            dGVAdmin.Columns[5].HeaderText = "Contacto";
            dGVAdmin.Columns[6].HeaderText = "Contacto Alternativo";
            dGVAdmin.Columns[7].HeaderText = "Correo";

            dGVAdmin.Columns[0].Width = 200;
            dGVAdmin.Columns[1].Width = 100;
            dGVAdmin.Columns[2].Width = 100;
            dGVAdmin.Columns[3].Width = 100;
            dGVAdmin.Columns[4].Width = 100;
            dGVAdmin.Columns[5].Width = 100;
            dGVAdmin.Columns[6].Width = 100;
            dGVAdmin.Columns[7].Width = 100;


        }
        


        private void btnAdmActualizar_Click(object sender, EventArgs e)
        {
                //dGVAdmin.Rows.Clear();
                DataSet ds = new DataSet();
                ds = _busTitular.listadoPosiblesTitulares("Todos");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        dGVAdmin.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), 
                            dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                        //dr[0].ToString(), 
                    }
                }
                else
                    MessageBox.Show("No hay PosiblesTitulares cargados en el sistema");
            }
    }
    
}
