using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace tic_tac_toe_vb
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelProgramName1 = new Label();
            labelProgramName1.Click += new EventHandler(labelProgramName1_Click);
            labelProgramName2 = new Label();
            btnRow1Column1 = new Button();
            btnRow1Column1.Click += new EventHandler(btnRow1Column1_Click);
            btnRow1Column2 = new Button();
            btnRow1Column2.Click += new EventHandler(btnRow1Column2_Click);
            btnRow1Column3 = new Button();
            btnRow1Column3.Click += new EventHandler(btnRow1Column3_Click);
            btnRow2Column3 = new Button();
            btnRow2Column3.Click += new EventHandler(btnRow2Column3_Click);
            btnRow2Column2 = new Button();
            btnRow2Column2.Click += new EventHandler(btnRow2Column2_Click);
            btnRow2Column1 = new Button();
            btnRow2Column1.Click += new EventHandler(btnRow2Column1_Click);
            btnRow3Column3 = new Button();
            btnRow3Column3.Click += new EventHandler(btnRow3Column3_Click);
            btnRow3Column2 = new Button();
            btnRow3Column2.Click += new EventHandler(btnRow3Column2_Click);
            btnRow3Column1 = new Button();
            btnRow3Column1.Click += new EventHandler(btnRow3Column1_Click);
            labelXsScore = new Label();
            labelXScore = new Label();
            labelXScore.Click += new EventHandler(labelXScore_Click);
            labelOsScore = new Label();
            labelOScore = new Label();
            btnResetGrid = new Button();
            btnResetGrid.Click += new EventHandler(btnResetGrid_Click);
            btnResetScores = new Button();
            btnResetScores.Click += new EventHandler(btnResetScores_Click);
            SuspendLayout();
            // 
            // labelProgramName1
            // 
            labelProgramName1.AutoSize = true;
            labelProgramName1.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProgramName1.Location = new Point(75, 28);
            labelProgramName1.Name = "labelProgramName1";
            labelProgramName1.Size = new Size(294, 25);
            labelProgramName1.TabIndex = 0;
            labelProgramName1.Text = "Bernard Cammayo Narceda's";
            labelProgramName1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelProgramName2
            // 
            labelProgramName2.AutoSize = true;
            labelProgramName2.Font = new Font("Game Commands", 12.0f);
            labelProgramName2.Location = new Point(42, 66);
            labelProgramName2.Name = "labelProgramName2";
            labelProgramName2.Size = new Size(391, 37);
            labelProgramName2.TabIndex = 1;
            labelProgramName2.Text = "TIC-TAC-TOE";
            labelProgramName2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRow1Column1
            // 
            btnRow1Column1.BackColor = Color.White;
            btnRow1Column1.FlatAppearance.BorderColor = Color.Black;
            btnRow1Column1.FlatAppearance.BorderSize = 3;
            btnRow1Column1.FlatStyle = FlatStyle.Flat;
            btnRow1Column1.Font = new Font("Edo SZ", 40.0f);
            btnRow1Column1.ForeColor = Color.Black;
            btnRow1Column1.Location = new Point(52, 121);
            btnRow1Column1.Name = "btnRow1Column1";
            btnRow1Column1.Size = new Size(120, 120);
            btnRow1Column1.TabIndex = 2;
            btnRow1Column1.TextAlign = ContentAlignment.TopCenter;
            btnRow1Column1.UseVisualStyleBackColor = false;
            // 
            // btnRow1Column2
            // 
            btnRow1Column2.BackColor = Color.White;
            btnRow1Column2.FlatAppearance.BorderColor = Color.Black;
            btnRow1Column2.FlatAppearance.BorderSize = 3;
            btnRow1Column2.FlatStyle = FlatStyle.Flat;
            btnRow1Column2.Font = new Font("Edo SZ", 40.0f);
            btnRow1Column2.ForeColor = Color.Black;
            btnRow1Column2.Location = new Point(177, 121);
            btnRow1Column2.Name = "btnRow1Column2";
            btnRow1Column2.Size = new Size(120, 120);
            btnRow1Column2.TabIndex = 3;
            btnRow1Column2.TextAlign = ContentAlignment.TopCenter;
            btnRow1Column2.UseVisualStyleBackColor = false;
            // 
            // btnRow1Column3
            // 
            btnRow1Column3.BackColor = Color.White;
            btnRow1Column3.FlatAppearance.BorderColor = Color.Black;
            btnRow1Column3.FlatAppearance.BorderSize = 3;
            btnRow1Column3.FlatStyle = FlatStyle.Flat;
            btnRow1Column3.Font = new Font("Edo SZ", 40.0f);
            btnRow1Column3.ForeColor = Color.Black;
            btnRow1Column3.Location = new Point(302, 121);
            btnRow1Column3.Name = "btnRow1Column3";
            btnRow1Column3.Size = new Size(120, 120);
            btnRow1Column3.TabIndex = 4;
            btnRow1Column3.TextAlign = ContentAlignment.TopCenter;
            btnRow1Column3.UseVisualStyleBackColor = false;
            // 
            // btnRow2Column3
            // 
            btnRow2Column3.BackColor = Color.White;
            btnRow2Column3.FlatAppearance.BorderColor = Color.Black;
            btnRow2Column3.FlatAppearance.BorderSize = 3;
            btnRow2Column3.FlatStyle = FlatStyle.Flat;
            btnRow2Column3.Font = new Font("Edo SZ", 40.0f);
            btnRow2Column3.ForeColor = Color.Black;
            btnRow2Column3.Location = new Point(302, 247);
            btnRow2Column3.Name = "btnRow2Column3";
            btnRow2Column3.Size = new Size(120, 120);
            btnRow2Column3.TabIndex = 7;
            btnRow2Column3.TextAlign = ContentAlignment.TopCenter;
            btnRow2Column3.UseVisualStyleBackColor = false;
            // 
            // btnRow2Column2
            // 
            btnRow2Column2.BackColor = Color.White;
            btnRow2Column2.FlatAppearance.BorderColor = Color.Black;
            btnRow2Column2.FlatAppearance.BorderSize = 3;
            btnRow2Column2.FlatStyle = FlatStyle.Flat;
            btnRow2Column2.Font = new Font("Edo SZ", 40.0f);
            btnRow2Column2.ForeColor = Color.Black;
            btnRow2Column2.Location = new Point(177, 247);
            btnRow2Column2.Name = "btnRow2Column2";
            btnRow2Column2.Size = new Size(120, 120);
            btnRow2Column2.TabIndex = 6;
            btnRow2Column2.TextAlign = ContentAlignment.TopCenter;
            btnRow2Column2.UseVisualStyleBackColor = false;
            // 
            // btnRow2Column1
            // 
            btnRow2Column1.BackColor = Color.White;
            btnRow2Column1.FlatAppearance.BorderColor = Color.Black;
            btnRow2Column1.FlatAppearance.BorderSize = 3;
            btnRow2Column1.FlatStyle = FlatStyle.Flat;
            btnRow2Column1.Font = new Font("Edo SZ", 40.0f);
            btnRow2Column1.ForeColor = Color.Black;
            btnRow2Column1.Location = new Point(52, 247);
            btnRow2Column1.Name = "btnRow2Column1";
            btnRow2Column1.Size = new Size(120, 120);
            btnRow2Column1.TabIndex = 5;
            btnRow2Column1.TextAlign = ContentAlignment.TopCenter;
            btnRow2Column1.UseVisualStyleBackColor = false;
            // 
            // btnRow3Column3
            // 
            btnRow3Column3.BackColor = Color.White;
            btnRow3Column3.FlatAppearance.BorderColor = Color.Black;
            btnRow3Column3.FlatAppearance.BorderSize = 3;
            btnRow3Column3.FlatStyle = FlatStyle.Flat;
            btnRow3Column3.Font = new Font("Edo SZ", 40.0f);
            btnRow3Column3.ForeColor = Color.Black;
            btnRow3Column3.Location = new Point(302, 373);
            btnRow3Column3.Name = "btnRow3Column3";
            btnRow3Column3.Size = new Size(120, 120);
            btnRow3Column3.TabIndex = 10;
            btnRow3Column3.TextAlign = ContentAlignment.TopCenter;
            btnRow3Column3.UseVisualStyleBackColor = false;
            // 
            // btnRow3Column2
            // 
            btnRow3Column2.BackColor = Color.White;
            btnRow3Column2.FlatAppearance.BorderColor = Color.Black;
            btnRow3Column2.FlatAppearance.BorderSize = 3;
            btnRow3Column2.FlatStyle = FlatStyle.Flat;
            btnRow3Column2.Font = new Font("Edo SZ", 40.0f);
            btnRow3Column2.ForeColor = Color.Black;
            btnRow3Column2.Location = new Point(177, 373);
            btnRow3Column2.Name = "btnRow3Column2";
            btnRow3Column2.Size = new Size(120, 120);
            btnRow3Column2.TabIndex = 9;
            btnRow3Column2.TextAlign = ContentAlignment.TopCenter;
            btnRow3Column2.UseVisualStyleBackColor = false;
            // 
            // btnRow3Column1
            // 
            btnRow3Column1.BackColor = Color.White;
            btnRow3Column1.FlatAppearance.BorderColor = Color.Black;
            btnRow3Column1.FlatAppearance.BorderSize = 3;
            btnRow3Column1.FlatStyle = FlatStyle.Flat;
            btnRow3Column1.Font = new Font("Edo SZ", 40.0f);
            btnRow3Column1.ForeColor = Color.Black;
            btnRow3Column1.Location = new Point(52, 373);
            btnRow3Column1.Name = "btnRow3Column1";
            btnRow3Column1.Size = new Size(120, 120);
            btnRow3Column1.TabIndex = 8;
            btnRow3Column1.TextAlign = ContentAlignment.TopCenter;
            btnRow3Column1.UseVisualStyleBackColor = false;
            // 
            // labelXsScore
            // 
            labelXsScore.AutoSize = true;
            labelXsScore.Location = new Point(48, 510);
            labelXsScore.Name = "labelXsScore";
            labelXsScore.Size = new Size(81, 20);
            labelXsScore.TabIndex = 12;
            labelXsScore.Text = "X's Score:";
            // 
            // labelXScore
            // 
            labelXScore.BackColor = Color.White;
            labelXScore.BorderStyle = BorderStyle.Fixed3D;
            labelXScore.Location = new Point(135, 510);
            labelXScore.Name = "labelXScore";
            labelXScore.Size = new Size(30, 20);
            labelXScore.TabIndex = 13;
            labelXScore.Text = "0";
            labelXScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOsScore
            // 
            labelOsScore.AutoSize = true;
            labelOsScore.Location = new Point(48, 540);
            labelOsScore.Name = "labelOsScore";
            labelOsScore.Size = new Size(82, 20);
            labelOsScore.TabIndex = 14;
            labelOsScore.Text = "O's Score:";
            // 
            // labelOScore
            // 
            labelOScore.BackColor = Color.White;
            labelOScore.BorderStyle = BorderStyle.Fixed3D;
            labelOScore.Location = new Point(135, 540);
            labelOScore.Name = "labelOScore";
            labelOScore.Size = new Size(30, 20);
            labelOScore.TabIndex = 15;
            labelOScore.Text = "0";
            labelOScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnResetGrid
            // 
            btnResetGrid.BackColor = Color.Red;
            btnResetGrid.Location = new Point(302, 510);
            btnResetGrid.Name = "btnResetGrid";
            btnResetGrid.Size = new Size(120, 50);
            btnResetGrid.TabIndex = 17;
            btnResetGrid.Text = "Reset Grid";
            btnResetGrid.UseVisualStyleBackColor = false;
            // 
            // btnResetScores
            // 
            btnResetScores.BackColor = Color.Yellow;
            btnResetScores.Location = new Point(177, 510);
            btnResetScores.Name = "btnResetScores";
            btnResetScores.Size = new Size(120, 50);
            btnResetScores.TabIndex = 18;
            btnResetScores.Text = "Reset Scores";
            btnResetScores.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(477, 581);
            Controls.Add(btnRow3Column3);
            Controls.Add(btnRow3Column2);
            Controls.Add(btnRow3Column1);
            Controls.Add(btnRow2Column3);
            Controls.Add(btnRow2Column2);
            Controls.Add(btnRow2Column1);
            Controls.Add(btnRow1Column3);
            Controls.Add(btnRow1Column2);
            Controls.Add(btnRow1Column1);
            Controls.Add(btnResetScores);
            Controls.Add(btnResetGrid);
            Controls.Add(labelOScore);
            Controls.Add(labelOsScore);
            Controls.Add(labelXScore);
            Controls.Add(labelXsScore);
            Controls.Add(labelProgramName2);
            Controls.Add(labelProgramName1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BCN's TIC-TAC-TOE";
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label labelProgramName1;
        internal Label labelProgramName2;
        internal Button btnRow1Column1;
        internal Button btnRow1Column2;
        internal Button btnRow1Column3;
        internal Button btnRow2Column3;
        internal Button btnRow2Column2;
        internal Button btnRow2Column1;
        internal Button btnRow3Column3;
        internal Button btnRow3Column2;
        internal Button btnRow3Column1;
        internal Label labelXsScore;
        internal Label labelXScore;
        internal Label labelOsScore;
        internal Label labelOScore;
        internal Button btnResetGrid;
        internal Button btnResetScores;
    }
}