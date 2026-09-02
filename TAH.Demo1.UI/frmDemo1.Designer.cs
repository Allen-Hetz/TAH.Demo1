namespace TAH.Demo1.UI
{
    partial class frmDemo1
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
            lblTItle = new Label();
            lblName = new Label();
            btnDisplay = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTItle
            // 
            lblTItle.AutoSize = true;
            lblTItle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTItle.ForeColor = Color.White;
            lblTItle.Location = new Point(312, 62);
            lblTItle.Name = "lblTItle";
            lblTItle.Size = new Size(186, 32);
            lblTItle.TabIndex = 0;
            lblTItle.Text = "Welcome to C#";
            // 
            // lblName
            // 
            lblName.BackColor = Color.DarkBlue;
            lblName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(192, 151);
            lblName.Name = "lblName";
            lblName.Size = new Size(425, 77);
            lblName.TabIndex = 1;
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.BlueViolet;
            btnDisplay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDisplay.ForeColor = Color.White;
            btnDisplay.Location = new Point(297, 250);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(222, 67);
            btnDisplay.TabIndex = 2;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.BlueViolet;
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(297, 336);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(222, 67);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderColor = Color.Salmon;
            btnExit.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(717, 406);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(71, 32);
            btnExit.TabIndex = 4;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmDemo1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(lblName);
            Controls.Add(lblTItle);
            Name = "frmDemo1";
            Text = "Demo 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTItle;
        private Label lblName;
        private Button btnClear;
        private Button btnExit;
        public Button btnDisplay;
    }
}
