using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace BoussinesqJointPatternMaker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new JointCoordinatesForm());
            Application.Run(new MainForm());

            /*
            JointCoordinatesForm jcf = new JointCoordinatesForm();

            FormAddPointLoads pLoads = new FormAddPointLoads();
            DataTable ndt = new DataTable();
            ndt = pLoads.PointLoadsDataTable;

            FormAddPointLoads qLoads = new FormAddPointLoads();
            qLoads.PointLoadsDataTable = ndt;
            qLoads.Refresh();
            */
        }


        static DataTable GetForces(DataTable PointLoads)
        {

            return null;
        }


    }





}

