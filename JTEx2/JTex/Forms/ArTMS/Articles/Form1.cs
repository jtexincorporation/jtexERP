﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTex.Forms.ArTMS.Articles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Uncomment next line to set the total number of data records stored within your source
            // unboundSource1.SetRowCount(42);
            // This line of code is generated by Data Source Configuration Wizard
            this.unboundSource1.ValueNeeded += unboundSource1_ValueNeeded;
            // This line of code is generated by Data Source Configuration Wizard
            this.unboundSource1.ValuePushed += unboundSource1_ValuePushed;
            // This line of code is generated by Data Source Configuration Wizard
            // Uncomment next line to set the total number of data records stored within your source
            // unboundSource1.SetRowCount(42);
            // This line of code is generated by Data Source Configuration Wizard
            this.unboundSource1.ValueNeeded += unboundSource1_ValueNeeded_1;
            // This line of code is generated by Data Source Configuration Wizard
            this.unboundSource1.ValuePushed += unboundSource1_ValuePushed_1;
        }

        // This event is generated by Data Source Configuration Wizard
        void unboundSource1_ValueNeeded(object sender, DevExpress.Data.UnboundSourceValueNeededEventArgs e)
        {

            // Handle this event to obtain data from your data source
            // e.Value = something /* TODO: Assign the real data here.*/
        }

        // This event is generated by Data Source Configuration Wizard
        void unboundSource1_ValuePushed(object sender, DevExpress.Data.UnboundSourceValuePushedEventArgs e)
        {

            // Handle this event to save modified data back to your data source
            // something = e.Value; /* TODO: Propagate the value into the storage.*/
        }

        // This event is generated by Data Source Configuration Wizard
        void unboundSource1_ValueNeeded_1(object sender, DevExpress.Data.UnboundSourceValueNeededEventArgs e)
        {

            // Handle this event to obtain data from your data source
            // e.Value = something /* TODO: Assign the real data here.*/
        }

        // This event is generated by Data Source Configuration Wizard
        void unboundSource1_ValuePushed_1(object sender, DevExpress.Data.UnboundSourceValuePushedEventArgs e)
        {

            // Handle this event to save modified data back to your data source
            // something = e.Value; /* TODO: Propagate the value into the storage.*/
        }
    }
}
