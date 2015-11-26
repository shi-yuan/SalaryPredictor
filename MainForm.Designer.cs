namespace SalaryPredictor
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.memoEdit_salary = new DevExpress.XtraEditors.MemoEdit();
            this.btn_predicate = new DevExpress.XtraEditors.SimpleButton();
            this.txtEdit_year = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_address = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_degree = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_school = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_job = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_salary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_year.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_degree.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_school.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_job.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomizationMenu = false;
            this.layoutControl1.Controls.Add(this.memoEdit_salary);
            this.layoutControl1.Controls.Add(this.btn_predicate);
            this.layoutControl1.Controls.Add(this.txtEdit_year);
            this.layoutControl1.Controls.Add(this.txtEdit_address);
            this.layoutControl1.Controls.Add(this.txtEdit_degree);
            this.layoutControl1.Controls.Add(this.txtEdit_school);
            this.layoutControl1.Controls.Add(this.txtEdit_job);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(11, 334, 340, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(336, 311);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // memoEdit_salary
            // 
            this.memoEdit_salary.Location = new System.Drawing.Point(75, 158);
            this.memoEdit_salary.Name = "memoEdit_salary";
            this.memoEdit_salary.Properties.ReadOnly = true;
            this.memoEdit_salary.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoEdit_salary.Size = new System.Drawing.Size(249, 141);
            this.memoEdit_salary.StyleController = this.layoutControl1;
            this.memoEdit_salary.TabIndex = 5;
            // 
            // btn_predicate
            // 
            this.btn_predicate.Location = new System.Drawing.Point(205, 132);
            this.btn_predicate.MinimumSize = new System.Drawing.Size(117, 0);
            this.btn_predicate.Name = "btn_predicate";
            this.btn_predicate.Size = new System.Drawing.Size(119, 22);
            this.btn_predicate.StyleController = this.layoutControl1;
            this.btn_predicate.TabIndex = 4;
            this.btn_predicate.Text = "预测";
            this.btn_predicate.Click += new System.EventHandler(this.btn_predicate_Click);
            // 
            // txtEdit_year
            // 
            this.txtEdit_year.Location = new System.Drawing.Point(75, 108);
            this.txtEdit_year.Name = "txtEdit_year";
            this.txtEdit_year.Size = new System.Drawing.Size(249, 20);
            this.txtEdit_year.StyleController = this.layoutControl1;
            this.txtEdit_year.TabIndex = 1;
            // 
            // txtEdit_address
            // 
            this.txtEdit_address.Location = new System.Drawing.Point(75, 84);
            this.txtEdit_address.Name = "txtEdit_address";
            this.txtEdit_address.Size = new System.Drawing.Size(249, 20);
            this.txtEdit_address.StyleController = this.layoutControl1;
            this.txtEdit_address.TabIndex = 1;
            // 
            // txtEdit_degree
            // 
            this.txtEdit_degree.Location = new System.Drawing.Point(75, 60);
            this.txtEdit_degree.Name = "txtEdit_degree";
            this.txtEdit_degree.Size = new System.Drawing.Size(249, 20);
            this.txtEdit_degree.StyleController = this.layoutControl1;
            this.txtEdit_degree.TabIndex = 1;
            // 
            // txtEdit_school
            // 
            this.txtEdit_school.Location = new System.Drawing.Point(75, 36);
            this.txtEdit_school.Name = "txtEdit_school";
            this.txtEdit_school.Size = new System.Drawing.Size(249, 20);
            this.txtEdit_school.StyleController = this.layoutControl1;
            this.txtEdit_school.TabIndex = 1;
            // 
            // txtEdit_job
            // 
            this.txtEdit_job.Location = new System.Drawing.Point(75, 12);
            this.txtEdit_job.Name = "txtEdit_job";
            this.txtEdit_job.Size = new System.Drawing.Size(249, 20);
            this.txtEdit_job.StyleController = this.layoutControl1;
            this.txtEdit_job.TabIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(336, 311);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtEdit_job;
            this.layoutControlItem1.CustomizationFormText = "职位得分：";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(316, 24);
            this.layoutControlItem1.Text = "职位得分：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtEdit_year;
            this.layoutControlItem5.CustomizationFormText = "工作年限：";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(316, 24);
            this.layoutControlItem5.Text = "工作年限：";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtEdit_address;
            this.layoutControlItem4.CustomizationFormText = "地区得分：";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(316, 24);
            this.layoutControlItem4.Text = "地区得分：";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btn_predicate;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(193, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(123, 26);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtEdit_school;
            this.layoutControlItem2.CustomizationFormText = "学校得分：";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(316, 24);
            this.layoutControlItem2.Text = "学校得分：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtEdit_degree;
            this.layoutControlItem3.CustomizationFormText = "学历得分：";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(316, 24);
            this.layoutControlItem3.Text = "学历得分：";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 120);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(193, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.memoEdit_salary;
            this.layoutControlItem7.CustomizationFormText = "预估薪资：";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 146);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(316, 145);
            this.layoutControlItem7.Text = "预估薪资：";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(60, 14);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 311);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "薪资预测器";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_salary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_year.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_degree.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_school.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_job.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btn_predicate;
        private DevExpress.XtraEditors.TextEdit txtEdit_year;
        private DevExpress.XtraEditors.TextEdit txtEdit_address;
        private DevExpress.XtraEditors.TextEdit txtEdit_degree;
        private DevExpress.XtraEditors.TextEdit txtEdit_school;
        private DevExpress.XtraEditors.TextEdit txtEdit_job;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.MemoEdit memoEdit_salary;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}

