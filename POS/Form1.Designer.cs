namespace POS
{
    partial class Form1
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
            this.settings_TabControl = new System.Windows.Forms.TabControl();
            this.tab_Locations = new System.Windows.Forms.TabPage();
            this.tab_Deptments = new System.Windows.Forms.TabPage();
            this.txtBox_LocId = new System.Windows.Forms.TextBox();
            this.lbl_LocId = new System.Windows.Forms.Label();
            this.txtBox_LocCode = new System.Windows.Forms.TextBox();
            this.lbl_LocCode = new System.Windows.Forms.Label();
            this.txtBox_LocDesc = new System.Windows.Forms.TextBox();
            this.lbl_LocDesc = new System.Windows.Forms.Label();
            this.dgv_Locations = new System.Windows.Forms.DataGridView();
            this.but_LocSave = new System.Windows.Forms.Button();
            this.tab_Vendors = new System.Windows.Forms.TabPage();
            this.tab_Inventory = new System.Windows.Forms.TabPage();
            this.tab_Components = new System.Windows.Forms.TabPage();
            this.but_DptSave = new System.Windows.Forms.Button();
            this.dgv_Deptments = new System.Windows.Forms.DataGridView();
            this.lbl_DptDesc = new System.Windows.Forms.Label();
            this.lbl_DptCode = new System.Windows.Forms.Label();
            this.lbl_DptId = new System.Windows.Forms.Label();
            this.txtBox_DptDesc = new System.Windows.Forms.TextBox();
            this.txtBox_DptCode = new System.Windows.Forms.TextBox();
            this.txtBox_DptId = new System.Windows.Forms.TextBox();
            this.btn_vendSave = new System.Windows.Forms.Button();
            this.dgv_Vendors = new System.Windows.Forms.DataGridView();
            this.lbl_VendDesc = new System.Windows.Forms.Label();
            this.lbl_VendCode = new System.Windows.Forms.Label();
            this.lbl_VdrId = new System.Windows.Forms.Label();
            this.txtBox_VendDesc = new System.Windows.Forms.TextBox();
            this.txtBox_VendCode = new System.Windows.Forms.TextBox();
            this.txtBox_VendId = new System.Windows.Forms.TextBox();
            this.tab_Updates = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_AddTime = new System.Windows.Forms.Button();
            this.but_ChkDirty = new System.Windows.Forms.Button();
            this.settings_TabControl.SuspendLayout();
            this.tab_Locations.SuspendLayout();
            this.tab_Deptments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Locations)).BeginInit();
            this.tab_Vendors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Deptments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vendors)).BeginInit();
            this.tab_Updates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // settings_TabControl
            // 
            this.settings_TabControl.Controls.Add(this.tab_Locations);
            this.settings_TabControl.Controls.Add(this.tab_Deptments);
            this.settings_TabControl.Controls.Add(this.tab_Vendors);
            this.settings_TabControl.Controls.Add(this.tab_Inventory);
            this.settings_TabControl.Controls.Add(this.tab_Components);
            this.settings_TabControl.Controls.Add(this.tab_Updates);
            this.settings_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_TabControl.Location = new System.Drawing.Point(0, 0);
            this.settings_TabControl.Name = "settings_TabControl";
            this.settings_TabControl.SelectedIndex = 0;
            this.settings_TabControl.Size = new System.Drawing.Size(1026, 446);
            this.settings_TabControl.TabIndex = 0;
            // 
            // tab_Locations
            // 
            this.tab_Locations.Controls.Add(this.but_ChkDirty);
            this.tab_Locations.Controls.Add(this.but_AddTime);
            this.tab_Locations.Controls.Add(this.but_LocSave);
            this.tab_Locations.Controls.Add(this.dgv_Locations);
            this.tab_Locations.Controls.Add(this.lbl_LocDesc);
            this.tab_Locations.Controls.Add(this.lbl_LocCode);
            this.tab_Locations.Controls.Add(this.lbl_LocId);
            this.tab_Locations.Controls.Add(this.txtBox_LocDesc);
            this.tab_Locations.Controls.Add(this.txtBox_LocCode);
            this.tab_Locations.Controls.Add(this.txtBox_LocId);
            this.tab_Locations.Location = new System.Drawing.Point(4, 22);
            this.tab_Locations.Name = "tab_Locations";
            this.tab_Locations.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Locations.Size = new System.Drawing.Size(1018, 420);
            this.tab_Locations.TabIndex = 0;
            this.tab_Locations.Text = "Locations";
            this.tab_Locations.UseVisualStyleBackColor = true;
            // 
            // tab_Deptments
            // 
            this.tab_Deptments.Controls.Add(this.but_DptSave);
            this.tab_Deptments.Controls.Add(this.dgv_Deptments);
            this.tab_Deptments.Controls.Add(this.lbl_DptDesc);
            this.tab_Deptments.Controls.Add(this.lbl_DptCode);
            this.tab_Deptments.Controls.Add(this.lbl_DptId);
            this.tab_Deptments.Controls.Add(this.txtBox_DptDesc);
            this.tab_Deptments.Controls.Add(this.txtBox_DptCode);
            this.tab_Deptments.Controls.Add(this.txtBox_DptId);
            this.tab_Deptments.Location = new System.Drawing.Point(4, 22);
            this.tab_Deptments.Name = "tab_Deptments";
            this.tab_Deptments.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Deptments.Size = new System.Drawing.Size(1018, 420);
            this.tab_Deptments.TabIndex = 1;
            this.tab_Deptments.Text = "Departments";
            this.tab_Deptments.UseVisualStyleBackColor = true;
            // 
            // txtBox_LocId
            // 
            this.txtBox_LocId.Location = new System.Drawing.Point(121, 24);
            this.txtBox_LocId.Name = "txtBox_LocId";
            this.txtBox_LocId.Size = new System.Drawing.Size(107, 20);
            this.txtBox_LocId.TabIndex = 0;
            // 
            // lbl_LocId
            // 
            this.lbl_LocId.AutoSize = true;
            this.lbl_LocId.Location = new System.Drawing.Point(99, 27);
            this.lbl_LocId.Name = "lbl_LocId";
            this.lbl_LocId.Size = new System.Drawing.Size(16, 13);
            this.lbl_LocId.TabIndex = 1;
            this.lbl_LocId.Text = "Id";
            this.lbl_LocId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBox_LocCode
            // 
            this.txtBox_LocCode.Location = new System.Drawing.Point(121, 50);
            this.txtBox_LocCode.Name = "txtBox_LocCode";
            this.txtBox_LocCode.Size = new System.Drawing.Size(107, 20);
            this.txtBox_LocCode.TabIndex = 0;
            // 
            // lbl_LocCode
            // 
            this.lbl_LocCode.AutoSize = true;
            this.lbl_LocCode.Location = new System.Drawing.Point(83, 53);
            this.lbl_LocCode.Name = "lbl_LocCode";
            this.lbl_LocCode.Size = new System.Drawing.Size(32, 13);
            this.lbl_LocCode.TabIndex = 1;
            this.lbl_LocCode.Text = "Code";
            this.lbl_LocCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBox_LocDesc
            // 
            this.txtBox_LocDesc.Location = new System.Drawing.Point(121, 76);
            this.txtBox_LocDesc.Name = "txtBox_LocDesc";
            this.txtBox_LocDesc.Size = new System.Drawing.Size(107, 20);
            this.txtBox_LocDesc.TabIndex = 0;
            // 
            // lbl_LocDesc
            // 
            this.lbl_LocDesc.AutoSize = true;
            this.lbl_LocDesc.Location = new System.Drawing.Point(55, 79);
            this.lbl_LocDesc.Name = "lbl_LocDesc";
            this.lbl_LocDesc.Size = new System.Drawing.Size(60, 13);
            this.lbl_LocDesc.TabIndex = 1;
            this.lbl_LocDesc.Text = "Description";
            this.lbl_LocDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgv_Locations
            // 
            this.dgv_Locations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Locations.Location = new System.Drawing.Point(121, 138);
            this.dgv_Locations.Name = "dgv_Locations";
            this.dgv_Locations.Size = new System.Drawing.Size(745, 181);
            this.dgv_Locations.TabIndex = 2;
            // 
            // but_LocSave
            // 
            this.but_LocSave.Location = new System.Drawing.Point(773, 363);
            this.but_LocSave.Name = "but_LocSave";
            this.but_LocSave.Size = new System.Drawing.Size(92, 30);
            this.but_LocSave.TabIndex = 3;
            this.but_LocSave.Text = "Save";
            this.but_LocSave.UseVisualStyleBackColor = true;
            // 
            // tab_Vendors
            // 
            this.tab_Vendors.Controls.Add(this.btn_vendSave);
            this.tab_Vendors.Controls.Add(this.dgv_Vendors);
            this.tab_Vendors.Controls.Add(this.lbl_VendDesc);
            this.tab_Vendors.Controls.Add(this.lbl_VendCode);
            this.tab_Vendors.Controls.Add(this.lbl_VdrId);
            this.tab_Vendors.Controls.Add(this.txtBox_VendDesc);
            this.tab_Vendors.Controls.Add(this.txtBox_VendCode);
            this.tab_Vendors.Controls.Add(this.txtBox_VendId);
            this.tab_Vendors.Location = new System.Drawing.Point(4, 22);
            this.tab_Vendors.Name = "tab_Vendors";
            this.tab_Vendors.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Vendors.Size = new System.Drawing.Size(1018, 420);
            this.tab_Vendors.TabIndex = 2;
            this.tab_Vendors.Text = "Vendors";
            this.tab_Vendors.UseVisualStyleBackColor = true;
            // 
            // tab_Inventory
            // 
            this.tab_Inventory.Location = new System.Drawing.Point(4, 22);
            this.tab_Inventory.Name = "tab_Inventory";
            this.tab_Inventory.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Inventory.Size = new System.Drawing.Size(1018, 420);
            this.tab_Inventory.TabIndex = 3;
            this.tab_Inventory.Text = "Inventory";
            this.tab_Inventory.UseVisualStyleBackColor = true;
            // 
            // tab_Components
            // 
            this.tab_Components.Location = new System.Drawing.Point(4, 22);
            this.tab_Components.Name = "tab_Components";
            this.tab_Components.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Components.Size = new System.Drawing.Size(1018, 420);
            this.tab_Components.TabIndex = 4;
            this.tab_Components.Text = "Components";
            this.tab_Components.UseVisualStyleBackColor = true;
            // 
            // but_DptSave
            // 
            this.but_DptSave.Location = new System.Drawing.Point(822, 365);
            this.but_DptSave.Name = "but_DptSave";
            this.but_DptSave.Size = new System.Drawing.Size(92, 30);
            this.but_DptSave.TabIndex = 11;
            this.but_DptSave.Text = "Save";
            this.but_DptSave.UseVisualStyleBackColor = true;
            // 
            // dgv_Deptments
            // 
            this.dgv_Deptments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Deptments.Location = new System.Drawing.Point(170, 140);
            this.dgv_Deptments.Name = "dgv_Deptments";
            this.dgv_Deptments.Size = new System.Drawing.Size(745, 181);
            this.dgv_Deptments.TabIndex = 10;
            // 
            // lbl_DptDesc
            // 
            this.lbl_DptDesc.AutoSize = true;
            this.lbl_DptDesc.Location = new System.Drawing.Point(104, 81);
            this.lbl_DptDesc.Name = "lbl_DptDesc";
            this.lbl_DptDesc.Size = new System.Drawing.Size(60, 13);
            this.lbl_DptDesc.TabIndex = 7;
            this.lbl_DptDesc.Text = "Description";
            this.lbl_DptDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_DptCode
            // 
            this.lbl_DptCode.AutoSize = true;
            this.lbl_DptCode.Location = new System.Drawing.Point(132, 55);
            this.lbl_DptCode.Name = "lbl_DptCode";
            this.lbl_DptCode.Size = new System.Drawing.Size(32, 13);
            this.lbl_DptCode.TabIndex = 8;
            this.lbl_DptCode.Text = "Code";
            this.lbl_DptCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_DptId
            // 
            this.lbl_DptId.AutoSize = true;
            this.lbl_DptId.Location = new System.Drawing.Point(148, 29);
            this.lbl_DptId.Name = "lbl_DptId";
            this.lbl_DptId.Size = new System.Drawing.Size(16, 13);
            this.lbl_DptId.TabIndex = 9;
            this.lbl_DptId.Text = "Id";
            this.lbl_DptId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBox_DptDesc
            // 
            this.txtBox_DptDesc.Location = new System.Drawing.Point(170, 78);
            this.txtBox_DptDesc.Name = "txtBox_DptDesc";
            this.txtBox_DptDesc.Size = new System.Drawing.Size(107, 20);
            this.txtBox_DptDesc.TabIndex = 4;
            // 
            // txtBox_DptCode
            // 
            this.txtBox_DptCode.Location = new System.Drawing.Point(170, 52);
            this.txtBox_DptCode.Name = "txtBox_DptCode";
            this.txtBox_DptCode.Size = new System.Drawing.Size(107, 20);
            this.txtBox_DptCode.TabIndex = 5;
            // 
            // txtBox_DptId
            // 
            this.txtBox_DptId.Location = new System.Drawing.Point(170, 26);
            this.txtBox_DptId.Name = "txtBox_DptId";
            this.txtBox_DptId.Size = new System.Drawing.Size(107, 20);
            this.txtBox_DptId.TabIndex = 6;
            // 
            // btn_vendSave
            // 
            this.btn_vendSave.Location = new System.Drawing.Point(822, 365);
            this.btn_vendSave.Name = "btn_vendSave";
            this.btn_vendSave.Size = new System.Drawing.Size(92, 30);
            this.btn_vendSave.TabIndex = 11;
            this.btn_vendSave.Text = "Save";
            this.btn_vendSave.UseVisualStyleBackColor = true;
            // 
            // dgv_Vendors
            // 
            this.dgv_Vendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Vendors.Location = new System.Drawing.Point(170, 140);
            this.dgv_Vendors.Name = "dgv_Vendors";
            this.dgv_Vendors.Size = new System.Drawing.Size(745, 181);
            this.dgv_Vendors.TabIndex = 10;
            // 
            // lbl_VendDesc
            // 
            this.lbl_VendDesc.AutoSize = true;
            this.lbl_VendDesc.Location = new System.Drawing.Point(104, 81);
            this.lbl_VendDesc.Name = "lbl_VendDesc";
            this.lbl_VendDesc.Size = new System.Drawing.Size(60, 13);
            this.lbl_VendDesc.TabIndex = 7;
            this.lbl_VendDesc.Text = "Description";
            this.lbl_VendDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_VendCode
            // 
            this.lbl_VendCode.AutoSize = true;
            this.lbl_VendCode.Location = new System.Drawing.Point(132, 55);
            this.lbl_VendCode.Name = "lbl_VendCode";
            this.lbl_VendCode.Size = new System.Drawing.Size(32, 13);
            this.lbl_VendCode.TabIndex = 8;
            this.lbl_VendCode.Text = "Code";
            this.lbl_VendCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_VdrId
            // 
            this.lbl_VdrId.AutoSize = true;
            this.lbl_VdrId.Location = new System.Drawing.Point(148, 29);
            this.lbl_VdrId.Name = "lbl_VdrId";
            this.lbl_VdrId.Size = new System.Drawing.Size(16, 13);
            this.lbl_VdrId.TabIndex = 9;
            this.lbl_VdrId.Text = "Id";
            this.lbl_VdrId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBox_VendDesc
            // 
            this.txtBox_VendDesc.Location = new System.Drawing.Point(170, 78);
            this.txtBox_VendDesc.Name = "txtBox_VendDesc";
            this.txtBox_VendDesc.Size = new System.Drawing.Size(107, 20);
            this.txtBox_VendDesc.TabIndex = 4;
            // 
            // txtBox_VendCode
            // 
            this.txtBox_VendCode.Location = new System.Drawing.Point(170, 52);
            this.txtBox_VendCode.Name = "txtBox_VendCode";
            this.txtBox_VendCode.Size = new System.Drawing.Size(107, 20);
            this.txtBox_VendCode.TabIndex = 5;
            // 
            // txtBox_VendId
            // 
            this.txtBox_VendId.Location = new System.Drawing.Point(170, 26);
            this.txtBox_VendId.Name = "txtBox_VendId";
            this.txtBox_VendId.Size = new System.Drawing.Size(107, 20);
            this.txtBox_VendId.TabIndex = 6;
            // 
            // tab_Updates
            // 
            this.tab_Updates.Controls.Add(this.dataGridView1);
            this.tab_Updates.Location = new System.Drawing.Point(4, 22);
            this.tab_Updates.Name = "tab_Updates";
            this.tab_Updates.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Updates.Size = new System.Drawing.Size(1018, 420);
            this.tab_Updates.TabIndex = 5;
            this.tab_Updates.Text = "Table Times";
            this.tab_Updates.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(857, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // but_AddTime
            // 
            this.but_AddTime.Location = new System.Drawing.Point(151, 351);
            this.but_AddTime.Name = "but_AddTime";
            this.but_AddTime.Size = new System.Drawing.Size(98, 26);
            this.but_AddTime.TabIndex = 4;
            this.but_AddTime.Text = "add time";
            this.but_AddTime.UseVisualStyleBackColor = true;
            this.but_AddTime.Click += new System.EventHandler(this.but_AddTime_Click);
            // 
            // but_ChkDirty
            // 
            this.but_ChkDirty.Location = new System.Drawing.Point(289, 351);
            this.but_ChkDirty.Name = "but_ChkDirty";
            this.but_ChkDirty.Size = new System.Drawing.Size(98, 26);
            this.but_ChkDirty.TabIndex = 4;
            this.but_ChkDirty.Text = "check dirty";
            this.but_ChkDirty.UseVisualStyleBackColor = true;
            this.but_ChkDirty.Click += new System.EventHandler(this.but_CheckDirty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 446);
            this.Controls.Add(this.settings_TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.settings_TabControl.ResumeLayout(false);
            this.tab_Locations.ResumeLayout(false);
            this.tab_Locations.PerformLayout();
            this.tab_Deptments.ResumeLayout(false);
            this.tab_Deptments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Locations)).EndInit();
            this.tab_Vendors.ResumeLayout(false);
            this.tab_Vendors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Deptments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vendors)).EndInit();
            this.tab_Updates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl settings_TabControl;
        private System.Windows.Forms.TabPage tab_Locations;
        private System.Windows.Forms.DataGridView dgv_Locations;
        private System.Windows.Forms.Label lbl_LocDesc;
        private System.Windows.Forms.Label lbl_LocCode;
        private System.Windows.Forms.Label lbl_LocId;
        private System.Windows.Forms.TextBox txtBox_LocDesc;
        private System.Windows.Forms.TextBox txtBox_LocCode;
        private System.Windows.Forms.TextBox txtBox_LocId;
        private System.Windows.Forms.TabPage tab_Deptments;
        private System.Windows.Forms.Button but_LocSave;
        private System.Windows.Forms.TabPage tab_Vendors;
        private System.Windows.Forms.TabPage tab_Inventory;
        private System.Windows.Forms.TabPage tab_Components;
        private System.Windows.Forms.Button but_DptSave;
        private System.Windows.Forms.DataGridView dgv_Deptments;
        private System.Windows.Forms.Label lbl_DptDesc;
        private System.Windows.Forms.Label lbl_DptCode;
        private System.Windows.Forms.Label lbl_DptId;
        private System.Windows.Forms.TextBox txtBox_DptDesc;
        private System.Windows.Forms.TextBox txtBox_DptCode;
        private System.Windows.Forms.TextBox txtBox_DptId;
        private System.Windows.Forms.Button btn_vendSave;
        private System.Windows.Forms.DataGridView dgv_Vendors;
        private System.Windows.Forms.Label lbl_VendDesc;
        private System.Windows.Forms.Label lbl_VendCode;
        private System.Windows.Forms.Label lbl_VdrId;
        private System.Windows.Forms.TextBox txtBox_VendDesc;
        private System.Windows.Forms.TextBox txtBox_VendCode;
        private System.Windows.Forms.TextBox txtBox_VendId;
        private System.Windows.Forms.Button but_ChkDirty;
        private System.Windows.Forms.Button but_AddTime;
        private System.Windows.Forms.TabPage tab_Updates;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

