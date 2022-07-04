namespace Bhumi_Healthcare
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdReception = new System.Windows.Forms.Button();
            this.cmdDoctor = new System.Windows.Forms.Button();
            this.cmdStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECEPTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOCTOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "STAFF";
            // 
            // cmdReception
            // 
            this.cmdReception.Location = new System.Drawing.Point(288, 65);
            this.cmdReception.Name = "cmdReception";
            this.cmdReception.Size = new System.Drawing.Size(122, 34);
            this.cmdReception.TabIndex = 3;
            this.cmdReception.Text = "ENTER";
            this.cmdReception.UseVisualStyleBackColor = true;
            this.cmdReception.Click += new System.EventHandler(this.cmdReception_Click);
            // 
            // cmdDoctor
            // 
            this.cmdDoctor.Location = new System.Drawing.Point(286, 140);
            this.cmdDoctor.Name = "cmdDoctor";
            this.cmdDoctor.Size = new System.Drawing.Size(117, 41);
            this.cmdDoctor.TabIndex = 4;
            this.cmdDoctor.Text = "ENTER";
            this.cmdDoctor.UseVisualStyleBackColor = true;
            this.cmdDoctor.Click += new System.EventHandler(this.cmdDoctor_Click);
            // 
            // cmdStaff
            // 
            this.cmdStaff.Location = new System.Drawing.Point(295, 234);
            this.cmdStaff.Name = "cmdStaff";
            this.cmdStaff.Size = new System.Drawing.Size(115, 36);
            this.cmdStaff.TabIndex = 5;
            this.cmdStaff.Text = "ENTER";
            this.cmdStaff.UseVisualStyleBackColor = true;
            this.cmdStaff.Click += new System.EventHandler(this.cmdStaff_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdStaff);
            this.Controls.Add(this.cmdDoctor);
            this.Controls.Add(this.cmdReception);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdReception;
        private System.Windows.Forms.Button cmdDoctor;
        private System.Windows.Forms.Button cmdStaff;
    }
}