using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;


namespace T6M
{
    
    public partial class Form1 : Form
    {
        public static CCAPI ps3 = new CCAPI();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void connectAndAttach_Click(object sender, EventArgs e)
        {
            if (ps3.ConnectTarget())
            {
                ps3.AttachProcess();
                label1.Text = "Status: Connected";
                connectAndAttach.Enabled = false;
            }
            else
            {
                MessageBox.Show("Couldn't connect to PS3");
                label1.ForeColor =Color.Red;
            }

        }

        private void godMode_Click(object sender, EventArgs e)
        {
            uint godModeOffset = 0x1780F43;
            byte[] godModeOn = { 0x05 };
            ps3.SetMemory(godModeOffset, godModeOn);
        }

        private void steadyAim_Click(object sender, EventArgs e)
        {
            uint steadyAimOffset = 0x5F0A20;
            byte[] steadyAimOn = { 0x2C, 0x04, 0x00, 0x00 };
            ps3.SetMemory(steadyAimOffset, steadyAimOn);
        }

        private void noRecoil_Click(object sender, EventArgs e)
        {
            uint noRecoilOffset = 0xF9E54;
            byte[] noRecoilOn = { 0x60, 0x00, 0x00, 0x00 };
            ps3.SetMemory(noRecoilOffset, noRecoilOn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint pointOffset = 0x1786501;
            byte[] points = { 0x0F, 0x42, 0x40 };
            ps3.SetMemory(pointOffset, points);
        }

        private void infiniteAmmo_Click(object sender, EventArgs e)
        {
            uint[] ammoOffsets = { 0x0178135d, 0x01781361, 0x01781365, 0x01781359, 0x0178139d, 0x01781395, 0x01781391, 0x0178138d };
            for (int i = 0; i < ammoOffsets.Length; i++)
            {
                ps3.SetMemory(ammoOffsets[i], new byte[] { 0xFF,0xFF,0xFF });
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            uint superJumpOfffset = 0x005BE0B4;
            byte[] superMonkeyJump = { 0x45, 0x48 };
            ps3.SetMemory(superJumpOfffset, superMonkeyJump);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            uint allPerks = 0x1781470;
            byte[] perks = { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
            ps3.SetMemory(allPerks, perks);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            uint pointOffset = 0x1786501 + 0x5808;
            byte[] points = { 0x0F, 0x42, 0x40 };
            ps3.SetMemory(pointOffset, points);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            uint godModeOffset = 0x1780F43 + 0x5808;
            byte[] godModeOn = { 0x05 };
            ps3.SetMemory(godModeOffset, godModeOn);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uint steadyAimOffset = 0x5F0A20 + 0x5808;
            byte[] steadyAimOn = { 0x2C, 0x04, 0x00, 0x00 };
            ps3.SetMemory(steadyAimOffset, steadyAimOn);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uint allPerks = 0x1781470 + 0x5808;
            byte[] perks = { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
            ps3.SetMemory(allPerks, perks);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            uint noRecoilOffset = 0xF9E54 + 0x5808;
            byte[] noRecoilOn = { 0x60, 0x00, 0x00, 0x00 };
            ps3.SetMemory(noRecoilOffset, noRecoilOn);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            uint pointOffset = 0x1786501 + 0x5808;
            byte[] points = { 0x0F, 0x42, 0x40 };
            ps3.SetMemory(pointOffset, points);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            uint[] ammoOffsets = { 0x0178135d + 0x5808, 0x01781361 + 0x5808, 0x01781365 + 0x5808, 0x01781359 + 0x5808, 0x0178139d + 0x5808, 0x01781395 + 0x5808, 0x01781391 + 0x5808, 0x0178138d + 0x5808 };
            for (int i = 0; i < ammoOffsets.Length; i++)
            {
                ps3.SetMemory(ammoOffsets[i], new byte[] { 0xFF, 0xFF, 0xFF });
            }
        }
    }
}
