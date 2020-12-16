
namespace FinalProjectForm
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
            this.buttonAddAnimal = new System.Windows.Forms.Button();
            this.listBoxAnimal = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonLOA = new System.Windows.Forms.Button();
            this.labelConfirmAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddAnimal.Location = new System.Drawing.Point(454, 290);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(164, 56);
            this.buttonAddAnimal.TabIndex = 5;
            this.buttonAddAnimal.Text = "Add Animal";
            this.buttonAddAnimal.UseVisualStyleBackColor = false;
            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
            // 
            // listBoxAnimal
            // 
            this.listBoxAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBoxAnimal.FormattingEnabled = true;
            this.listBoxAnimal.ItemHeight = 25;
            this.listBoxAnimal.Location = new System.Drawing.Point(26, 42);
            this.listBoxAnimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxAnimal.Name = "listBoxAnimal";
            this.listBoxAnimal.Size = new System.Drawing.Size(194, 279);
            this.listBoxAnimal.TabIndex = 1;
            this.listBoxAnimal.SelectedIndexChanged += new System.EventHandler(this.listBoxAnimal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(288, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Type";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelType.Location = new System.Drawing.Point(256, 97);
            this.labelType.MinimumSize = new System.Drawing.Size(145, 29);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(145, 29);
            this.labelType.TabIndex = 5;
            this.labelType.Text = "Cow";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(499, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id #";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxId.Location = new System.Drawing.Point(459, 94);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(159, 37);
            this.textBoxId.TabIndex = 2;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(688, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gender";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unknown"});
            this.comboBoxGender.Location = new System.Drawing.Point(671, 94);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(159, 37);
            this.comboBoxGender.TabIndex = 3;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(432, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 35);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // buttonLOA
            // 
            this.buttonLOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonLOA.Location = new System.Drawing.Point(649, 289);
            this.buttonLOA.Name = "buttonLOA";
            this.buttonLOA.Size = new System.Drawing.Size(210, 57);
            this.buttonLOA.TabIndex = 14;
            this.buttonLOA.Text = "List of Animals";
            this.buttonLOA.UseVisualStyleBackColor = true;
            this.buttonLOA.Click += new System.EventHandler(this.buttonLOA_Click);
            // 
            // labelConfirmAdd
            // 
            this.labelConfirmAdd.AutoSize = true;
            this.labelConfirmAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelConfirmAdd.Location = new System.Drawing.Point(265, 303);
            this.labelConfirmAdd.Name = "labelConfirmAdd";
            this.labelConfirmAdd.Size = new System.Drawing.Size(0, 29);
            this.labelConfirmAdd.TabIndex = 15;
            this.labelConfirmAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelConfirmAdd);
            this.Controls.Add(this.buttonLOA);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxAnimal);
            this.Controls.Add(this.buttonAddAnimal);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Animal Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddAnimal;
        private System.Windows.Forms.ListBox listBoxAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonLOA;
        private System.Windows.Forms.Label labelConfirmAdd;
    }
}

