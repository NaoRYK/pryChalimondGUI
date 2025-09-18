namespace pryChalimondGUI
{
    partial class frmBotonera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBotonera));
            lblName = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            btnSubmit = new Button();
            txtName = new TextBox();
            lblIndex = new Label();
            btnLastItem = new Button();
            btnFirstItem = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14F);
            lblName.Location = new Point(135, 156);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 25);
            lblName.TabIndex = 0;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(61, 184);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(106, 43);
            btnPrev.TabIndex = 1;
            btnPrev.Text = "Anterior";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(173, 184);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(106, 43);
            btnNext.TabIndex = 2;
            btnNext.Text = "Siguiente";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(122, 82);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(95, 28);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Cargar nombre";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 53);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Ingrese un nombre";
            txtName.Size = new Size(115, 23);
            txtName.TabIndex = 4;
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Font = new Font("Segoe UI", 11F);
            lblIndex.Location = new Point(141, 139);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(0, 20);
            lblIndex.TabIndex = 5;
            // 
            // btnLastItem
            // 
            btnLastItem.Location = new Point(285, 184);
            btnLastItem.Name = "btnLastItem";
            btnLastItem.Size = new Size(35, 43);
            btnLastItem.TabIndex = 2;
            btnLastItem.Text = ">>";
            btnLastItem.UseVisualStyleBackColor = true;
            btnLastItem.Click += btnLastItem_Click;
            // 
            // btnFirstItem
            // 
            btnFirstItem.Location = new Point(20, 184);
            btnFirstItem.Name = "btnFirstItem";
            btnFirstItem.Size = new Size(35, 43);
            btnFirstItem.TabIndex = 6;
            btnFirstItem.Text = "<<";
            btnFirstItem.UseVisualStyleBackColor = true;
            btnFirstItem.Click += btnFirstItem_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 254);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(77, 25);
            btnExit.TabIndex = 7;
            btnExit.Text = "Volver";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmBotonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 291);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(btnFirstItem);
            Controls.Add(lblIndex);
            Controls.Add(txtName);
            Controls.Add(btnSubmit);
            Controls.Add(btnLastItem);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBotonera";
            Text = "Botonera";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Button btnPrev;
        private Button btnNext;
        private Button btnSubmit;
        private TextBox txtName;
        private Label lblIndex;
        private Button button1;
        private Button btnLastItem;
        private Button btnFirstItem;
        private Button btnExit;
    }
}