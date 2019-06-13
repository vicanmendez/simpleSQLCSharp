namespace ABTurnos
{
    partial class Reportes
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
            this.components = new System.ComponentModel.Container();
            this.turnosDataSet = new ABTurnos.turnosDataSet();
            this.tURNOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tURNOTableAdapter = new ABTurnos.turnosDataSetTableAdapters.TURNOTableAdapter();
            this.turnosDataSet1 = new ABTurnos.turnosDataSet1();
            this.verTurnosPorIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verTurnosPorIdTableAdapter = new ABTurnos.turnosDataSet1TableAdapters.verTurnosPorIdTableAdapter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.turnosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURNOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verTurnosPorIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // turnosDataSet
            // 
            this.turnosDataSet.DataSetName = "turnosDataSet";
            this.turnosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tURNOBindingSource
            // 
            this.tURNOBindingSource.DataMember = "TURNO";
            this.tURNOBindingSource.DataSource = this.turnosDataSet;
            // 
            // tURNOTableAdapter
            // 
            this.tURNOTableAdapter.ClearBeforeFill = true;
            // 
            // turnosDataSet1
            // 
            this.turnosDataSet1.DataSetName = "turnosDataSet1";
            this.turnosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verTurnosPorIdBindingSource
            // 
            this.verTurnosPorIdBindingSource.DataMember = "verTurnosPorId";
            this.verTurnosPorIdBindingSource.DataSource = this.turnosDataSet1;
            // 
            // verTurnosPorIdTableAdapter
            // 
            this.verTurnosPorIdTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(17, 21);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(262, 204);
            this.dataGridView.TabIndex = 0;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 450);
            this.Controls.Add(this.dataGridView);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turnosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tURNOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verTurnosPorIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private turnosDataSet turnosDataSet;
        private System.Windows.Forms.BindingSource tURNOBindingSource;
        private turnosDataSetTableAdapters.TURNOTableAdapter tURNOTableAdapter;
        private System.Windows.Forms.BindingSource verTurnosPorIdBindingSource;
        private turnosDataSet1 turnosDataSet1;
        private turnosDataSet1TableAdapters.verTurnosPorIdTableAdapter verTurnosPorIdTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}