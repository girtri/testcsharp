namespace WinFormsTest1
{
    partial class C6_Samples
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
            this.cmdStringInter = new System.Windows.Forms.Button();
            this.cmdExFilter = new System.Windows.Forms.Button();
            this.cmdNameOf = new System.Windows.Forms.Button();
            this.cmdAutoProperty = new System.Windows.Forms.Button();
            this.cmdUsingStatic = new System.Windows.Forms.Button();
            this.cmdExprBodied = new System.Windows.Forms.Button();
            this.cmdIndexInit = new System.Windows.Forms.Button();
            this.cmdNullConditional = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdStringInter
            // 
            this.cmdStringInter.Location = new System.Drawing.Point(24, 27);
            this.cmdStringInter.Name = "cmdStringInter";
            this.cmdStringInter.Size = new System.Drawing.Size(73, 41);
            this.cmdStringInter.TabIndex = 0;
            this.cmdStringInter.Text = "string interpol";
            this.cmdStringInter.UseVisualStyleBackColor = true;
            this.cmdStringInter.Click += new System.EventHandler(this.cmdStringInter_Click);
            // 
            // cmdExFilter
            // 
            this.cmdExFilter.Location = new System.Drawing.Point(112, 27);
            this.cmdExFilter.Name = "cmdExFilter";
            this.cmdExFilter.Size = new System.Drawing.Size(73, 41);
            this.cmdExFilter.TabIndex = 1;
            this.cmdExFilter.Text = "Exception Filters";
            this.cmdExFilter.UseVisualStyleBackColor = true;
            this.cmdExFilter.Click += new System.EventHandler(this.cmdExFilter_Click);
            // 
            // cmdNameOf
            // 
            this.cmdNameOf.Location = new System.Drawing.Point(200, 27);
            this.cmdNameOf.Name = "cmdNameOf";
            this.cmdNameOf.Size = new System.Drawing.Size(73, 41);
            this.cmdNameOf.TabIndex = 2;
            this.cmdNameOf.Text = "nameOf";
            this.cmdNameOf.UseVisualStyleBackColor = true;
            this.cmdNameOf.Click += new System.EventHandler(this.cmdNameOf_Click);
            // 
            // cmdAutoProperty
            // 
            this.cmdAutoProperty.Location = new System.Drawing.Point(294, 27);
            this.cmdAutoProperty.Name = "cmdAutoProperty";
            this.cmdAutoProperty.Size = new System.Drawing.Size(73, 41);
            this.cmdAutoProperty.TabIndex = 3;
            this.cmdAutoProperty.Text = "Auto init property";
            this.cmdAutoProperty.UseVisualStyleBackColor = true;
            this.cmdAutoProperty.Click += new System.EventHandler(this.cmdAutoProperty_Click);
            // 
            // cmdUsingStatic
            // 
            this.cmdUsingStatic.Location = new System.Drawing.Point(387, 27);
            this.cmdUsingStatic.Name = "cmdUsingStatic";
            this.cmdUsingStatic.Size = new System.Drawing.Size(73, 41);
            this.cmdUsingStatic.TabIndex = 4;
            this.cmdUsingStatic.Text = "using static";
            this.cmdUsingStatic.UseVisualStyleBackColor = true;
            this.cmdUsingStatic.Click += new System.EventHandler(this.cmdUsingStatic_Click);
            // 
            // cmdExprBodied
            // 
            this.cmdExprBodied.Location = new System.Drawing.Point(24, 88);
            this.cmdExprBodied.Name = "cmdExprBodied";
            this.cmdExprBodied.Size = new System.Drawing.Size(73, 41);
            this.cmdExprBodied.TabIndex = 5;
            this.cmdExprBodied.Text = "Expression bodied";
            this.cmdExprBodied.UseVisualStyleBackColor = true;
            this.cmdExprBodied.Click += new System.EventHandler(this.cmdExprBodied_Click);
            // 
            // cmdIndexInit
            // 
            this.cmdIndexInit.Location = new System.Drawing.Point(112, 88);
            this.cmdIndexInit.Name = "cmdIndexInit";
            this.cmdIndexInit.Size = new System.Drawing.Size(73, 41);
            this.cmdIndexInit.TabIndex = 6;
            this.cmdIndexInit.Text = "index init";
            this.cmdIndexInit.UseVisualStyleBackColor = true;
            this.cmdIndexInit.Click += new System.EventHandler(this.cmdIndexInit_Click);
            // 
            // cmdNullConditional
            // 
            this.cmdNullConditional.Location = new System.Drawing.Point(200, 88);
            this.cmdNullConditional.Name = "cmdNullConditional";
            this.cmdNullConditional.Size = new System.Drawing.Size(73, 41);
            this.cmdNullConditional.TabIndex = 7;
            this.cmdNullConditional.Text = "null conditional";
            this.cmdNullConditional.UseVisualStyleBackColor = true;
            this.cmdNullConditional.Click += new System.EventHandler(this.cmdNullConditional_Click);
            // 
            // C6_Samples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 347);
            this.Controls.Add(this.cmdNullConditional);
            this.Controls.Add(this.cmdIndexInit);
            this.Controls.Add(this.cmdExprBodied);
            this.Controls.Add(this.cmdUsingStatic);
            this.Controls.Add(this.cmdAutoProperty);
            this.Controls.Add(this.cmdNameOf);
            this.Controls.Add(this.cmdExFilter);
            this.Controls.Add(this.cmdStringInter);
            this.Name = "C6_Samples";
            this.Text = "C6_Samples";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdStringInter;
        private System.Windows.Forms.Button cmdExFilter;
        private System.Windows.Forms.Button cmdNameOf;
        private System.Windows.Forms.Button cmdAutoProperty;
        private System.Windows.Forms.Button cmdUsingStatic;
        private System.Windows.Forms.Button cmdExprBodied;
        private System.Windows.Forms.Button cmdIndexInit;
        private System.Windows.Forms.Button cmdNullConditional;
    }
}