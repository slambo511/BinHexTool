using System;
using System.Windows.Forms;

// Author - Samuel Bancroft

namespace BinHexTool
{
    public partial class Form1 : Form
    {
        #region constantDeclarations
        const char BckSpc = (char)8;
        const char Zero = (char)48;
        const char One = (char)49;
        const char Two = (char)50;
        const char Three = (char)51;
        const char Four = (char)52;
        const char Five = (char)53;
        const char Six = (char)54;
        const char Seven = (char)55;
        const char Eight = (char)56;
        const char Nine = (char)57;
        const char A = (char)65;
        const char a = (char)97;
        const char B = (char)66;
        const char b = (char)98;
        const char C = (char)67;
        const char c = (char)99;
        const char D = (char)68;
        const char d = (char)100;
        const char E = (char)69;
        const char eLow = (char)101;
        const char F = (char)70; 
        const char f = (char)102;
        const int dec = 10;
        const int bin = 2;
        const int hex = 16;
        long charValue;
        #endregion constantDeclarations

        public Form1()
        {
            InitializeComponent();
            this.txtBin.KeyPress += new KeyPressEventHandler(txtBin_KeyPress);
            this.txtHex.KeyPress += new KeyPressEventHandler(txtHex_KeyPress);
            this.txtDec.KeyPress += new KeyPressEventHandler(txtDec_KeyPress);
        }

