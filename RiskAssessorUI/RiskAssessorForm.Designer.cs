using System.Collections.Generic;

namespace RiskAssessorUI
{
    partial class RiskAssessorForm
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
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.iCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelSelectCustomer = new System.Windows.Forms.Label();
            this.labelUnusualWinnings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iCustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.DataSource = this.iCustomerBindingSource;
            this.comboBoxCustomer.DisplayMember = "Id";
            this.comboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(146, 49);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(66, 24);
            this.comboBoxCustomer.TabIndex = 0;
            this.comboBoxCustomer.ValueMember = "Id";
            this.comboBoxCustomer.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomer_SelectedIndexChanged);
            // 
            // iCustomerBindingSource
            // 
            this.iCustomerBindingSource.DataSource = typeof(System.Collections.Generic.List<RiskAssessorLib.Entities.ICustomer>);
            // 
            // labelSelectCustomer
            // 
            this.labelSelectCustomer.AutoSize = true;
            this.labelSelectCustomer.Location = new System.Drawing.Point(25, 49);
            this.labelSelectCustomer.Name = "labelSelectCustomer";
            this.labelSelectCustomer.Size = new System.Drawing.Size(115, 17);
            this.labelSelectCustomer.TabIndex = 1;
            this.labelSelectCustomer.Text = "Select Customer:";
            // 
            // labelUnusualWinnings
            // 
            this.labelUnusualWinnings.AutoSize = true;
            this.labelUnusualWinnings.ForeColor = System.Drawing.Color.Red;
            this.labelUnusualWinnings.Location = new System.Drawing.Point(228, 52);
            this.labelUnusualWinnings.Name = "labelUnusualWinnings";
            this.labelUnusualWinnings.Size = new System.Drawing.Size(132, 17);
            this.labelUnusualWinnings.TabIndex = 2;
            this.labelUnusualWinnings.Text = "Unusual Winnings !!";
            this.labelUnusualWinnings.Visible = false;
            // 
            // RiskAssessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 487);
            this.Controls.Add(this.labelUnusualWinnings);
            this.Controls.Add(this.labelSelectCustomer);
            this.Controls.Add(this.comboBoxCustomer);
            this.Name = "RiskAssessorForm";
            this.Text = "Risk Assessor";
            ((System.ComponentModel.ISupportInitialize)(this.iCustomerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.BindingSource iCustomerBindingSource;
        private System.Windows.Forms.Label labelSelectCustomer;
        private System.Windows.Forms.Label labelUnusualWinnings;
    }
}

