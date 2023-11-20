namespace BasicCalculator
{
    partial class frmBasicCalculator
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
            label1 = new Label();
            txtFirstNum = new TextBox();
            cbOperation = new ComboBox();
            txtSecondNumber = new TextBox();
            panel1 = new Panel();
            lblTotal = new Label();
            label2 = new Label();
            btnCompute = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 29);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 0;
            label1.Text = "Basic Calculator";
            // 
            // txtFirstNum
            // 
            txtFirstNum.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstNum.Location = new Point(42, 79);
            txtFirstNum.Name = "txtFirstNum";
            txtFirstNum.Size = new Size(223, 26);
            txtFirstNum.TabIndex = 1;
            txtFirstNum.KeyPress += txtFirstNum_KeyPress;
            // 
            // cbOperation
            // 
            cbOperation.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbOperation.FormattingEnabled = true;
            cbOperation.Location = new Point(116, 131);
            cbOperation.Name = "cbOperation";
            cbOperation.Size = new Size(74, 26);
            cbOperation.TabIndex = 2;
            // 
            // txtSecondNumber
            // 
            txtSecondNumber.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSecondNumber.Location = new Point(42, 182);
            txtSecondNumber.Name = "txtSecondNumber";
            txtSecondNumber.Size = new Size(223, 26);
            txtSecondNumber.TabIndex = 3;
            txtSecondNumber.KeyPress += txtSecondNumber_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(42, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 87);
            panel1.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.Green;
            lblTotal.Location = new Point(23, 43);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(84, 25);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(8, 9);
            label2.Name = "label2";
            label2.Size = new Size(47, 19);
            label2.TabIndex = 5;
            label2.Text = "Total:";
            // 
            // btnCompute
            // 
            btnCompute.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompute.Location = new Point(96, 331);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(115, 35);
            btnCompute.TabIndex = 5;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // frmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 391);
            Controls.Add(btnCompute);
            Controls.Add(panel1);
            Controls.Add(txtSecondNumber);
            Controls.Add(cbOperation);
            Controls.Add(txtFirstNum);
            Controls.Add(label1);
            Name = "frmBasicCalculator";
            Text = "Basic Calculator";
            Load += frmBasicCalculator_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstNum;
        private ComboBox cbOperation;
        private TextBox txtSecondNumber;
        private Panel panel1;
        private Label lblTotal;
        private Label label2;
        private Button btnCompute;
    }
}