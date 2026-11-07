namespace PrivateAssemblies
{
    partial class FrmBasicComputation
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
            txtFNum = new TextBox();
            txtSecNum = new TextBox();
            cmbOperation = new ComboBox();
            textBox3 = new TextBox();
            btnCompute = new Button();
            label2 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 23);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 0;
            label1.Text = "Basic Calculator";
            // 
            // txtFNum
            // 
            txtFNum.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFNum.Location = new Point(63, 66);
            txtFNum.Multiline = true;
            txtFNum.Name = "txtFNum";
            txtFNum.Size = new Size(127, 32);
            txtFNum.TabIndex = 1;
            txtFNum.Text = "0";
            txtFNum.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSecNum
            // 
            txtSecNum.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSecNum.Location = new Point(63, 132);
            txtSecNum.Multiline = true;
            txtSecNum.Name = "txtSecNum";
            txtSecNum.Size = new Size(127, 32);
            txtSecNum.TabIndex = 2;
            txtSecNum.Text = "0";
            txtSecNum.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbOperation
            // 
            cmbOperation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperation.FormattingEnabled = true;
            cmbOperation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperation.Location = new Point(93, 103);
            cmbOperation.Name = "cmbOperation";
            cmbOperation.Size = new Size(64, 23);
            cmbOperation.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Black;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(46, 170);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 95);
            textBox3.TabIndex = 4;
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.White;
            btnCompute.FlatStyle = FlatStyle.Flat;
            btnCompute.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(84, 271);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(96, 34);
            btnCompute.TabIndex = 5;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Bahnschrift SemiBold SemiConden", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(58, 188);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 6;
            label2.Text = "Total:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Black;
            lblResult.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.DarkGreen;
            lblResult.Location = new Point(84, 215);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(62, 25);
            lblResult.TabIndex = 7;
            lblResult.Text = "00000";
            // 
            // FrmBasicComputation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(268, 327);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(btnCompute);
            Controls.Add(textBox3);
            Controls.Add(cmbOperation);
            Controls.Add(txtSecNum);
            Controls.Add(txtFNum);
            Controls.Add(label1);
            Name = "FrmBasicComputation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFNum;
        private TextBox txtSecNum;
        private ComboBox cmbOperation;
        private TextBox textBox3;
        private Button btnCompute;
        private Label label2;
        private Label lblResult;
    }
}
