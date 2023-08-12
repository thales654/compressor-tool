namespace CompressorTool.UI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            PanelVerticalPadding = new Panel();
            TLPContent = new TableLayoutPanel();
            TLPButtons = new TableLayoutPanel();
            BtnCancel = new Button();
            BtnOk = new Button();
            TLPTextBox = new TableLayoutPanel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            PanelVerticalPadding.SuspendLayout();
            TLPContent.SuspendLayout();
            TLPButtons.SuspendLayout();
            TLPTextBox.SuspendLayout();
            SuspendLayout();
            // 
            // PanelVerticalPadding
            // 
            PanelVerticalPadding.AutoSize = true;
            PanelVerticalPadding.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelVerticalPadding.BackColor = Color.Transparent;
            PanelVerticalPadding.Controls.Add(TLPContent);
            PanelVerticalPadding.Dock = DockStyle.Fill;
            PanelVerticalPadding.Location = new Point(0, 0);
            PanelVerticalPadding.Margin = new Padding(0);
            PanelVerticalPadding.Name = "PanelVerticalPadding";
            PanelVerticalPadding.Padding = new Padding(20, 0, 20, 20);
            PanelVerticalPadding.Size = new Size(602, 236);
            PanelVerticalPadding.TabIndex = 0;
            // 
            // TLPContent
            // 
            TLPContent.AutoSize = true;
            TLPContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TLPContent.ColumnCount = 1;
            TLPContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPContent.Controls.Add(TLPButtons, 0, 1);
            TLPContent.Controls.Add(TLPTextBox, 0, 0);
            TLPContent.Dock = DockStyle.Fill;
            TLPContent.Location = new Point(20, 0);
            TLPContent.Margin = new Padding(0);
            TLPContent.Name = "TLPContent";
            TLPContent.RowCount = 2;
            TLPContent.RowStyles.Add(new RowStyle(SizeType.Percent, 66.79389F));
            TLPContent.RowStyles.Add(new RowStyle(SizeType.Percent, 33.20611F));
            TLPContent.Size = new Size(562, 216);
            TLPContent.TabIndex = 0;
            // 
            // TLPButtons
            // 
            TLPButtons.AutoSize = true;
            TLPButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TLPButtons.BackColor = Color.FromArgb(0, 0, 0, 0);
            TLPButtons.ColumnCount = 3;
            TLPButtons.ColumnStyles.Add(new ColumnStyle());
            TLPButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TLPButtons.ColumnStyles.Add(new ColumnStyle());
            TLPButtons.Controls.Add(BtnCancel, 0, 1);
            TLPButtons.Controls.Add(BtnOk, 2, 1);
            TLPButtons.Dock = DockStyle.Fill;
            TLPButtons.Location = new Point(0, 144);
            TLPButtons.Margin = new Padding(0);
            TLPButtons.MinimumSize = new Size(400, 0);
            TLPButtons.Name = "TLPButtons";
            TLPButtons.RowCount = 2;
            TLPButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPButtons.RowStyles.Add(new RowStyle());
            TLPButtons.Size = new Size(562, 72);
            TLPButtons.TabIndex = 0;
            // 
            // BtnCancel
            // 
            BtnCancel.AutoSize = true;
            BtnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCancel.BackColor = Color.Brown;
            BtnCancel.Cursor = Cursors.Hand;
            BtnCancel.Dock = DockStyle.Fill;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCancel.Location = new Point(30, 13);
            BtnCancel.Margin = new Padding(30, 20, 0, 10);
            BtnCancel.MinimumSize = new Size(150, 0);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(150, 49);
            BtnCancel.TabIndex = 2;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnOk
            // 
            BtnOk.AutoSize = true;
            BtnOk.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnOk.BackColor = Color.LightSeaGreen;
            BtnOk.Cursor = Cursors.Hand;
            BtnOk.Dock = DockStyle.Fill;
            BtnOk.FlatStyle = FlatStyle.Flat;
            BtnOk.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnOk.Location = new Point(382, 13);
            BtnOk.Margin = new Padding(0, 20, 30, 10);
            BtnOk.MinimumSize = new Size(150, 0);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(150, 49);
            BtnOk.TabIndex = 1;
            BtnOk.TabStop = false;
            BtnOk.Text = "Ok";
            BtnOk.UseVisualStyleBackColor = false;
            BtnOk.Click += BtnOk_Click;
            // 
            // TLPTextBox
            // 
            TLPTextBox.AutoSize = true;
            TLPTextBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TLPTextBox.ColumnCount = 3;
            TLPTextBox.ColumnStyles.Add(new ColumnStyle());
            TLPTextBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TLPTextBox.ColumnStyles.Add(new ColumnStyle());
            TLPTextBox.Controls.Add(textBox1, 0, 1);
            TLPTextBox.Controls.Add(textBox2, 0, 2);
            TLPTextBox.Controls.Add(button1, 2, 1);
            TLPTextBox.Controls.Add(button2, 2, 2);
            TLPTextBox.Dock = DockStyle.Fill;
            TLPTextBox.Location = new Point(0, 0);
            TLPTextBox.Margin = new Padding(0);
            TLPTextBox.Name = "TLPTextBox";
            TLPTextBox.RowCount = 4;
            TLPTextBox.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLPTextBox.RowStyles.Add(new RowStyle());
            TLPTextBox.RowStyles.Add(new RowStyle());
            TLPTextBox.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLPTextBox.Size = new Size(562, 144);
            TLPTextBox.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 31);
            textBox1.Margin = new Padding(0, 20, 0, 0);
            textBox1.MinimumSize = new Size(400, 0);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Diretório com logs para serem comprimidos.";
            textBox1.Size = new Size(500, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(0, 94);
            textBox2.Margin = new Padding(0, 24, 0, 0);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Diretório destino para os logs comprimidos.";
            textBox2.Size = new Size(500, 39);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.DimGray;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(512, 31);
            button1.Margin = new Padding(0, 20, 0, 0);
            button1.MinimumSize = new Size(50, 0);
            button1.Name = "button1";
            button1.Size = new Size(50, 39);
            button1.TabIndex = 4;
            button1.Text = "...";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.DimGray;
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(512, 94);
            button2.Margin = new Padding(0, 24, 0, 0);
            button2.Name = "button2";
            button2.Size = new Size(50, 39);
            button2.TabIndex = 6;
            button2.Text = "...";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormMain
            // 
            AcceptButton = BtnOk;
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.AppWorkspace;
            CancelButton = BtnCancel;
            ClientSize = new Size(602, 236);
            Controls.Add(PanelVerticalPadding);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(620, 0);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compressor Bz2";
            PanelVerticalPadding.ResumeLayout(false);
            PanelVerticalPadding.PerformLayout();
            TLPContent.ResumeLayout(false);
            TLPContent.PerformLayout();
            TLPButtons.ResumeLayout(false);
            TLPButtons.PerformLayout();
            TLPTextBox.ResumeLayout(false);
            TLPTextBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelVerticalPadding;
        private TableLayoutPanel TLPContent;
        private TableLayoutPanel TLPButtons;
        private Button BtnCancel;
        private Button BtnOk;
        private TableLayoutPanel TLPTextBox;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}