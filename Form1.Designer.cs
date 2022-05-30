namespace W14_kei
{
    partial class form_Team
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
            this.btn_First = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Last = new System.Windows.Forms.Button();
            this.lb_TeamName = new System.Windows.Forms.Label();
            this.lb_Manager = new System.Windows.Forms.Label();
            this.lb_Stadium = new System.Windows.Forms.Label();
            this.lb_TopScorer = new System.Windows.Forms.Label();
            this.lb_Worst = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtg_Match = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Match)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_First
            // 
            this.btn_First.Location = new System.Drawing.Point(66, 37);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(69, 46);
            this.btn_First.TabIndex = 0;
            this.btn_First.Text = "<<";
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(141, 37);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(69, 46);
            this.btn_Prev.TabIndex = 1;
            this.btn_Prev.Text = "<";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(218, 37);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(69, 46);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(293, 37);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(69, 46);
            this.btn_Last.TabIndex = 3;
            this.btn_Last.Text = ">>";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // lb_TeamName
            // 
            this.lb_TeamName.AutoSize = true;
            this.lb_TeamName.Location = new System.Drawing.Point(175, 119);
            this.lb_TeamName.Name = "lb_TeamName";
            this.lb_TeamName.Size = new System.Drawing.Size(35, 13);
            this.lb_TeamName.TabIndex = 4;
            this.lb_TeamName.Text = "label1";
            // 
            // lb_Manager
            // 
            this.lb_Manager.AutoSize = true;
            this.lb_Manager.Location = new System.Drawing.Point(175, 147);
            this.lb_Manager.Name = "lb_Manager";
            this.lb_Manager.Size = new System.Drawing.Size(35, 13);
            this.lb_Manager.TabIndex = 5;
            this.lb_Manager.Text = "label2";
            // 
            // lb_Stadium
            // 
            this.lb_Stadium.AutoSize = true;
            this.lb_Stadium.Location = new System.Drawing.Point(175, 171);
            this.lb_Stadium.Name = "lb_Stadium";
            this.lb_Stadium.Size = new System.Drawing.Size(35, 13);
            this.lb_Stadium.TabIndex = 6;
            this.lb_Stadium.Text = "label3";
            // 
            // lb_TopScorer
            // 
            this.lb_TopScorer.AutoSize = true;
            this.lb_TopScorer.Location = new System.Drawing.Point(175, 198);
            this.lb_TopScorer.Name = "lb_TopScorer";
            this.lb_TopScorer.Size = new System.Drawing.Size(35, 13);
            this.lb_TopScorer.TabIndex = 7;
            this.lb_TopScorer.Text = "label4";
            // 
            // lb_Worst
            // 
            this.lb_Worst.AutoSize = true;
            this.lb_Worst.Location = new System.Drawing.Point(175, 222);
            this.lb_Worst.Name = "lb_Worst";
            this.lb_Worst.Size = new System.Drawing.Size(35, 13);
            this.lb_Worst.TabIndex = 8;
            this.lb_Worst.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Worst Discipline :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Top Scorer :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Stadium :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Manager :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Team Name :";
            // 
            // dtg_Match
            // 
            this.dtg_Match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Match.Location = new System.Drawing.Point(66, 260);
            this.dtg_Match.Name = "dtg_Match";
            this.dtg_Match.Size = new System.Drawing.Size(485, 178);
            this.dtg_Match.TabIndex = 14;
            // 
            // form_Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 451);
            this.Controls.Add(this.dtg_Match);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_Worst);
            this.Controls.Add(this.lb_TopScorer);
            this.Controls.Add(this.lb_Stadium);
            this.Controls.Add(this.lb_Manager);
            this.Controls.Add(this.lb_TeamName);
            this.Controls.Add(this.btn_Last);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_First);
            this.Name = "form_Team";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team";
            this.Load += new System.EventHandler(this.form_Team_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Match)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Label lb_TeamName;
        private System.Windows.Forms.Label lb_Manager;
        private System.Windows.Forms.Label lb_Stadium;
        private System.Windows.Forms.Label lb_TopScorer;
        private System.Windows.Forms.Label lb_Worst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtg_Match;
    }
}

