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
        }
    }    
}