namespace Pracownicy
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePickerDoB = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            numericUpDownSalary = new NumericUpDown();
            comboBoxPosition = new ComboBox();
            panelCBTypeOfContract = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            propertyGrid1 = new PropertyGrid();
            radioButton1 = new RadioButton();
            buttonAdd = new Button();
            errorProvider = new ErrorProvider(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonSave = new Button();
            buttonLoad = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            listBoxDisplay = new ListBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalary).BeginInit();
            panelCBTypeOfContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 431);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane Pracownika";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel4.Controls.Add(buttonAdd, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.Size = new Size(366, 409);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Controls.Add(textBoxSurname, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxName, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(dateTimePickerDoB, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(numericUpDownSalary, 1, 3);
            tableLayoutPanel1.Controls.Add(comboBoxPosition, 1, 4);
            tableLayoutPanel1.Controls.Add(panelCBTypeOfContract, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(360, 362);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Dock = DockStyle.Fill;
            textBoxSurname.Location = new Point(103, 39);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(228, 23);
            textBoxSurname.TabIndex = 7;
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Fill;
            textBoxName.Location = new Point(103, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(228, 23);
            textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 36);
            label1.TabIndex = 0;
            label1.Text = "Imię:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(60, 36);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko:";
            // 
            // dateTimePickerDoB
            // 
            dateTimePickerDoB.Dock = DockStyle.Fill;
            dateTimePickerDoB.Location = new Point(103, 75);
            dateTimePickerDoB.MaxDate = new DateTime(2023, 4, 1, 0, 0, 0, 0);
            dateTimePickerDoB.MinDate = new DateTime(1800, 1, 1, 0, 0, 0, 0);
            dateTimePickerDoB.Name = "dateTimePickerDoB";
            dateTimePickerDoB.Size = new Size(228, 23);
            dateTimePickerDoB.TabIndex = 8;
            dateTimePickerDoB.Value = new DateTime(2023, 4, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Location = new Point(3, 72);
            label3.Name = "label3";
            label3.Size = new Size(90, 36);
            label3.TabIndex = 3;
            label3.Text = "Data Urodzenia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Location = new Point(3, 108);
            label4.Name = "label4";
            label4.Size = new Size(44, 36);
            label4.TabIndex = 4;
            label4.Text = "Pensja:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Location = new Point(3, 180);
            label6.Name = "label6";
            label6.Size = new Size(88, 182);
            label6.TabIndex = 6;
            label6.Text = "Rodzaj umowy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Location = new Point(3, 144);
            label5.Name = "label5";
            label5.Size = new Size(70, 36);
            label5.TabIndex = 5;
            label5.Text = "Stanowisko:";
            // 
            // numericUpDownSalary
            // 
            numericUpDownSalary.Dock = DockStyle.Fill;
            numericUpDownSalary.Location = new Point(103, 111);
            numericUpDownSalary.Maximum = new decimal(new int[] { 15000, 0, 0, 0 });
            numericUpDownSalary.Name = "numericUpDownSalary";
            numericUpDownSalary.Size = new Size(228, 23);
            numericUpDownSalary.TabIndex = 9;
            // 
            // comboBoxPosition
            // 
            comboBoxPosition.Dock = DockStyle.Fill;
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Items.AddRange(new object[] { "Tester", "Projektant", "Inżynier", "Młodszy programista", "Starszy programista" });
            comboBoxPosition.Location = new Point(103, 147);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(228, 23);
            comboBoxPosition.TabIndex = 10;
            // 
            // panelCBTypeOfContract
            // 
            panelCBTypeOfContract.Controls.Add(radioButton3);
            panelCBTypeOfContract.Controls.Add(radioButton2);
            panelCBTypeOfContract.Controls.Add(propertyGrid1);
            panelCBTypeOfContract.Controls.Add(radioButton1);
            panelCBTypeOfContract.Dock = DockStyle.Fill;
            panelCBTypeOfContract.Location = new Point(103, 183);
            panelCBTypeOfContract.Name = "panelCBTypeOfContract";
            panelCBTypeOfContract.Size = new Size(228, 176);
            panelCBTypeOfContract.TabIndex = 11;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(3, 53);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(110, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "umowa zlecenie";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(3, 28);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(160, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "umowa na czas określony\r\n";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            propertyGrid1.Location = new Point(60, 98);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(8, 8);
            propertyGrid1.TabIndex = 1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(176, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "umowa na czas nieokreślony";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Location = new Point(3, 371);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(360, 35);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Dodaj";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(378, 486);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(buttonSave, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonLoad, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 440);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(372, 43);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Fill;
            buttonSave.Location = new Point(3, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(180, 37);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Zapisz";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Dock = DockStyle.Fill;
            buttonLoad.Location = new Point(189, 3);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(180, 37);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Wczytaj";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel5.Controls.Add(listBoxDisplay, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1014, 492);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // listBoxDisplay
            // 
            listBoxDisplay.Dock = DockStyle.Fill;
            listBoxDisplay.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxDisplay.ItemHeight = 20;
            listBoxDisplay.Location = new Point(387, 3);
            listBoxDisplay.Name = "listBoxDisplay";
            listBoxDisplay.Size = new Size(624, 486);
            listBoxDisplay.TabIndex = 2;
            listBoxDisplay.SelectedIndexChanged += listBoxDisplay_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 492);
            Controls.Add(tableLayoutPanel5);
            Name = "Form1";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalary).EndInit();
            panelCBTypeOfContract.ResumeLayout(false);
            panelCBTypeOfContract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxName;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxSurname;
        private DateTimePicker dateTimePickerDoB;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private NumericUpDown numericUpDownSalary;
        private ComboBox comboBoxPosition;
        private ErrorProvider errorProvider;
        private Panel panelCBTypeOfContract;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private PropertyGrid propertyGrid1;
        private RadioButton radioButton1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Button buttonAdd;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private Button buttonSave;
        private Button buttonLoad;
        private ListBox listBoxDisplay;
    }
}