        #region keyPressHandlers
        private void txtBin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == BckSpc) { return; }
            if (e.KeyChar == Zero) { return; }
            if (e.KeyChar == One) { return; }
            e.Handled = true; 
        }

        private void txtHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == BckSpc) { return; }
            if (e.KeyChar == Zero) { return; }
            if (e.KeyChar == One) { return; }
            if (e.KeyChar == Three) { return; }
            if (e.KeyChar == Four) { return; }
            if (e.KeyChar == Five) { return; }
            if (e.KeyChar == Six) { return; }
            if (e.KeyChar == Seven) { return; }
            if (e.KeyChar == Eight) { return; }
            if (e.KeyChar == Nine) { return; }
            if (e.KeyChar == A || e.KeyChar == a) { return; }
            if (e.KeyChar == B || e.KeyChar == b) { return; }
            if (e.KeyChar == C || e.KeyChar == c) { return; }
            if (e.KeyChar == D || e.KeyChar == d) { return; }
            if (e.KeyChar == E || e.KeyChar == eLow) { return; }
            if (e.KeyChar == F || e.KeyChar == f) { return; }
            e.Handled = true;
        }

        private void txtDec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == BckSpc) { return; }
            if (e.KeyChar == Zero) { return; }
            if (e.KeyChar == One) { return; }
            if (e.KeyChar == Two) { return; }
            if (e.KeyChar == Three) { return; }
            if (e.KeyChar == Four) { return; }
            if (e.KeyChar == Five) { return; }
            if (e.KeyChar == Six) { return; }
            if (e.KeyChar == Seven) { return; }
            if (e.KeyChar == Eight) { return; }
            if (e.KeyChar == Nine) { return; }
            e.Handled = true;
        }
        #endregion keyPressHandlers

        #region textChangedHandlers
        private void txtBin_TextChanged(object sender, System.EventArgs e)
        {
            if (txtBin.Text != "")
            {
                txtDec.ReadOnly = true;
                txtHex.ReadOnly = true;
                txtASCII.ReadOnly = true;
            }
            else
            {
                txtDec.ReadOnly = false;
                txtHex.ReadOnly = false;
                txtASCII.ReadOnly = false;
            }
        }

        private void txtHex_TextChanged(object sender, System.EventArgs e)
        {
            if (txtHex.Text != "")
            {
                txtDec.ReadOnly = true;
                txtBin.ReadOnly = true;
                txtASCII.ReadOnly = true;
            }
            else
            {
                txtDec.ReadOnly = false;
                txtBin.ReadOnly = false;
                txtASCII.ReadOnly = false;
            }
        }

        private void txtDec_TextChanged(object sender, System.EventArgs e)
        {
            if (txtDec.Text != "")
            {
                txtBin.ReadOnly = true;
                txtHex.ReadOnly = true;
                txtASCII.ReadOnly = true;
            }
            else
            {
                txtBin.ReadOnly = false;
                txtHex.ReadOnly = false;
                txtASCII.ReadOnly = false;
            }
        }

        private void txtASCII_TextChanged(object sender, EventArgs e)
        {
            if (txtASCII.Text != "")
            {
                txtBin.ReadOnly = true;
                txtHex.ReadOnly = true;
                txtDec.ReadOnly = true;
            }
            else
            {
                txtBin.ReadOnly = false;
                txtHex.ReadOnly = false;
                txtDec.ReadOnly = false;
            }
        }
        #endregion textChangedHandlers

        #region textBoxEnterHandlers
        private void txtBin_Enter(object sender, EventArgs e)
        {
            if (txtBin.ReadOnly)
            {
                txtBin.ReadOnly = false;
                txtDec.ReadOnly = false;
                txtHex.ReadOnly = false;
                txtASCII.ReadOnly = false;
                txtBin.Text = "";
                txtDec.Text = "";
                txtHex.Text = "";
                txtASCII.Text = "";
            }
        }

        private void txtHex_Enter(object sender, EventArgs e)
        {
            if (txtHex.ReadOnly)
            {
                txtBin.ReadOnly = false;
                txtDec.ReadOnly = false;
                txtHex.ReadOnly = false;
                txtASCII.ReadOnly = false;
                txtBin.Text = "";
                txtDec.Text = "";
                txtHex.Text = "";
                txtASCII.Text = "";
            }
        }

        private void txtDec_Enter(object sender, EventArgs e)
        {
            if (txtDec.ReadOnly)
            {
                txtBin.ReadOnly = false;
                txtDec.ReadOnly = false;
                txtHex.ReadOnly = false;
                txtASCII.ReadOnly = false;
                txtBin.Text = "";
                txtDec.Text = "";
                txtHex.Text = "";
                txtASCII.Text = "";
            }
        }

        private void txtASCII_Enter(object sender, EventArgs e)
        {
            txtBin.ReadOnly = false;
            txtDec.ReadOnly = false;
            txtHex.ReadOnly = false;
            txtASCII.ReadOnly = false;
            txtBin.Text = "";
            txtDec.Text = "";
            txtHex.Text = "";
            txtASCII.Text = "";
        }
        #endregion textBoxEnterHandlers

        private void btnConvert_Click(object sender, System.EventArgs e)
        {
            if (txtBin.Text != "" || txtDec.Text != "" || txtHex.Text != "" || txtASCII.Text != "")
            {
                if (!txtBin.ReadOnly)
                {
                    txtDec.Text = Convert.ToString(Convert.ToInt64(txtBin.Text, bin));
                    txtHex.Text = @"0x" + Convert.ToString(Convert.ToInt64(txtDec.Text, dec), hex).ToUpper();
                    txtBin.Text = @"0b" + txtBin.Text;
                    btnConvert.Focus();
                }
                else if (!txtDec.ReadOnly)
                {
                    txtBin.Text = @"0b" + Convert.ToString(Convert.ToInt64(txtDec.Text, dec), bin);
                    txtHex.Text = @"0x" + Convert.ToString(Convert.ToInt64(txtDec.Text, dec), hex).ToUpper();
                    btnConvert.Focus();
                }
                else if (!txtHex.ReadOnly)
                {
                    txtDec.Text = Convert.ToString(Convert.ToInt64(txtHex.Text, hex), dec);
                    txtBin.Text = @"0b" + Convert.ToString(Convert.ToInt64(txtHex.Text, hex), bin);
                    if (!txtHex.Text.Contains("0x"))
                    {
                        txtHex.Text = @"0x" + txtHex.Text.ToUpper();
                    }
                    btnConvert.Focus();
                }
                else
                {
                    char temp = Convert.ToChar(txtASCII.Text);
                    charValue = Convert.ToInt64(temp);
                    // MessageBox.Show(charValue.ToString());
                    txtDec.Text = Convert.ToString(charValue);
                    txtBin.Text = @"0b" + Convert.ToString(Convert.ToInt64(charValue), bin);
                    txtHex.Text = @"0x" + Convert.ToString(Convert.ToInt64(charValue), hex);
                    btnConvert.Focus();
                }
                try
                {
                    char inputted = (char)Convert.ToInt32(txtDec.Text);
                    txtASCII.Text = inputted.ToString();
                }
                catch 
                {
                    return;
                }
            }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtASCII.Text != "")
            {
                Clipboard.SetText(txtASCII.Text);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
