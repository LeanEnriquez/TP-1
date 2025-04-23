namespace TP_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddPrincipal = new Button();
            btnDeleted = new Button();
            btnUpdate = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // btnAddPrincipal
            // 
            btnAddPrincipal.Location = new Point(293, 12);
            btnAddPrincipal.Name = "btnAddPrincipal";
            btnAddPrincipal.Size = new Size(87, 43);
            btnAddPrincipal.TabIndex = 0;
            btnAddPrincipal.Text = "Agregar Alumno";
            btnAddPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnDeleted
            // 
            btnDeleted.Location = new Point(403, 12);
            btnDeleted.Name = "btnDeleted";
            btnDeleted.Size = new Size(87, 48);
            btnDeleted.TabIndex = 1;
            btnDeleted.Text = "Borrar Alumno";
            btnDeleted.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(345, 86);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 40);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Modificar Alumno";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 29);
            listView1.Name = "listView1";
            listView1.Size = new Size(258, 207);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 417);
            Controls.Add(listView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDeleted);
            Controls.Add(btnAddPrincipal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddPrincipal;
        private Button btnDeleted;
        private Button btnUpdate;
        private ListView listView1;
    }
}
