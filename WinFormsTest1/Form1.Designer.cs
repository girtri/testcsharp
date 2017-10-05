namespace WinFormsTest1
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
            this.cmdLinq = new System.Windows.Forms.Button();
            this.cmdExtesion = new System.Windows.Forms.Button();
            this.cmdLazy = new System.Windows.Forms.Button();
            this.cmdDynamic = new System.Windows.Forms.Button();
            this.cmdTask = new System.Windows.Forms.Button();
            this.cmdAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdLinq
            // 
            this.cmdLinq.Location = new System.Drawing.Point(123, 29);
            this.cmdLinq.Name = "cmdLinq";
            this.cmdLinq.Size = new System.Drawing.Size(75, 44);
            this.cmdLinq.TabIndex = 0;
            this.cmdLinq.Text = "Linq";
            this.cmdLinq.UseVisualStyleBackColor = true;
            this.cmdLinq.Click += new System.EventHandler(this.cmdLinq_Click);
            // 
            // cmdExtesion
            // 
            this.cmdExtesion.Location = new System.Drawing.Point(33, 29);
            this.cmdExtesion.Name = "cmdExtesion";
            this.cmdExtesion.Size = new System.Drawing.Size(75, 44);
            this.cmdExtesion.TabIndex = 1;
            this.cmdExtesion.Text = "Extension Method";
            this.cmdExtesion.UseVisualStyleBackColor = true;
            this.cmdExtesion.Click += new System.EventHandler(this.cmdExtesion_Click);
            // 
            // cmdLazy
            // 
            this.cmdLazy.Location = new System.Drawing.Point(216, 29);
            this.cmdLazy.Name = "cmdLazy";
            this.cmdLazy.Size = new System.Drawing.Size(81, 44);
            this.cmdLazy.TabIndex = 2;
            this.cmdLazy.Text = "Lazy";
            this.cmdLazy.UseVisualStyleBackColor = true;
            this.cmdLazy.Click += new System.EventHandler(this.cmdLazy_Click);
            // 
            // cmdDynamic
            // 
            this.cmdDynamic.Location = new System.Drawing.Point(309, 29);
            this.cmdDynamic.Name = "cmdDynamic";
            this.cmdDynamic.Size = new System.Drawing.Size(75, 44);
            this.cmdDynamic.TabIndex = 3;
            this.cmdDynamic.Text = "Dynamic";
            this.cmdDynamic.UseVisualStyleBackColor = true;
            this.cmdDynamic.Click += new System.EventHandler(this.cmdDynamic_Click);
            // 
            // cmdTask
            // 
            this.cmdTask.Location = new System.Drawing.Point(399, 29);
            this.cmdTask.Name = "cmdTask";
            this.cmdTask.Size = new System.Drawing.Size(75, 44);
            this.cmdTask.TabIndex = 4;
            this.cmdTask.Text = "Task";
            this.cmdTask.UseVisualStyleBackColor = true;
            this.cmdTask.Click += new System.EventHandler(this.cmdTask_Click);
            // 
            // cmdAsync
            // 
            this.cmdAsync.Location = new System.Drawing.Point(33, 89);
            this.cmdAsync.Name = "cmdAsync";
            this.cmdAsync.Size = new System.Drawing.Size(75, 44);
            this.cmdAsync.TabIndex = 5;
            this.cmdAsync.Text = "async / await";
            this.cmdAsync.UseVisualStyleBackColor = true;
            this.cmdAsync.Click += new System.EventHandler(this.cmdAsync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 260);
            this.Controls.Add(this.cmdAsync);
            this.Controls.Add(this.cmdTask);
            this.Controls.Add(this.cmdDynamic);
            this.Controls.Add(this.cmdLazy);
            this.Controls.Add(this.cmdExtesion);
            this.Controls.Add(this.cmdLinq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdLinq;
        private System.Windows.Forms.Button cmdExtesion;
        private System.Windows.Forms.Button cmdLazy;
        private System.Windows.Forms.Button cmdDynamic;
        private System.Windows.Forms.Button cmdTask;
        private System.Windows.Forms.Button cmdAsync;
    }
}

