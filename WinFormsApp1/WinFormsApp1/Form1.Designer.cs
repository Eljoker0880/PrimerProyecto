namespace WinFormsApp1
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            button1 = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 492);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(panel12);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Location = new Point(468, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(593, 576);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(14, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(421, 65);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Location = new Point(14, 103);
            panel4.Name = "panel4";
            panel4.Size = new Size(421, 47);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Location = new Point(14, 244);
            panel5.Name = "panel5";
            panel5.Size = new Size(421, 47);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Location = new Point(14, 175);
            panel6.Name = "panel6";
            panel6.Size = new Size(421, 47);
            panel6.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(14, 394);
            button1.Name = "button1";
            button1.Size = new Size(421, 60);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Location = new Point(14, 309);
            panel7.Name = "panel7";
            panel7.Size = new Size(421, 47);
            panel7.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.Location = new Point(6, 85);
            panel8.Name = "panel8";
            panel8.Size = new Size(584, 77);
            panel8.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Location = new Point(3, 402);
            panel9.Name = "panel9";
            panel9.Size = new Size(587, 47);
            panel9.TabIndex = 4;
            // 
            // panel11
            // 
            panel11.Location = new Point(6, 463);
            panel11.Name = "panel11";
            panel11.Size = new Size(584, 47);
            panel11.TabIndex = 5;
            // 
            // panel12
            // 
            panel12.Location = new Point(6, 526);
            panel12.Name = "panel12";
            panel12.Size = new Size(584, 47);
            panel12.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(96, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(359, 150);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panel5;
        private Panel panel6;
        private Panel panel4;
        private Panel panel3;
        private Panel panel7;
        private Panel panel8;
        private Panel panel11;
        private Panel panel12;
        private Panel panel9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
