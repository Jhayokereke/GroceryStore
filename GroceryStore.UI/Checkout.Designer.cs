
namespace GroceryStore.UI
{
    partial class Checkout
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
            this.Item_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Minus_Btn = new System.Windows.Forms.Button();
            this.Enter_Btn = new System.Windows.Forms.Button();
            this.DisplayScreen = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemCount_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Item_txtbox
            // 
            this.Item_txtbox.Location = new System.Drawing.Point(12, 79);
            this.Item_txtbox.Name = "Item_txtbox";
            this.Item_txtbox.PlaceholderText = "Product Id";
            this.Item_txtbox.Size = new System.Drawing.Size(309, 27);
            this.Item_txtbox.TabIndex = 0;
            this.Item_txtbox.TextChanged += new System.EventHandler(this.Item_txtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item";
            // 
            // Add_Btn
            // 
            this.Add_Btn.BackColor = System.Drawing.Color.Green;
            this.Add_Btn.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_Btn.Location = new System.Drawing.Point(12, 112);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(28, 29);
            this.Add_Btn.TabIndex = 2;
            this.Add_Btn.Text = "+";
            this.Add_Btn.UseVisualStyleBackColor = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Minus_Btn
            // 
            this.Minus_Btn.BackColor = System.Drawing.Color.Red;
            this.Minus_Btn.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Minus_Btn.Location = new System.Drawing.Point(46, 112);
            this.Minus_Btn.Name = "Minus_Btn";
            this.Minus_Btn.Size = new System.Drawing.Size(28, 29);
            this.Minus_Btn.TabIndex = 3;
            this.Minus_Btn.Text = "-";
            this.Minus_Btn.UseVisualStyleBackColor = false;
            this.Minus_Btn.Click += new System.EventHandler(this.Minus_Btn_Click);
            // 
            // Enter_Btn
            // 
            this.Enter_Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Enter_Btn.Location = new System.Drawing.Point(227, 112);
            this.Enter_Btn.Name = "Enter_Btn";
            this.Enter_Btn.Size = new System.Drawing.Size(94, 29);
            this.Enter_Btn.TabIndex = 4;
            this.Enter_Btn.Text = "Enter";
            this.Enter_Btn.UseVisualStyleBackColor = false;
            this.Enter_Btn.Click += new System.EventHandler(this.Enter_Btn_Click);
            // 
            // DisplayScreen
            // 
            this.DisplayScreen.Location = new System.Drawing.Point(384, 62);
            this.DisplayScreen.Name = "DisplayScreen";
            this.DisplayScreen.Size = new System.Drawing.Size(404, 324);
            this.DisplayScreen.TabIndex = 5;
            this.DisplayScreen.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(694, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(217, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Checkout";
            // 
            // ItemCount_Label
            // 
            this.ItemCount_Label.AutoSize = true;
            this.ItemCount_Label.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemCount_Label.Location = new System.Drawing.Point(156, 115);
            this.ItemCount_Label.Name = "ItemCount_Label";
            this.ItemCount_Label.Size = new System.Drawing.Size(0, 18);
            this.ItemCount_Label.TabIndex = 8;
            this.ItemCount_Label.Click += new System.EventHandler(this.ItemCount_Label_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ItemCount_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DisplayScreen);
            this.Controls.Add(this.Enter_Btn);
            this.Controls.Add(this.Minus_Btn);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Item_txtbox);
            this.Name = "Checkout";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Item_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Minus_Btn;
        private System.Windows.Forms.Button Enter_Btn;
        private System.Windows.Forms.RichTextBox DisplayScreen;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ItemCount_Label;
    }
}

