namespace myCookBook
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.label2 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            this.ingredientsList = new System.Windows.Forms.ListBox();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.instructionsBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "COOK BOOK";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(24, 96);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(172, 303);
            this.listBox.TabIndex = 3;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Recipes:";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(538, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeNameLabel.Location = new System.Drawing.Point(277, 87);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(168, 27);
            this.recipeNameLabel.TabIndex = 9;
            this.recipeNameLabel.Text = "Name of the recipe";
            this.recipeNameLabel.Visible = false;
            // 
            // ingredientsList
            // 
            this.ingredientsList.FormattingEnabled = true;
            this.ingredientsList.Location = new System.Drawing.Point(225, 143);
            this.ingredientsList.Name = "ingredientsList";
            this.ingredientsList.Size = new System.Drawing.Size(386, 82);
            this.ingredientsList.TabIndex = 10;
            this.ingredientsList.Visible = false;
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsLabel.Location = new System.Drawing.Point(221, 120);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(84, 20);
            this.ingredientsLabel.TabIndex = 11;
            this.ingredientsLabel.Text = "Ingredients";
            this.ingredientsLabel.Visible = false;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(225, 235);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(93, 20);
            this.instructionsLabel.TabIndex = 12;
            this.instructionsLabel.Text = "Instructions";
            this.instructionsLabel.Visible = false;
            // 
            // instructionsBox
            // 
            this.instructionsBox.Location = new System.Drawing.Point(225, 258);
            this.instructionsBox.Name = "instructionsBox";
            this.instructionsBox.ReadOnly = true;
            this.instructionsBox.Size = new System.Drawing.Size(386, 141);
            this.instructionsBox.TabIndex = 13;
            this.instructionsBox.Text = "";
            this.instructionsBox.Visible = false;
            // 
            // Form
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(633, 468);
            this.Controls.Add(this.instructionsBox);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.ingredientsList);
            this.Controls.Add(this.recipeNameLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(649, 533);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label recipeNameLabel;
        private System.Windows.Forms.ListBox ingredientsList;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.RichTextBox instructionsBox;
    }
}