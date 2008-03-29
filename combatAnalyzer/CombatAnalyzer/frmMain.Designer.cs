namespace CombatAnalyzer
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTgtAnalysis = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colTargetName = new System.Windows.Forms.ColumnHeader();
            this.colAvgTgtDmg = new System.Windows.Forms.ColumnHeader();
            this.colMaxTgtDmg = new System.Windows.Forms.ColumnHeader();
            this.colMinTgtDmg = new System.Windows.Forms.ColumnHeader();
            this.tpSkillAnalysis = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.colSkillName = new System.Windows.Forms.ColumnHeader();
            this.colSkillAvgDmg = new System.Windows.Forms.ColumnHeader();
            this.colSkillMaxDmg = new System.Windows.Forms.ColumnHeader();
            this.colSkillMinDmg = new System.Windows.Forms.ColumnHeader();
            this.tpDmgType = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.colDTName = new System.Windows.Forms.ColumnHeader();
            this.colDTAvgDmg = new System.Windows.Forms.ColumnHeader();
            this.colDTMaxDmg = new System.Windows.Forms.ColumnHeader();
            this.colDTMinDmg = new System.Windows.Forms.ColumnHeader();
            this.tabControl1.SuspendLayout();
            this.tpTgtAnalysis.SuspendLayout();
            this.tpSkillAnalysis.SuspendLayout();
            this.tpDmgType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTgtAnalysis);
            this.tabControl1.Controls.Add(this.tpSkillAnalysis);
            this.tabControl1.Controls.Add(this.tpDmgType);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 357);
            this.tabControl1.TabIndex = 0;
            // 
            // tpTgtAnalysis
            // 
            this.tpTgtAnalysis.Controls.Add(this.listView1);
            this.tpTgtAnalysis.Location = new System.Drawing.Point(4, 24);
            this.tpTgtAnalysis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpTgtAnalysis.Name = "tpTgtAnalysis";
            this.tpTgtAnalysis.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpTgtAnalysis.Size = new System.Drawing.Size(719, 329);
            this.tpTgtAnalysis.TabIndex = 0;
            this.tpTgtAnalysis.Text = "Target Analysis";
            this.tpTgtAnalysis.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTargetName,
            this.colAvgTgtDmg,
            this.colMaxTgtDmg,
            this.colMinTgtDmg});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(713, 321);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // colTargetName
            // 
            this.colTargetName.Text = "Target";
            this.colTargetName.Width = 160;
            // 
            // colAvgTgtDmg
            // 
            this.colAvgTgtDmg.Text = "Average Damage";
            this.colAvgTgtDmg.Width = 132;
            // 
            // colMaxTgtDmg
            // 
            this.colMaxTgtDmg.Text = "Maximum Damage";
            this.colMaxTgtDmg.Width = 144;
            // 
            // colMinTgtDmg
            // 
            this.colMinTgtDmg.Text = "Minimum Damage";
            this.colMinTgtDmg.Width = 142;
            // 
            // tpSkillAnalysis
            // 
            this.tpSkillAnalysis.Controls.Add(this.listView2);
            this.tpSkillAnalysis.Location = new System.Drawing.Point(4, 24);
            this.tpSkillAnalysis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpSkillAnalysis.Name = "tpSkillAnalysis";
            this.tpSkillAnalysis.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpSkillAnalysis.Size = new System.Drawing.Size(719, 329);
            this.tpSkillAnalysis.TabIndex = 1;
            this.tpSkillAnalysis.Text = "Skill Analysis";
            this.tpSkillAnalysis.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSkillName,
            this.colSkillAvgDmg,
            this.colSkillMaxDmg,
            this.colSkillMinDmg});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(3, 4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(713, 321);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // colSkillName
            // 
            this.colSkillName.Text = "Skill";
            this.colSkillName.Width = 144;
            // 
            // colSkillAvgDmg
            // 
            this.colSkillAvgDmg.Text = "Average Damage";
            this.colSkillAvgDmg.Width = 119;
            // 
            // colSkillMaxDmg
            // 
            this.colSkillMaxDmg.Text = "Maximum Damage";
            this.colSkillMaxDmg.Width = 125;
            // 
            // colSkillMinDmg
            // 
            this.colSkillMinDmg.Text = "Minimum Damage";
            this.colSkillMinDmg.Width = 122;
            // 
            // tpDmgType
            // 
            this.tpDmgType.Controls.Add(this.listView3);
            this.tpDmgType.Location = new System.Drawing.Point(4, 24);
            this.tpDmgType.Name = "tpDmgType";
            this.tpDmgType.Size = new System.Drawing.Size(719, 329);
            this.tpDmgType.TabIndex = 2;
            this.tpDmgType.Text = "Damage Type Analysis";
            this.tpDmgType.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDTName,
            this.colDTAvgDmg,
            this.colDTMaxDmg,
            this.colDTMinDmg});
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.Location = new System.Drawing.Point(0, 0);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(719, 329);
            this.listView3.TabIndex = 1;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // colDTName
            // 
            this.colDTName.Text = "Damage Type";
            this.colDTName.Width = 144;
            // 
            // colDTAvgDmg
            // 
            this.colDTAvgDmg.Text = "Average Damage";
            this.colDTAvgDmg.Width = 119;
            // 
            // colDTMaxDmg
            // 
            this.colDTMaxDmg.Text = "Maximum Damage";
            this.colDTMaxDmg.Width = 125;
            // 
            // colDTMinDmg
            // 
            this.colDTMinDmg.Text = "Minimum Damage";
            this.colDTMinDmg.Width = 122;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 357);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "LOTRO Combat Analyzer";
            this.tabControl1.ResumeLayout(false);
            this.tpTgtAnalysis.ResumeLayout(false);
            this.tpSkillAnalysis.ResumeLayout(false);
            this.tpDmgType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTgtAnalysis;
        private System.Windows.Forms.TabPage tpSkillAnalysis;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colTargetName;
        private System.Windows.Forms.ColumnHeader colAvgTgtDmg;
        private System.Windows.Forms.ColumnHeader colMaxTgtDmg;
        private System.Windows.Forms.ColumnHeader colMinTgtDmg;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader colSkillName;
        private System.Windows.Forms.ColumnHeader colSkillAvgDmg;
        private System.Windows.Forms.ColumnHeader colSkillMaxDmg;
        private System.Windows.Forms.ColumnHeader colSkillMinDmg;
        private System.Windows.Forms.TabPage tpDmgType;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader colDTName;
        private System.Windows.Forms.ColumnHeader colDTAvgDmg;
        private System.Windows.Forms.ColumnHeader colDTMaxDmg;
        private System.Windows.Forms.ColumnHeader colDTMinDmg;
    }
}

