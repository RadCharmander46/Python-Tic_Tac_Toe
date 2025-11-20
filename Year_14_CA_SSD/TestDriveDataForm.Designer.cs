
namespace Year_14_CA_SSD
{
    partial class TestDriveDataForm
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
            this.Test_Drives_ListView = new System.Windows.Forms.ListView();
            this.Edit_Button = new System.Windows.Forms.PictureBox();
            this.Add_Customer_Button = new System.Windows.Forms.PictureBox();
            this.Remove_Customer_Button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Customer_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Remove_Customer_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // Test_Drives_ListView
            // 
            this.Test_Drives_ListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test_Drives_ListView.FullRowSelect = true;
            this.Test_Drives_ListView.HideSelection = false;
            this.Test_Drives_ListView.Location = new System.Drawing.Point(229, 2);
            this.Test_Drives_ListView.Name = "Test_Drives_ListView";
            this.Test_Drives_ListView.Size = new System.Drawing.Size(729, 597);
            this.Test_Drives_ListView.TabIndex = 0;
            this.Test_Drives_ListView.UseCompatibleStateImageBehavior = false;
            this.Test_Drives_ListView.View = System.Windows.Forms.View.Details;
            // 
            // Edit_Button
            // 
            this.Edit_Button.Image = global::Year_14_CA_SSD.Properties.Resources.grey_pencil;
            this.Edit_Button.Location = new System.Drawing.Point(964, 459);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(64, 64);
            this.Edit_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Edit_Button.TabIndex = 9;
            this.Edit_Button.TabStop = false;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Add_Customer_Button
            // 
            this.Add_Customer_Button.Image = global::Year_14_CA_SSD.Properties.Resources.grey_plus;
            this.Add_Customer_Button.Location = new System.Drawing.Point(964, 389);
            this.Add_Customer_Button.Name = "Add_Customer_Button";
            this.Add_Customer_Button.Size = new System.Drawing.Size(64, 64);
            this.Add_Customer_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add_Customer_Button.TabIndex = 10;
            this.Add_Customer_Button.TabStop = false;
            this.Add_Customer_Button.Click += new System.EventHandler(this.Add_Customer_Button_Click);
            // 
            // Remove_Customer_Button
            // 
            this.Remove_Customer_Button.Image = global::Year_14_CA_SSD.Properties.Resources.grey_delete;
            this.Remove_Customer_Button.Location = new System.Drawing.Point(964, 529);
            this.Remove_Customer_Button.Name = "Remove_Customer_Button";
            this.Remove_Customer_Button.Size = new System.Drawing.Size(64, 64);
            this.Remove_Customer_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Remove_Customer_Button.TabIndex = 11;
            this.Remove_Customer_Button.TabStop = false;
            // 
            // TestDriveDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 596);
            this.Controls.Add(this.Remove_Customer_Button);
            this.Controls.Add(this.Add_Customer_Button);
            this.Controls.Add(this.Edit_Button);
            this.Controls.Add(this.Test_Drives_ListView);
            this.Name = "TestDriveDataForm";
            this.Text = "TestDriveDataForm";
            this.Load += new System.EventHandler(this.TestDriveDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Customer_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Remove_Customer_Button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Test_Drives_ListView;
        private System.Windows.Forms.PictureBox Edit_Button;
        private System.Windows.Forms.PictureBox Add_Customer_Button;
        private System.Windows.Forms.PictureBox Remove_Customer_Button;
    }
}