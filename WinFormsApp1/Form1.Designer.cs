namespace WinFormsApp1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        TextBox name;
        Label Race;
        Label Class;
        Label lvl;
        Label labelBack;
        Label label1;
        Label label2;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        contextMenuStrip1 = new ContextMenuStrip(components);
        contextMenuStrip2 = new ContextMenuStrip(components);
        toolStripMenuItem1 = new ToolStripMenuItem();
        Rase = new ComboBox();
        comboBox1 = new ComboBox();
        Level = new NumericUpDown();
        background = new ComboBox();
        ProfBonus = new Label();
        StrMod = new Label();
        DexMod = new Label();
        ConMod = new Label();
        IntMod = new Label();
        WisMod = new Label();
        ChaMod = new Label();
        DexValue = new TextBox();
        IntValue = new TextBox();
        ConValue = new TextBox();
        StrValue = new TextBox();
        ChaValue = new TextBox();
        WisValue = new TextBox();
        LSRolls1 = new RadioButton();
        radioButton1 = new RadioButton();
        radioButton2 = new RadioButton();
        radioButton3 = new RadioButton();
        Health = new Label();
        name = new TextBox();
        Race = new Label();
        Class = new Label();
        lvl = new Label();
        labelBack = new Label();
        label1 = new Label();
        label2 = new Label();
        contextMenuStrip2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)Level).BeginInit();
        SuspendLayout();
        // 
        // name
        // 
        name.AccessibleRole = AccessibleRole.None;
        name.AllowDrop = true;
        name.BorderStyle = BorderStyle.None;
        name.Cursor = Cursors.IBeam;
        name.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
        name.Location = new Point(205, 40);
        name.Name = "name";
        name.Size = new Size(400, 60);
        name.TabIndex = 8;
        name.TextAlign = HorizontalAlignment.Center;
        // 
        // Race
        // 
        Race.AutoSize = true;
        Race.BackColor = SystemColors.ButtonHighlight;
        Race.ForeColor = SystemColors.ButtonShadow;
        Race.Location = new Point(85, 179);
        Race.Name = "Race";
        Race.Size = new Size(63, 28);
        Race.TabIndex = 5;
        Race.Text = "Race";
        // 
        // Class
        // 
        Class.AutoSize = true;
        Class.BackColor = SystemColors.ButtonHighlight;
        Class.ForeColor = SystemColors.ButtonShadow;
        Class.Location = new Point(282, 179);
        Class.Name = "Class";
        Class.Size = new Size(68, 28);
        Class.TabIndex = 6;
        Class.Text = "Class";
        // 
        // lvl
        // 
        lvl.AutoSize = true;
        lvl.BackColor = SystemColors.ButtonHighlight;
        lvl.ForeColor = SystemColors.ButtonShadow;
        lvl.Location = new Point(481, 177);
        lvl.Name = "lvl";
        lvl.Size = new Size(40, 28);
        lvl.TabIndex = 7;
        lvl.Text = "lvl";
        // 
        // labelBack
        // 
        labelBack.AutoSize = true;
        labelBack.BackColor = SystemColors.ButtonHighlight;
        labelBack.ForeColor = SystemColors.ButtonShadow;
        labelBack.Location = new Point(556, 177);
        labelBack.Name = "labelBack";
        labelBack.Size = new Size(141, 28);
        labelBack.TabIndex = 10;
        labelBack.Text = "Background";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = SystemColors.ButtonHighlight;
        label1.ForeColor = SystemColors.ButtonShadow;
        label1.Location = new Point(534, 645);
        label1.Name = "label1";
        label1.Size = new Size(92, 28);
        label1.TabIndex = 34;
        label1.Text = "hit dice";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = SystemColors.ButtonHighlight;
        label2.ForeColor = SystemColors.ActiveCaptionText;
        label2.Location = new Point(508, 549);
        label2.Name = "label2";
        label2.Size = new Size(144, 28);
        label2.TabIndex = 35;
        label2.Text = "total: ______";
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.ImageScalingSize = new Size(32, 32);
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(61, 4);
        // 
        // contextMenuStrip2
        // 
        contextMenuStrip2.ImageScalingSize = new Size(32, 32);
        contextMenuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
        contextMenuStrip2.Name = "contextMenuStrip2";
        contextMenuStrip2.Size = new Size(303, 42);
        contextMenuStrip2.Opening += contextMenuStrip2_Opening;
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(302, 38);
        toolStripMenuItem1.Text = "toolStripMenuItem1";
        // 
        // Rase
        // 
        Rase.FormattingEnabled = true;
        Rase.Items.AddRange(new object[] { "Dwarf", "Gnome", "Tiefling", "Half-Elf", "Human", "Elf", "Halfling", "Half-Orc", "Dragonborn" });
        Rase.Location = new Point(85, 211);
        Rase.Name = "Rase";
        Rase.Size = new Size(191, 36);
        Rase.TabIndex = 2;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" });
        comboBox1.Location = new Point(282, 209);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(193, 36);
        comboBox1.TabIndex = 3;
        // 
        // Level
        // 
        Level.Location = new Point(481, 208);
        Level.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
        Level.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        Level.Name = "Level";
        Level.Size = new Size(69, 37);
        Level.TabIndex = 4;
        Level.Value = new decimal(new int[] { 1, 0, 0, 0 });
        Level.ValueChanged += Level_ValueChanged;
        // 
        // background
        // 
        background.FormattingEnabled = true;
        background.Items.AddRange(new object[] { "Acolyte", "Charlatan", "Criminal", "Entertainer", "Folk Hero", "Guild Artisan", "Hermit", "Outlander", "Noble", "Sage", "Sailor", "Soldier", "Urchin", "Custom" });
        background.Location = new Point(556, 207);
        background.Name = "background";
        background.Size = new Size(182, 36);
        background.TabIndex = 9;
        // 
        // ProfBonus
        // 
        ProfBonus.AutoSize = true;
        ProfBonus.BackColor = SystemColors.ButtonHighlight;
        ProfBonus.Font = new Font("Book Antiqua", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
        ProfBonus.Location = new Point(1019, 399);
        ProfBonus.Name = "ProfBonus";
        ProfBonus.Size = new Size(39, 46);
        ProfBonus.TabIndex = 11;
        ProfBonus.Text = "2";
        // 
        // StrMod
        // 
        StrMod.AutoSize = true;
        StrMod.BackColor = Color.Transparent;
        StrMod.Font = new Font("Book Antiqua", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
        StrMod.Location = new Point(98, 343);
        StrMod.Name = "StrMod";
        StrMod.Size = new Size(70, 51);
        StrMod.TabIndex = 12;
        StrMod.Text = "+0";
        // 
        // DexMod
        // 
        DexMod.AutoSize = true;
        DexMod.BackColor = Color.Transparent;
        DexMod.Font = new Font("Book Antiqua", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
        DexMod.Location = new Point(98, 483);
        DexMod.Name = "DexMod";
        DexMod.Size = new Size(70, 51);
        DexMod.TabIndex = 13;
        DexMod.Text = "+0";
        // 
        // ConMod
        // 
        ConMod.AutoSize = true;
        ConMod.BackColor = Color.Transparent;
        ConMod.Font = new Font("Book Antiqua", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
        ConMod.Location = new Point(98, 622);
        ConMod.Name = "ConMod";
        ConMod.Size = new Size(70, 51);
        ConMod.TabIndex = 14;
        ConMod.Text = "+0";
        // 
        // IntMod
        // 
        IntMod.AutoSize = true;
        IntMod.BackColor = Color.Transparent;
        IntMod.Font = new Font("Book Antiqua", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
        IntMod.Location = new Point(98, 761);
        IntMod.Name = "IntMod";
        IntMod.Size = new Size(70, 51);
        IntMod.TabIndex = 15;
        IntMod.Text = "+0";
        // 
        // WisMod
        // 
        WisMod.AutoSize = true;
        WisMod.BackColor = Color.Transparent;
        WisMod.Font = new Font("Book Antiqua", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
        WisMod.Location = new Point(98, 902);
        WisMod.Name = "WisMod";
        WisMod.Size = new Size(70, 51);
        WisMod.TabIndex = 16;
        WisMod.Text = "+0";
        // 
        // ChaMod
        // 
        ChaMod.AutoSize = true;
        ChaMod.BackColor = Color.Transparent;
        ChaMod.Font = new Font("Book Antiqua", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
        ChaMod.Location = new Point(98, 1041);
        ChaMod.Name = "ChaMod";
        ChaMod.Size = new Size(70, 51);
        ChaMod.TabIndex = 17;
        ChaMod.Text = "+0";
        // 
        // DexValue
        // 
        DexValue.BorderStyle = BorderStyle.None;
        DexValue.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        DexValue.ForeColor = Color.Black;
        DexValue.Location = new Point(179, 517);
        DexValue.Name = "DexValue";
        DexValue.PlaceholderText = "0";
        DexValue.Size = new Size(37, 40);
        DexValue.TabIndex = 24;
        DexValue.TextAlign = HorizontalAlignment.Center;
        DexValue.TextChanged += DexValue_TextChanged;
        // 
        // IntValue
        // 
        IntValue.BorderStyle = BorderStyle.None;
        IntValue.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        IntValue.ForeColor = Color.Black;
        IntValue.Location = new Point(179, 795);
        IntValue.Name = "IntValue";
        IntValue.PlaceholderText = "0";
        IntValue.Size = new Size(37, 40);
        IntValue.TabIndex = 25;
        IntValue.TextAlign = HorizontalAlignment.Center;
        IntValue.TextChanged += IntValue_TextChanged;
        // 
        // ConValue
        // 
        ConValue.BorderStyle = BorderStyle.None;
        ConValue.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        ConValue.ForeColor = Color.Black;
        ConValue.Location = new Point(179, 655);
        ConValue.Name = "ConValue";
        ConValue.PlaceholderText = "0";
        ConValue.Size = new Size(37, 40);
        ConValue.TabIndex = 26;
        ConValue.TextAlign = HorizontalAlignment.Center;
        ConValue.TextChanged += ConValue_TextChanged;
        // 
        // StrValue
        // 
        StrValue.BorderStyle = BorderStyle.None;
        StrValue.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        StrValue.ForeColor = Color.Black;
        StrValue.Location = new Point(179, 377);
        StrValue.Name = "StrValue";
        StrValue.PlaceholderText = "0";
        StrValue.Size = new Size(37, 40);
        StrValue.TabIndex = 27;
        StrValue.TextAlign = HorizontalAlignment.Center;
        StrValue.TextChanged += StrValue_TextChanged;
        // 
        // ChaValue
        // 
        ChaValue.BorderStyle = BorderStyle.None;
        ChaValue.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        ChaValue.ForeColor = Color.Black;
        ChaValue.Location = new Point(179, 1073);
        ChaValue.Name = "ChaValue";
        ChaValue.PlaceholderText = "0";
        ChaValue.Size = new Size(37, 40);
        ChaValue.TabIndex = 28;
        ChaValue.TextAlign = HorizontalAlignment.Center;
        ChaValue.TextChanged += ChaValue_TextChanged;
        // 
        // WisValue
        // 
        WisValue.BorderStyle = BorderStyle.None;
        WisValue.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        WisValue.ForeColor = Color.Black;
        WisValue.Location = new Point(179, 935);
        WisValue.Name = "WisValue";
        WisValue.PlaceholderText = "0";
        WisValue.Size = new Size(37, 40);
        WisValue.TabIndex = 29;
        WisValue.TextAlign = HorizontalAlignment.Center;
        WisValue.TextChanged += WisValue_TextChanged;
        // 
        // LSRolls1
        // 
        LSRolls1.AutoSize = true;
        LSRolls1.Location = new Point(523, 708);
        LSRolls1.Name = "LSRolls1";
        LSRolls1.Size = new Size(27, 26);
        LSRolls1.TabIndex = 30;
        LSRolls1.TabStop = true;
        LSRolls1.UseVisualStyleBackColor = true;
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Location = new Point(566, 708);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(27, 26);
        radioButton1.TabIndex = 31;
        radioButton1.TabStop = true;
        radioButton1.UseVisualStyleBackColor = true;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Location = new Point(525, 760);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(27, 26);
        radioButton2.TabIndex = 32;
        radioButton2.TabStop = true;
        radioButton2.UseVisualStyleBackColor = true;
        // 
        // radioButton3
        // 
        radioButton3.AutoSize = true;
        radioButton3.Location = new Point(566, 759);
        radioButton3.Name = "radioButton3";
        radioButton3.Size = new Size(27, 26);
        radioButton3.TabIndex = 33;
        radioButton3.TabStop = true;
        radioButton3.UseVisualStyleBackColor = true;
        // 
        // Health
        // 
        Health.BackColor = Color.Transparent;
        Health.Font = new Font("Book Antiqua", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
        Health.Location = new Point(543, 445);
        Health.Name = "Health";
        Health.Size = new Size(81, 46);
        Health.TabIndex = 36;
        Health.Text = "8";
        Health.TextAlign = ContentAlignment.TopCenter;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(14F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(1111, 1597);
        Controls.Add(Health);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(radioButton3);
        Controls.Add(radioButton2);
        Controls.Add(radioButton1);
        Controls.Add(LSRolls1);
        Controls.Add(WisValue);
        Controls.Add(ChaValue);
        Controls.Add(StrValue);
        Controls.Add(ConValue);
        Controls.Add(IntValue);
        Controls.Add(DexValue);
        Controls.Add(ChaMod);
        Controls.Add(WisMod);
        Controls.Add(IntMod);
        Controls.Add(ConMod);
        Controls.Add(DexMod);
        Controls.Add(StrMod);
        Controls.Add(ProfBonus);
        Controls.Add(labelBack);
        Controls.Add(background);
        Controls.Add(name);
        Controls.Add(lvl);
        Controls.Add(Class);
        Controls.Add(Race);
        Controls.Add(Level);
        Controls.Add(comboBox1);
        Controls.Add(Rase);
        Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        contextMenuStrip2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)Level).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;

    #endregion

    private ComboBox Rase;
    private ComboBox comboBox1;
    private NumericUpDown Level;
    private Label Race;
    private Label Class;
    private Label lvl;
    private ComboBox background;
    private Label labelBack;
    private Label ProfBonus;
    private RadioButton radioButton2;
    private RadioButton radioButton3;
    private Label StrMod;
    private Label DexMod;
    private Label ConMod;
    private Label IntMod;
    private Label WisMod;
    private Label ChaMod;
    private TextBox DexValue;
    private TextBox IntValue;
    private TextBox ConValue;
    private TextBox StrValue;
    private TextBox ChaValue;
    private TextBox WisValue;
    private RadioButton LSRolls1;
    private RadioButton radioButton1;
    private Label Health;
}