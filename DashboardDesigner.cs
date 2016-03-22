using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingLog {
    public partial class DashboardDesigner : Form {
        public DashboardDesigner() {
            InitializeComponent();
        }

        void DashboardDesigner_Load(object sender, EventArgs e) {
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "traininglog.xml");
            dashboardDesigner1.LoadDashboard(fileName);
        }
    }
}
