using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void AddSkill(Control.ControlCollection controls, int x, int y, Label modBonus )
        {
            var label = new Label
            {
                Location = new Point(x + 30, y),
                BackColor = Color.White,
                AutoSize = true,
                Text = "+0"
            };

            var checkBox = new RoundCheckBox
            {
                Radius = 27,
                Location = new Point(x, y),
                LinkedLabel = label,
                ProfBonus = ProfBonus,
                ModBonus = modBonus
            };

            controls.Add(label);
            controls.Add(checkBox);
        }

        private void AddST(Control.ControlCollection controls, int x, int y, Label modBonus )
        {
            var label = new Label
            {
                Location = new Point(x - 60, y + 15),
                Font = new Font("Book Antiqua", 14F, FontStyle.Regular, GraphicsUnit.Point, 204),
                BackColor = Color.Transparent,
                AutoSize = true,
                Text = "+0"
            };

            var checkBox = new RoundCheckBox
            {
                Radius = 33,
                Location = new Point(x, y),
                LinkedLabel = label,
                ProfBonus = ProfBonus,
                ModBonus = modBonus
            };

            controls.Add(label);
            controls.Add(checkBox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            AddSkill(this.Controls, 727, 545, DexMod); //
            AddSkill(this.Controls, 727, 588, WisMod); //
            AddSkill(this.Controls, 727, 630, IntMod); //
            AddSkill(this.Controls, 727, 672, StrMod); //
            AddSkill(this.Controls, 727, 714, ChaMod);
            AddSkill(this.Controls, 727, 756, IntMod);
            AddSkill(this.Controls, 727, 798, WisMod);
            AddSkill(this.Controls, 727, 840, ChaMod);
            AddSkill(this.Controls, 727, 882, IntMod); //
            AddSkill(this.Controls, 727, 924, WisMod); //
            AddSkill(this.Controls, 727, 966, IntMod); //
            AddSkill(this.Controls, 727, 1008, WisMod); //
            AddSkill(this.Controls, 727, 1050, ChaMod);
            AddSkill(this.Controls, 727, 1092, ChaMod);
            AddSkill(this.Controls, 727, 1134, IntMod);
            AddSkill(this.Controls, 727, 1176, WisMod);
            AddSkill(this.Controls, 727, 1218, DexMod);
            AddSkill(this.Controls, 727, 1258, WisMod);

            AddST(this.Controls, 418, 355, StrMod); // nice
            AddST(this.Controls, 418, 430, DexMod);
            AddST(this.Controls, 418, 505, ConMod); // nice
            AddST(this.Controls, 418, 580, IntMod);
            AddST(this.Controls, 418, 655, WisMod);
            AddST(this.Controls, 418, 730, ChaMod);
        }


        private void Level_ValueChanged(object sender, EventArgs e)
        {
            // добавить изменение хитов, после класса
            switch ((int)Level.Value)
            {
                case >= 5 and <= 8:
                    ProfBonus.Text = "3";
                    break;
                case >= 9 and <= 12:
                    ProfBonus.Text = "4";
                    break;
                case >= 13 and <= 16:
                    ProfBonus.Text = "5";
                    break;
                case >= 17:
                    ProfBonus.Text = "6";
                    break;
                default:
                    ProfBonus.Text = "2";
                    break;
            }
        }
        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // оставлено пустым
        }

        private void StrValue_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(StrValue.Text, out int mod))
            {
                mod -= 10;
                mod /= 2;
                if (mod >= 0)
                    StrMod.Text = $"+{mod}";
                else
                    StrMod.Text = $"{mod}";
            }
            else
                StrMod.Text = "+0";
        }
        private void DexValue_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(DexValue.Text, out int mod))
            {
                mod -= 10;
                mod /= 2;
                if (mod >= 0)
                    DexMod.Text = $"+{mod}";
                else
                    DexMod.Text = $"{mod}";
            }
            else
                DexMod.Text = "+0";
        }
        /* зависит от класа
         * [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int HealthVal
        {
            get
            {
                if (int.TryParse(источник, out int value))
                    return value;
                return 0;
            }
            set
            {
                Health.Text = value.ToString();
            }
        }
        */
        private void ConValue_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(ConValue.Text.Replace("+", ""), out int mod))
                mod = 0;

            mod -= 10;
            mod /= 2;
            int val = 8;
            Health.Text = $"{val + mod}";
            // Health.Text = $"{HealthVal + mod}"; - зависит от класса
            if (mod >= 0)
                ConMod.Text = $"+{mod}";
            else
                ConMod.Text = $"{mod}";
        }
        private void IntValue_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(IntValue.Text, out int mod))
            {
                mod -= 10;
                mod /= 2;
                if (mod >= 0)
                    IntMod.Text = $"+{mod}";
                else
                    IntMod.Text = $"{mod}";
            }
            else
                IntMod.Text = "+0";
        }
        private void WisValue_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(WisValue.Text, out int mod))
            {
                mod -= 10;
                mod /= 2;
                if (mod >= 0)
                    WisMod.Text = $"+{mod}";
                else
                    WisMod.Text = $"{mod}";
            }
            else
                WisMod.Text = "+0";
        }
        private void ChaValue_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ChaValue.Text, out int mod))
            {
                mod -= 10;
                mod /= 2;
                if (mod >= 0)
                    ChaMod.Text = $"+{mod}";
                else
                    ChaMod.Text = $"{mod}";
            }
            else
                ChaMod.Text = "+0";
        }

    }
}


