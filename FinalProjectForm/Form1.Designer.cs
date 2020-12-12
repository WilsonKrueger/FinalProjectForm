
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
            this.textBoxDOB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.Location = new System.Drawing.Point(273, 214);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(164, 56);
            this.buttonAddAnimal.TabIndex = 5;
            this.buttonAddAnimal.Text = "Add Animal";
            this.buttonAddAnimal.UseVisualStyleBackColor = true;
            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
            // 
            // listBoxAnimal
            // 
            this.listBoxAnimal.FormattingEnabled = true;
            this.listBoxAnimal.ItemHeight = 20;
            this.listBoxAnimal.Location = new System.Drawing.Point(29, 43);
            this.listBoxAnimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxAnimal.Name = "listBoxAnimal";
            this.listBoxAnimal.Size = new System.Drawing.Size(194, 544);
            this.listBoxAnimal.TabIndex = 1;
            this.listBoxAnimal.SelectedIndexChanged += new System.EventHandler(this.listBoxAnimal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(280, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Type";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelType.Location = new System.Drawing.Point(282, 104);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(0, 29);
            this.labelType.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date of Birth";
            // 
            // textBoxDOB
            // 
            this.textBoxDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxDOB.Location = new System.Drawing.Point(580, 104);
            this.textBoxDOB.Multiline = true;
            this.textBoxDOB.Name = "textBoxDOB";
            this.textBoxDOB.Size = new System.Drawing.Size(188, 40);
            this.textBoxDOB.TabIndex = 3;
            this.textBoxDOB.TextChanged += new System.EventHandler(this.textBoxDOB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(436, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id #";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxId.Location = new System.Drawing.Point(409, 104);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(141, 40);
            this.textBoxId.TabIndex = 2;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(789, 43);
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
            this.comboBoxGender.Location = new System.Drawing.Point(791, 104);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(121, 37);
            this.comboBoxGender.TabIndex = 4;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(455, 459);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(539, 306);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 824);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDOB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.listBoxAnimal);
            this.Controls.Add(this.buttonAddAnimal);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox textBoxDOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
    }
}

