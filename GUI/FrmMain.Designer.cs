
namespace GUI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TxtResultOperation = new System.Windows.Forms.TextBox();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.NumUpDownDenominatorRight = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownDenominatorLeft = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownNumeratorRight = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownNumeratorLeft = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownNumberRight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NumUpDownNumberLeft = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnCompare = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NumUpDownCmpDenominatorRight = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownCmpNumeratorRight = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownCmpNumberRight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCmpResult = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NumUpDownCmpDenominatorLeft = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownCmpNumberLeft = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownCmpNumeratorLeft = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDenominatorRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDenominatorLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownNumeratorRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownNumeratorLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownNumberRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownNumberLeft)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCmpDenominatorRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCmpNumeratorRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCmpNumberRight)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCmpDenominatorLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCmpNumberLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCmpNumeratorLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 259);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.comboBoxOperator);
            this.tabPage1.Controls.Add(this.NumUpDownDenominatorRight);
            this.tabPage1.Controls.Add(this.NumUpDownDenominatorLeft);
            this.tabPage1.Controls.Add(this.NumUpDownNumeratorRight);
            this.tabPage1.Controls.Add(this.NumUpDownNumeratorLeft);
            this.tabPage1.Controls.Add(this.NumUpDownNumberRight);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.NumUpDownNumberLeft);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arithmétique";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnCalculate);
            this.groupBox3.Controls.Add(this.TxtResultOperation);
            this.groupBox3.Location = new System.Drawing.Point(8, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 105);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Résultat";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(24, 44);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(207, 26);
            this.BtnCalculate.TabIndex = 12;
            this.BtnCalculate.Text = "Calculer";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // TxtResultOperation
            // 
            this.TxtResultOperation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtResultOperation.Location = new System.Drawing.Point(354, 44);
            this.TxtResultOperation.Name = "TxtResultOperation";
            this.TxtResultOperation.ReadOnly = true;
            this.TxtResultOperation.Size = new System.Drawing.Size(197, 27);
            this.TxtResultOperation.TabIndex = 13;
            this.TxtResultOperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperator.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.ItemHeight = 37;
            this.comboBoxOperator.Items.AddRange(new object[] {
            " +",
            " -",
            " *",
            " /"});
            this.comboBoxOperator.Location = new System.Drawing.Point(269, 30);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(59, 45);
            this.comboBoxOperator.TabIndex = 5;
            this.comboBoxOperator.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperator_SelectedIndexChanged);
            // 
            // NumUpDownDenominatorRight
            // 
            this.NumUpDownDenominatorRight.Location = new System.Drawing.Point(483, 68);
            this.NumUpDownDenominatorRight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumUpDownDenominatorRight.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NumUpDownDenominatorRight.Name = "NumUpDownDenominatorRight";
            this.NumUpDownDenominatorRight.Size = new System.Drawing.Size(76, 23);
            this.NumUpDownDenominatorRight.TabIndex = 10;
            this.NumUpDownDenominatorRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUpDownDenominatorRight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDownDenominatorRight.ValueChanged += new System.EventHandler(this.NumUpDownOperation_ValueChanged);
            this.NumUpDownDenominatorRight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUpDownOperation_KeyPress);
            // 
            // NumUpDownDenominatorLeft
            // 
            this.NumUpDownDenominatorLeft.Location = new System.Drawing.Point(129, 68);
            this.NumUpDownDenominatorLeft.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumUpDownDenominatorLeft.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NumUpDownDenominatorLeft.Name = "NumUpDownDenominatorLeft";
            this.NumUpDownDenominatorLeft.Size = new System.Drawing.Size(76, 23);
            this.NumUpDownDenominatorLeft.TabIndex = 4;
            this.NumUpDownDenominatorLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUpDownDenominatorLeft.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDownDenominatorLeft.ValueChanged += new System.EventHandler(this.NumUpDownOperation_ValueChanged);
            this.NumUpDownDenominatorLeft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUpDownOperation_KeyPress);
            // 
            // NumUpDownNumeratorRight
            // 
            this.NumUpDownNumeratorRight.Location = new System.Drawing.Point(483, 30);
            this.NumUpDownNumeratorRight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumUpDownNumeratorRight.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NumUpDownNumeratorRight.Name = "NumUpDownNumeratorRight";
            this.NumUpDownNumeratorRight.Size = new System.Drawing.Size(76, 23);
            this.NumUpDownNumeratorRight.TabIndex = 8;
            this.NumUpDownNumeratorRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUpDownNumeratorRight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDownNumeratorRight.ValueChanged += new System.EventHandler(this.NumUpDownOperation_ValueChanged);
            this.NumUpDownNumeratorRight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUpDownOperation_KeyPress);
            // 
            // NumUpDownNumeratorLeft
            // 
            this.NumUpDownNumeratorLeft.Location = new System.Drawing.Point(129, 30);
            this.NumUpDownNumeratorLeft.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumUpDownNumeratorLeft.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NumUpDownNumeratorLeft.Name = "NumUpDownNumeratorLeft";
            this.NumUpDownNumeratorLeft.Size = new System.Drawing.Size(76, 23);
            this.NumUpDownNumeratorLeft.TabIndex = 2;
            this.NumUpDownNumeratorLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUpDownNumeratorLeft.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDownNumeratorLeft.ValueChanged += new System.EventHandler(this.NumUpDownOperation_ValueChanged);
            this.NumUpDownNumeratorLeft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUpDownOperation_KeyPress);
            // 
            // NumUpDownNumberRight
            // 
            this.NumUpDownNumberRight.Location = new System.Drawing.Point(386, 49);
            this.NumUpDownNumberRight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumUpDownNumberRight.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NumUpDownNumberRight.Name = "NumUpDownNumberRight";
            this.NumUpDownNumberRight.Size = new System.Drawing.Size(76, 23);
            this.NumUpDownNumberRight.TabIndex = 7;
            this.NumUpDownNumberRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumUpDownNumberRight.ValueChanged += new System.EventHandler(this.NumUpDownOperation_ValueChanged);
            this.NumUpDownNumberRight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUpDownOperation_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(470, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "________";
            // 
            // NumUpDownNumberLeft
            // 
            this.NumUpDownNumberLeft.Location = new System.Drawing.Point(32, 49);
            this.NumUpDownNumberLeft.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumUpDownNumberLeft.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NumUpDownNumberLeft.Name = "NumUpDownNumberLeft";
            this.NumUpDownNumberLeft.Size = new System.Drawing.Size(76, 23);
            this.NumUpDownNumberLeft.TabIndex = 1;
            this.NumUpDownNumberLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumUpDownNumberLeft.ValueChanged += new System.EventHandler(this.NumUpDownOperation_ValueChanged);
            this.NumUpDownNumberLeft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUpDownOperation_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(362, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 105);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fraction 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(116, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "________";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fraction 1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnCompare);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.comboBoxCmpResult);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comparaison";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnCompare
            // 
            this.BtnCompare.Location = new System.Drawing.Point(199, 161);
            this.BtnCompare.Name = "BtnCompare";
            this.BtnCompare.Size = new System.Drawing.Size(207, 26);
            this.BtnCompare.TabIndex = 11;
            this.BtnCompare.Text = "Comparer";
            this.BtnCompare.UseVisualStyleBackColor = true;
            this.BtnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.NumUpDownCmpDenominatorRight);
            this.groupBox5.Controls.Add(this.NumUpDownCmpNumeratorRight);
            this.groupBox5.Controls.Add(this.NumUpDownCmpNumberRight);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(362, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(231, 105);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fraction 2";
            // 
            // NumUpDownCmpDenominatorRight
            // 
            this.NumUpDownCmpDenominatorRight.Location = new System.Drawing.Point(121, 62);
            this.NumUpDownCmpDenominatorRight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumUpDownCmpDenominatorRight.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NumUpDownCmpDenominatorRight.Name = "NumUpDownCmpDenominatorRight";
            this.NumUpDownCmpDenominatorRight.Size = new System.Drawing.Size(76, 23);
            this.NumUpDownCmpDenominatorRight.TabIndex = 10;
            this.NumUpDownCmpDenominatorRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUpDownCmpDenominatorRight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDownCmpDenominatorRight.ValueChanged += new System.EventHandler(this.NumUpDownCmp_ValueChanged);
            this.NumUpDownCmpDenominatorRight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUpDownCmp_KeyPress);
            // 
            // NumUpDownCmpNumeratorRight
            // 
            this.NumUpDownCmpNumeratorRight.Location = new System.Drawing.Point(121, 24);
            this.NumUpDownCmpNumeratorRight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumUpDownCmpNumeratorRight.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NumUpDownCmpNumeratorRight.Name = "NumUpDownCmpNumeratorRight";
            this.NumUpDownCmpNumeratorRight.Size = new System.Drawing.Size(76, 23);
            this.NumUpDownCmpNumeratorRight.TabIndex = 8;
            this.NumUpDownCmpNumeratorRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUpDownCmpNumeratorRight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDownCmpNumeratorRight.ValueChanged += new System.EventHandler(this.NumUpDownCmp_ValueChanged);
            this.NumUpDownCmpNumeratorRight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUpDownCmp_KeyPress);
            // 
            // NumUpDownCmpNumberRight
            // 
            this.NumUpDownCmpNumberRight.Location = new System.Drawing.Point(24, 43);
            this.NumUpDownCmpNumberRight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumUpDownCmpNumberRight.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NumUpDownCmpNumberRight.Name = "NumUpDownCmpNumberRight";
            this.NumUpDownCmpNumberRight.Size = new System.Drawing.Size(76, 23);
            this.NumUpDownCmpNumberRight.TabIndex = 7;
            this.NumUpDownCmpNumberRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumUpDownCmpNumberRight.ValueChanged += new System.EventHandler(this.NumUpDownCmp_ValueChanged);
            this.NumUpDownCmpNumberRight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUpDownCmp_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(108, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "________";
            // 
            // comboBoxCmpResult
            // 
            this.comboBoxCmpResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxCmpResult.Enabled = false;
            this.comboBoxCmpResult.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCmpResult.FormattingEnabled = true;
            this.comboBoxCmpResult.ItemHeight = 37;
            this.comboBoxCmpResult.Items.AddRange(new object[] {
            "  <",
            "  =",
            "  >"});
            this.comboBoxCmpResult.Location = new System.Drawing.Point(269, 30);
            this.comboBoxCmpResult.Name = "comboBoxCmpResult";
            this.comboBoxCmpResult.Size = new System.Drawing.Size(59, 45);
            this.comboBoxCmpResult.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NumUpDownCmpDenominatorLeft);
            this.groupBox4.Controls.Add(this.NumUpDownCmpNumberLeft);
            this.groupBox4.Controls.Add(this.NumUpDownCmpNumeratorLeft);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 105);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fraction 1";
            // 
            // NumUpDownCmpDenominatorLeft
            // 
            this.NumUpDownCmpDenominatorLeft.Location = new System.Drawing.Point(121, 62);
            this.NumUpDownCmpDenominatorLeft.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumUpDownCmpDenominatorLeft.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NumUpDownCmpDenominatorLeft.Name = "NumUpDownCmpDenominatorLeft";
            this.NumUpDownCmpDenominatorLeft.Size = new System.Drawing.Size(76, 23);
            this.NumUpDownCmpDenominatorLeft.TabIndex = 4;
            this.NumUpDownCmpDenominatorLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUpDownCmpDenominatorLeft.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDownCmpDenominatorLeft.ValueChanged += new System.EventHandler(this.NumUpDownCmp_ValueChanged);
            this.NumUpDownCmpDenominatorLeft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUpDownCmp_KeyPress);
            // 
            // NumUpDownCmpNumberLeft
            // 
            this.NumUpDownCmpNumberLeft.Location = new System.Drawing.Point(24, 43);
            this.NumUpDownCmpNumberLeft.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumUpDownCmpNumberLeft.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NumUpDownCmpNumberLeft.Name = "NumUpDownCmpNumberLeft";
            this.NumUpDownCmpNumberLeft.Size = new System.Drawing.Size(76, 23);
            this.NumUpDownCmpNumberLeft.TabIndex = 1;
            this.NumUpDownCmpNumberLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumUpDownCmpNumberLeft.ValueChanged += new System.EventHandler(this.NumUpDownCmp_ValueChanged);
            this.NumUpDownCmpNumberLeft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUpDownCmp_KeyPress);
            // 
            // NumUpDownCmpNumeratorLeft
            // 
            this.NumUpDownCmpNumeratorLeft.Location = new System.Drawing.Point(121, 24);
            this.NumUpDownCmpNumeratorLeft.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumUpDownCmpNumeratorLeft.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.NumUpDownCmpNumeratorLeft.Name = "NumUpDownCmpNumeratorLeft";
            this.NumUpDownCmpNumeratorLeft.Size = new System.Drawing.Size(76, 23);
            this.NumUpDownCmpNumeratorLeft.TabIndex = 2;
            this.NumUpDownCmpNumeratorLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUpDownCmpNumeratorLeft.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDownCmpNumeratorLeft.ValueChanged += new System.EventHandler(this.NumUpDownCmp_ValueChanged);
            this.NumUpDownCmpNumeratorLeft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUpDownCmp_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(108, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "________";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 259);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMain";
            this.Text = "FractionWin";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDenominatorRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDenominatorLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownNumeratorRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownNumeratorLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownNumberRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownNumberLeft)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCmpDenominatorRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCmpNumeratorRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCmpNumberRight)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCmpDenominatorLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCmpNumberLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownCmpNumeratorLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown NumUpDownNumberLeft;
        private System.Windows.Forms.NumericUpDown NumUpDownDenominatorLeft;
        private System.Windows.Forms.NumericUpDown NumUpDownNumeratorLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.NumericUpDown NumUpDownDenominatorRight;
        private System.Windows.Forms.NumericUpDown NumUpDownNumeratorRight;
        private System.Windows.Forms.NumericUpDown NumUpDownNumberRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtResultOperation;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown NumUpDownCmpDenominatorLeft;
        private System.Windows.Forms.NumericUpDown NumUpDownCmpNumberLeft;
        private System.Windows.Forms.NumericUpDown NumUpDownCmpNumeratorLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCmpResult;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown NumUpDownCmpDenominatorRight;
        private System.Windows.Forms.NumericUpDown NumUpDownCmpNumeratorRight;
        private System.Windows.Forms.NumericUpDown NumUpDownCmpNumberRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCompare;
    }
}