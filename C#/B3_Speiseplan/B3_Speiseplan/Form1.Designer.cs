namespace B3_Speiseplan
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
            this.lblFoods = new System.Windows.Forms.Label();
            this.lblWeekday = new System.Windows.Forms.Label();
            this.grpWeekPlan = new System.Windows.Forms.GroupBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdCommit = new System.Windows.Forms.Button();
            this.lboWeekplan = new System.Windows.Forms.ListBox();
            this.lblWeekplan = new System.Windows.Forms.Label();
            this.grpFoodManaging = new System.Windows.Forms.GroupBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.lblFood = new System.Windows.Forms.Label();
            this.cmdEnd = new System.Windows.Forms.Button();
            this.lboMeals = new System.Windows.Forms.ListBox();
            this.cboWeekdays = new System.Windows.Forms.ComboBox();
            this.grpWeekPlan.SuspendLayout();
            this.grpFoodManaging.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFoods
            // 
            this.lblFoods.AutoSize = true;
            this.lblFoods.Location = new System.Drawing.Point(16, 57);
            this.lblFoods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoods.Name = "lblFoods";
            this.lblFoods.Size = new System.Drawing.Size(119, 20);
            this.lblFoods.TabIndex = 1;
            this.lblFoods.Text = "Speiseangebot";
            // 
            // lblWeekday
            // 
            this.lblWeekday.AutoSize = true;
            this.lblWeekday.Location = new System.Drawing.Point(228, 55);
            this.lblWeekday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeekday.Name = "lblWeekday";
            this.lblWeekday.Size = new System.Drawing.Size(93, 20);
            this.lblWeekday.TabIndex = 2;
            this.lblWeekday.Text = "Wochentag";
            // 
            // grpWeekPlan
            // 
            this.grpWeekPlan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpWeekPlan.Controls.Add(this.cmdClear);
            this.grpWeekPlan.Controls.Add(this.cmdCommit);
            this.grpWeekPlan.Controls.Add(this.lboWeekplan);
            this.grpWeekPlan.Controls.Add(this.lblWeekplan);
            this.grpWeekPlan.Location = new System.Drawing.Point(431, 16);
            this.grpWeekPlan.Margin = new System.Windows.Forms.Padding(4);
            this.grpWeekPlan.Name = "grpWeekPlan";
            this.grpWeekPlan.Padding = new System.Windows.Forms.Padding(4);
            this.grpWeekPlan.Size = new System.Drawing.Size(385, 359);
            this.grpWeekPlan.TabIndex = 4;
            this.grpWeekPlan.TabStop = false;
            this.grpWeekPlan.Text = "Erstellung";
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(204, 313);
            this.cmdClear.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(168, 38);
            this.cmdClear.TabIndex = 3;
            this.cmdClear.Text = "Leeren";
            this.cmdClear.UseVisualStyleBackColor = true;
            // 
            // cmdCommit
            // 
            this.cmdCommit.Location = new System.Drawing.Point(13, 313);
            this.cmdCommit.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCommit.Name = "cmdCommit";
            this.cmdCommit.Size = new System.Drawing.Size(164, 39);
            this.cmdCommit.TabIndex = 2;
            this.cmdCommit.Text = "Übernehmen";
            this.cmdCommit.UseVisualStyleBackColor = true;
            this.cmdCommit.Click += new System.EventHandler(this.cmdCommit_Click);
            // 
            // lboWeekplan
            // 
            this.lboWeekplan.FormattingEnabled = true;
            this.lboWeekplan.ItemHeight = 20;
            this.lboWeekplan.Location = new System.Drawing.Point(13, 62);
            this.lboWeekplan.Margin = new System.Windows.Forms.Padding(4);
            this.lboWeekplan.Name = "lboWeekplan";
            this.lboWeekplan.Size = new System.Drawing.Size(357, 224);
            this.lboWeekplan.TabIndex = 1;
            // 
            // lblWeekplan
            // 
            this.lblWeekplan.AutoSize = true;
            this.lblWeekplan.Location = new System.Drawing.Point(9, 25);
            this.lblWeekplan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeekplan.Name = "lblWeekplan";
            this.lblWeekplan.Size = new System.Drawing.Size(101, 20);
            this.lblWeekplan.TabIndex = 0;
            this.lblWeekplan.Text = "Wochenplan";
            // 
            // grpFoodManaging
            // 
            this.grpFoodManaging.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpFoodManaging.Controls.Add(this.cmdDelete);
            this.grpFoodManaging.Controls.Add(this.cmdAdd);
            this.grpFoodManaging.Controls.Add(this.txtFood);
            this.grpFoodManaging.Controls.Add(this.lblFood);
            this.grpFoodManaging.Location = new System.Drawing.Point(20, 329);
            this.grpFoodManaging.Margin = new System.Windows.Forms.Padding(4);
            this.grpFoodManaging.Name = "grpFoodManaging";
            this.grpFoodManaging.Padding = new System.Windows.Forms.Padding(4);
            this.grpFoodManaging.Size = new System.Drawing.Size(373, 151);
            this.grpFoodManaging.TabIndex = 5;
            this.grpFoodManaging.TabStop = false;
            this.grpFoodManaging.Text = "Verwaltung";
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(201, 95);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(4);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(164, 39);
            this.cmdDelete.TabIndex = 4;
            this.cmdDelete.Text = "Entfernen";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(13, 95);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(164, 39);
            this.cmdAdd.TabIndex = 3;
            this.cmdAdd.Text = "Hinzufügen";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(91, 37);
            this.txtFood.Margin = new System.Windows.Forms.Padding(4);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(273, 26);
            this.txtFood.TabIndex = 1;
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(9, 37);
            this.lblFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(60, 20);
            this.lblFood.TabIndex = 0;
            this.lblFood.Text = "Speise";
            // 
            // cmdEnd
            // 
            this.cmdEnd.Location = new System.Drawing.Point(621, 423);
            this.cmdEnd.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEnd.Name = "cmdEnd";
            this.cmdEnd.Size = new System.Drawing.Size(181, 39);
            this.cmdEnd.TabIndex = 6;
            this.cmdEnd.Text = "Beenden";
            this.cmdEnd.UseVisualStyleBackColor = true;
            this.cmdEnd.Click += new System.EventHandler(this.cmdEnd_Click);
            // 
            // lboMeals
            // 
            this.lboMeals.FormattingEnabled = true;
            this.lboMeals.ItemHeight = 20;
            this.lboMeals.Location = new System.Drawing.Point(20, 90);
            this.lboMeals.Name = "lboMeals";
            this.lboMeals.Size = new System.Drawing.Size(161, 204);
            this.lboMeals.TabIndex = 7;
            // 
            // cboWeekdays
            // 
            this.cboWeekdays.FormattingEnabled = true;
            this.cboWeekdays.Items.AddRange(new object[] {
            "Montag",
            "Dienstag",
            "Mittwoch",
            "Donnerstag",
            "Freitag"});
            this.cboWeekdays.Location = new System.Drawing.Point(232, 90);
            this.cboWeekdays.Name = "cboWeekdays";
            this.cboWeekdays.Size = new System.Drawing.Size(121, 28);
            this.cboWeekdays.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 496);
            this.Controls.Add(this.cboWeekdays);
            this.Controls.Add(this.lboMeals);
            this.Controls.Add(this.cmdEnd);
            this.Controls.Add(this.grpFoodManaging);
            this.Controls.Add(this.grpWeekPlan);
            this.Controls.Add(this.lblWeekday);
            this.Controls.Add(this.lblFoods);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Speiseplan erstellen";
            this.grpWeekPlan.ResumeLayout(false);
            this.grpWeekPlan.PerformLayout();
            this.grpFoodManaging.ResumeLayout(false);
            this.grpFoodManaging.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFoods;
        private System.Windows.Forms.Label lblWeekday;
        private System.Windows.Forms.GroupBox grpWeekPlan;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdCommit;
        private System.Windows.Forms.ListBox lboWeekplan;
        private System.Windows.Forms.Label lblWeekplan;
        private System.Windows.Forms.GroupBox grpFoodManaging;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Button cmdEnd;
        private System.Windows.Forms.ListBox lboMeals;
        private System.Windows.Forms.ComboBox cboWeekdays;
    }
}

