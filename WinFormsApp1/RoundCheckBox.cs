using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class RoundCheckBox : CheckBox
{
    private int radius = 30;
    private Label linkedLabel;
    private Label profBonus;
    private Label modBonus;


    [Category("Appearance")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int Radius
    {
        get => radius;
        set
        {
            radius = value;
            this.Width = radius;
            this.Height = radius;
            Invalidate();
        }
    }

    [Category("Behavior")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Label LinkedLabel
    {
        get => linkedLabel;
        set
        {
            linkedLabel = value;
            UpdateLinkedLabel();
        }
    }

    [Category("Behavior")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Label ProfBonus
    {
        get => profBonus;
        set
        {
            if (profBonus != null)
                profBonus.TextChanged -= ProfBonus_TextChanged;

            profBonus = value;

            if (profBonus != null)
                profBonus.TextChanged += ProfBonus_TextChanged;
        }
    }

    [Category("Behavior")]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Label ModBonus
    {
        get => modBonus;
        set
        {
            if (modBonus != null)
                modBonus.TextChanged -= ModBonus_TextChanged;

            modBonus = value;

            if (modBonus != null)
                modBonus.TextChanged += ModBonus_TextChanged;
            UpdateLinkedLabel();
        }
    }

    public RoundCheckBox()
    {
        this.Appearance = Appearance.Button;
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.Text = "";
        this.Width = radius;
        this.Height = radius;

        this.CheckedChanged += RoundCheckBox_CheckedChanged;
    }


    private void RoundCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        UpdateLinkedLabel();
    }

    private void ModBonus_TextChanged(object sender, EventArgs e)
    {
        UpdateLinkedLabel();
    }


    private void ProfBonus_TextChanged(object sender, EventArgs e)
    {
        if (this.Checked)
        {
            UpdateLinkedLabel();
        }
    }


    private void UpdateLinkedLabel()
    {
        if (linkedLabel == null || profBonus == null || modBonus == null)
            return;

        if (!int.TryParse(modBonus.Text.Replace("+", ""), out int mod))
            mod = 0;

        if (!int.TryParse(profBonus.Text.Replace("+", ""), out int bonus))
            bonus = 0;

        if (this.Checked)
        {
            int newValue = mod + bonus;
            linkedLabel.Text = newValue >= 0 ? $"+{newValue}" : $"{newValue}";
        }
        else
        {
            linkedLabel.Text = mod >= 0 ? $"+{mod}" : $"{mod}";
        }
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        Graphics g = pevent.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        Color fillColor = this.Checked ? Color.LightBlue : Color.White;
        Color borderColor = Color.Black;

        using (SolidBrush brush = new SolidBrush(fillColor))
        {
            g.FillEllipse(brush, 0, 0, radius - 1, radius - 1);
        }

        using (Pen pen = new Pen(borderColor, 3))
        {
            g.DrawEllipse(pen, 0, 0, radius - 1, radius - 1);
        }
    }
}