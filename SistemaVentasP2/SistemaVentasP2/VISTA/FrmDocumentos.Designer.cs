
namespace SistemaVentasP2.VISTA
{
    partial class FrmDocumentos
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
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateDocumento = new System.Windows.Forms.Button();
            this.btnRemoveDocumento = new System.Windows.Forms.Button();
            this.btnAgregarDocumento = new System.Windows.Forms.Button();
            this.txtIdDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(235, 82);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(193, 20);
            this.txtDocumento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del documento :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(2, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(437, 257);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre del documento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnUpdateDocumento
            // 
            this.btnUpdateDocumento.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDocumento.Location = new System.Drawing.Point(294, 141);
            this.btnUpdateDocumento.Name = "btnUpdateDocumento";
            this.btnUpdateDocumento.Size = new System.Drawing.Size(95, 29);
            this.btnUpdateDocumento.TabIndex = 16;
            this.btnUpdateDocumento.Text = "Actualizar";
            this.btnUpdateDocumento.UseVisualStyleBackColor = true;
            this.btnUpdateDocumento.Click += new System.EventHandler(this.btnUpdateDocumento_Click);
            // 
            // btnRemoveDocumento
            // 
            this.btnRemoveDocumento.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDocumento.Location = new System.Drawing.Point(180, 141);
            this.btnRemoveDocumento.Name = "btnRemoveDocumento";
            this.btnRemoveDocumento.Size = new System.Drawing.Size(95, 29);
            this.btnRemoveDocumento.TabIndex = 15;
            this.btnRemoveDocumento.Text = "Eliminar";
            this.btnRemoveDocumento.UseVisualStyleBackColor = true;
            this.btnRemoveDocumento.Click += new System.EventHandler(this.btnRemoveDocumento_Click);
            // 
            // btnAgregarDocumento
            // 
            this.btnAgregarDocumento.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDocumento.Location = new System.Drawing.Point(65, 141);
            this.btnAgregarDocumento.Name = "btnAgregarDocumento";
            this.btnAgregarDocumento.Size = new System.Drawing.Size(95, 29);
            this.btnAgregarDocumento.TabIndex = 14;
            this.btnAgregarDocumento.Text = "Agregar";
            this.btnAgregarDocumento.UseVisualStyleBackColor = true;
            this.btnAgregarDocumento.Click += new System.EventHandler(this.btnAgregarDocumento_Click);
            // 
            // txtIdDocumento
            // 
            this.txtIdDocumento.Location = new System.Drawing.Point(2, 24);
            this.txtIdDocumento.Name = "txtIdDocumento";
            this.txtIdDocumento.Size = new System.Drawing.Size(54, 20);
            this.txtIdDocumento.TabIndex = 17;
            this.txtIdDocumento.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ingrese su documento";
            // 
            // FrmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(451, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdDocumento);
            this.Controls.Add(this.btnUpdateDocumento);
            this.Controls.Add(this.btnRemoveDocumento);
            this.Controls.Add(this.btnAgregarDocumento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocumento);
            this.Name = "FrmDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDocumentos";
            this.Load += new System.EventHandler(this.FrmDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdateDocumento;
        private System.Windows.Forms.Button btnRemoveDocumento;
        private System.Windows.Forms.Button btnAgregarDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtIdDocumento;
        private System.Windows.Forms.Label label2;
    }
}