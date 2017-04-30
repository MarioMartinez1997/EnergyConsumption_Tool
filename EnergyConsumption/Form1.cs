using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnergyConsumption
{

    public partial class Form1 : Form
    {
        int[] lightsHours = new int[8];
        int[] lightAmounts = new int[8];
        int[] kitchenHours = new int[6];
        int[] kitchenAmounts = new int[6];
        int[] entretainmentHours = new int[6];
        int[] entretainmentAmounts = new int[6];
        int[] exteriorHours = new int[4];
        int[] exteriorAmounts = new int[4];


        public Form1()
        {

            InitializeComponent();
            ApliancesDropDown.SelectedIndex = 0;
            label1.Text = "Number of Lights";
            label2.Text = "Watts";
            label3.Text = "Hours On";
            ApliancesDropDown.SelectedIndexChanged += new System.EventHandler(ApliancesDropDown_selectedIndex);

            KitchenOption1.Hide();
            KitchenOption2.Hide();
            KitchenOption3.Hide();
            KitchenOption4.Hide();
            KitchenOption5.Hide();
            KitchenOption6.Hide();
            EntretainmentOption1.Hide();
            EntretainmentOption2.Hide();
            EntretainmentOption3.Hide();
            EntretainmentOption4.Hide();
            EntretainmentOption5.Hide();
            EntretainmentOption6.Hide();
            ExteriorOption1.Hide();
            ExteriorOption2.Hide();
            ExteriorOption3.Hide();
            ExteriorOption4.Hide();
        }

        private void ApliancesDropDown_selectedIndex(object sender, EventArgs e)
        {
            if (ApliancesDropDown.SelectedIndex == 0) //lights
            {
                hide_not_lights();
                label1.Text = "Number of Lights";
                label2.Text = "Watts";
                label3.Text = "Hours On";
                numericUpDown1Amount.Value = lightAmounts[0];
                numericUpDown2Amount.Value = lightAmounts[1];
                numericUpDown3Amount.Value = lightAmounts[2];
                numericUpDown4Amount.Value = lightAmounts[3];
                numericUpDown5Amount.Value = lightAmounts[4];
                numericUpDown6Amount.Value = lightAmounts[5];
                numericUpDown7Amount.Value = lightAmounts[6];
                numericUpDown8Amount.Value = lightAmounts[7];

                numericUpDown1Hours.Value = lightsHours[0];
                numericUpDown2Hours.Value = lightsHours[1];
                numericUpDown3Hours.Value = lightsHours[2];
                numericUpDown4Hours.Value = lightsHours[3];
                numericUpDown5Hours.Value = lightsHours[4];
                numericUpDown6Hours.Value = lightsHours[5];
                numericUpDown7Hours.Value = lightsHours[6];
                numericUpDown8Hours.Value = lightsHours[7];

            }
            if (ApliancesDropDown.SelectedIndex == 1) //kitchen
            {
                hide_not_kitchen();
                label1.Text = "# of items";
                label2.Text = "Appliance Type";
                label3.Text = "Hours";

                numericUpDown1Amount.Value = kitchenAmounts[0];
                numericUpDown2Amount.Value = kitchenAmounts[1];
                numericUpDown3Amount.Value = kitchenAmounts[2];
                numericUpDown4Amount.Value = kitchenAmounts[3];
                numericUpDown5Amount.Value = kitchenAmounts[4];
                numericUpDown6Amount.Value = kitchenAmounts[5];

                numericUpDown1Hours.Value = kitchenHours[0];
                numericUpDown2Hours.Value = kitchenHours[1];
                numericUpDown3Hours.Value = kitchenHours[2];
                numericUpDown4Hours.Value = kitchenHours[3];
                numericUpDown5Hours.Value = kitchenHours[4];
                numericUpDown6Hours.Value = kitchenHours[5];

            }
            if (ApliancesDropDown.SelectedIndex == 2) //entretainment
            {
                hide_not_entretainment();
                label1.Text = "# of items";
                label2.Text = "Appliance Type"; ;
                label3.Text = "Hours";

                numericUpDown1Amount.Value =entretainmentAmounts[0];
                numericUpDown2Amount.Value =entretainmentAmounts[1];
                numericUpDown3Amount.Value =entretainmentAmounts[2];
                numericUpDown4Amount.Value =entretainmentAmounts[3];
                numericUpDown5Amount.Value =entretainmentAmounts[4];
                numericUpDown6Amount.Value =entretainmentAmounts[5];

                numericUpDown1Hours.Value = entretainmentHours[0];
                numericUpDown2Hours.Value = entretainmentHours[1];
                numericUpDown3Hours.Value = entretainmentHours[2];
                numericUpDown4Hours.Value = entretainmentHours[3];
                numericUpDown5Hours.Value = entretainmentHours[4];
                numericUpDown6Hours.Value = entretainmentHours[5];

            }
            if (ApliancesDropDown.SelectedIndex == 3) //exterior
            {
                hide_not_exterior();
                label1.Text = "# of items";
                label2.Text = "Appliance Type";
                label3.Text = "Hours";

                numericUpDown1Amount.Value = exteriorAmounts[0];
                numericUpDown2Amount.Value = exteriorAmounts[1];
                numericUpDown3Amount.Value = exteriorAmounts[2];
                numericUpDown4Amount.Value = exteriorAmounts[3];


                numericUpDown1Hours.Value = exteriorHours[0];
                numericUpDown2Hours.Value = exteriorHours[1];
                numericUpDown3Hours.Value = exteriorHours[2];
                numericUpDown4Hours.Value = exteriorHours[3];


            }
        }

        private void hide_not_kitchen()
        {
            ExteriorOption1.Hide();
            ExteriorOption2.Hide();
            ExteriorOption3.Hide();
            ExteriorOption4.Hide();

            LightsOption1.Hide();
            LightsOption2.Hide();
            LightsOption3.Hide();
            LightsOption4.Hide();
            LightsOption5.Hide();
            LightsOption6.Hide();
            LightsOption7.Hide();
            LightsOption8.Hide();

            EntretainmentOption1.Hide();
            EntretainmentOption2.Hide();
            EntretainmentOption3.Hide();
            EntretainmentOption4.Hide();
            EntretainmentOption5.Hide();
            EntretainmentOption6.Hide();

            KitchenOption1.Show();
            KitchenOption2.Show();
            KitchenOption3.Show();
            KitchenOption4.Show();
            KitchenOption5.Show();
            KitchenOption6.Show();

            numericUpDown5Amount.Show();
            numericUpDown5Hours.Show();
            numericUpDown6Amount.Show();
            numericUpDown6Hours.Show();
            numericUpDown7Amount.Hide();
            numericUpDown7Hours.Hide();
            numericUpDown8Amount.Hide();
            numericUpDown8Hours.Hide();
            setZero();

        }

        private void hide_not_lights()
        {
            ExteriorOption1.Hide();
            ExteriorOption2.Hide();
            ExteriorOption3.Hide();
            ExteriorOption4.Hide();    

            EntretainmentOption1.Hide();
            EntretainmentOption2.Hide();
            EntretainmentOption3.Hide();
            EntretainmentOption4.Hide();
            EntretainmentOption5.Hide();
            EntretainmentOption6.Hide();

            KitchenOption1.Hide();
            KitchenOption2.Hide();
            KitchenOption3.Hide();
            KitchenOption4.Hide();
            KitchenOption5.Hide();
            KitchenOption6.Hide();
            
            LightsOption1.Show();
            LightsOption2.Show();
            LightsOption3.Show();
            LightsOption4.Show();
            LightsOption5.Show();
            LightsOption6.Show();
            LightsOption7.Show();
            LightsOption8.Show();

            numericUpDown5Amount.Show();
            numericUpDown5Hours.Show();
            numericUpDown6Amount.Show();
            numericUpDown6Hours.Show();
            numericUpDown7Amount.Show();
            numericUpDown7Hours.Show();
            numericUpDown8Amount.Show();
            numericUpDown8Hours.Show();

            setZero();

        }
        private void hide_not_entretainment()
        {
            ExteriorOption1.Hide();
            ExteriorOption2.Hide();
            ExteriorOption3.Hide();
            ExteriorOption4.Hide();

            KitchenOption1.Hide();
            KitchenOption2.Hide();
            KitchenOption3.Hide();
            KitchenOption4.Hide();
            KitchenOption5.Hide();
            KitchenOption6.Hide();

            LightsOption1.Hide();
            LightsOption2.Hide();
            LightsOption3.Hide();
            LightsOption4.Hide();
            LightsOption5.Hide();
            LightsOption6.Hide();
            LightsOption7.Hide();
            LightsOption8.Hide();

            numericUpDown5Amount.Show();
            numericUpDown5Hours.Show();
            numericUpDown6Amount.Show();
            numericUpDown6Hours.Show();
            numericUpDown7Amount.Hide();
            numericUpDown7Hours.Hide();
            numericUpDown8Amount.Hide();
            numericUpDown8Hours.Hide();

            EntretainmentOption1.Show();
            EntretainmentOption2.Show();
            EntretainmentOption3.Show();
            EntretainmentOption4.Show();
            EntretainmentOption5.Show();
            EntretainmentOption6.Show();
            setZero();

        }

        private void hide_not_exterior()
        {
            ExteriorOption1.Show();
            ExteriorOption2.Show();
            ExteriorOption3.Show();
            ExteriorOption4.Show();

            KitchenOption1.Hide();
            KitchenOption2.Hide();
            KitchenOption3.Hide();
            KitchenOption4.Hide();
            KitchenOption5.Hide();
            KitchenOption6.Hide();

            LightsOption1.Hide();
            LightsOption2.Hide();
            LightsOption3.Hide();
            LightsOption4.Hide();
            LightsOption5.Hide();
            LightsOption6.Hide();
            LightsOption7.Hide();
            LightsOption8.Hide();

            numericUpDown5Amount.Hide();
            numericUpDown5Hours.Hide();
            numericUpDown6Amount.Hide();
            numericUpDown6Hours.Hide();
            numericUpDown7Amount.Hide();
            numericUpDown7Hours.Hide();
            numericUpDown8Amount.Hide();
            numericUpDown8Hours.Hide();

            EntretainmentOption1.Hide();
            EntretainmentOption2.Hide();
            EntretainmentOption3.Hide();
            EntretainmentOption4.Hide();
            EntretainmentOption5.Hide();
            EntretainmentOption6.Hide();

            setZero();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ApliancesDropDown.SelectedIndex == 0) //lights
            {
                lightAmounts[0] = (int) numericUpDown1Amount.Value;
                lightAmounts[1] = (int) numericUpDown2Amount.Value;
                lightAmounts[2] = (int) numericUpDown3Amount.Value;
                lightAmounts[3] = (int) numericUpDown4Amount.Value;
                lightAmounts[4] = (int) numericUpDown5Amount.Value;
                lightAmounts[5] = (int) numericUpDown6Amount.Value;
                lightAmounts[6] = (int) numericUpDown7Amount.Value;
                lightAmounts[7] = (int) numericUpDown8Amount.Value;

                lightsHours[0] = (int) numericUpDown1Hours.Value;
                lightsHours[1] = (int) numericUpDown2Hours.Value;
                lightsHours[2] = (int) numericUpDown3Hours.Value;
                lightsHours[3] = (int) numericUpDown4Hours.Value;
                lightsHours[4] = (int) numericUpDown5Hours.Value;
                lightsHours[5] = (int) numericUpDown6Hours.Value;
                lightsHours[6] = (int) numericUpDown7Hours.Value;
                lightsHours[7] = (int) numericUpDown8Hours.Value;
            }
            if (ApliancesDropDown.SelectedIndex == 1) //kitchen
            {
                kitchenAmounts[0] = (int)numericUpDown1Amount.Value;
                kitchenAmounts[1] = (int)numericUpDown2Amount.Value;
                kitchenAmounts[2] = (int)numericUpDown3Amount.Value;
                kitchenAmounts[3] = (int)numericUpDown4Amount.Value;
                kitchenAmounts[4] = (int)numericUpDown5Amount.Value;
                kitchenAmounts[5] = (int)numericUpDown6Amount.Value;

                kitchenHours[0] = (int)numericUpDown1Hours.Value;
                kitchenHours[1] = (int)numericUpDown2Hours.Value;
                kitchenHours[2] = (int)numericUpDown3Hours.Value;
                kitchenHours[3] = (int)numericUpDown4Hours.Value;
                kitchenHours[4] = (int)numericUpDown5Hours.Value;
                kitchenHours[5] = (int)numericUpDown6Hours.Value;

            }
            if (ApliancesDropDown.SelectedIndex == 2) //entretainment
            {
                entretainmentAmounts[0] = (int)numericUpDown1Amount.Value;
                entretainmentAmounts[1] = (int)numericUpDown2Amount.Value;
                entretainmentAmounts[2] = (int)numericUpDown3Amount.Value;
                entretainmentAmounts[3] = (int)numericUpDown4Amount.Value;
                entretainmentAmounts[4] = (int)numericUpDown5Amount.Value;
                entretainmentAmounts[5] = (int)numericUpDown6Amount.Value;
                
                entretainmentHours[0] = (int)numericUpDown1Hours.Value;
                entretainmentHours[1] = (int)numericUpDown2Hours.Value;
                entretainmentHours[2] = (int)numericUpDown3Hours.Value;
                entretainmentHours[3] = (int)numericUpDown4Hours.Value;
                entretainmentHours[4] = (int)numericUpDown5Hours.Value;
                entretainmentHours[5] = (int)numericUpDown6Hours.Value;
            }
            if (ApliancesDropDown.SelectedIndex == 3) //exterior
            {
                exteriorAmounts[0] = (int)numericUpDown1Amount.Value;
                exteriorAmounts[1] = (int)numericUpDown2Amount.Value;
                exteriorAmounts[2] = (int)numericUpDown3Amount.Value;
                exteriorAmounts[3] = (int)numericUpDown4Amount.Value;
                exteriorAmounts[4] = (int)numericUpDown5Amount.Value;
                exteriorAmounts[5] = (int)numericUpDown6Amount.Value;
                
                exteriorHours[0] = (int)numericUpDown1Hours.Value;
                exteriorHours[1] = (int)numericUpDown2Hours.Value;
                exteriorHours[2] = (int)numericUpDown3Hours.Value;
                exteriorHours[3] = (int)numericUpDown4Hours.Value;
                exteriorHours[4] = (int)numericUpDown5Hours.Value;
                exteriorHours[5] = (int)numericUpDown6Hours.Value;
            }
        }



        private void setZero()
        {
            numericUpDown1Amount.Value = 0;
            numericUpDown2Amount.Value = 0;
            numericUpDown3Amount.Value = 0;
            numericUpDown4Amount.Value = 0;
            numericUpDown5Amount.Value = 0;
            numericUpDown6Amount.Value = 0;
            numericUpDown7Amount.Value = 0;
            numericUpDown8Amount.Value = 0;
            numericUpDown1Hours.Value = 0;
            numericUpDown2Hours.Value = 0;
            numericUpDown3Hours.Value = 0;
            numericUpDown4Hours.Value = 0;
            numericUpDown5Hours.Value = 0;
            numericUpDown6Hours.Value = 0;
            numericUpDown7Hours.Value = 0;
            numericUpDown8Hours.Value = 0;
        }

        private double calculations(int[] light_watt, int[] light_hour, int[] kitchen_watt, int[] kitchen_hour,
            int[] ent_watt, int[] ent_hour, int[] ext_watt, int[] ext_hour)
        {
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            int totalsum = 0;
            double result = 0;

            for (int i = 0; i < light_watt.Length; i++)
            {
                {
                    sum1 += (light_watt[i] * light_hour[i]);
                }
            }
            for(int i = 0; i < kitchen_watt.Length; i++)
            {
                {
                    sum2 += (kitchen_watt[i] * kitchen_hour[i]);
                }
            }
            for (int i = 0; i < ent_watt.Length; i++)
            {
                {
                    sum3 += (ent_watt[i] * ent_hour[i]);
                }
            }
            for (int i = 0; i < ext_watt.Length; i++)
            {
                {
                    sum4 += (ext_watt[i] * ext_hour[i]);
                }
            }
            totalsum = sum1 + sum2 + sum3 + sum4;
            result = (1200 * totalsum) / 4.5;

            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double result = 0;

            result = calculations(lightAmounts, lightsHours, kitchenAmounts, kitchenHours, entretainmentAmounts,
                entretainmentHours,exteriorAmounts, exteriorHours);

            calculate_results.Text = result.ToString();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
