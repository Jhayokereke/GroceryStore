
using System;

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
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemCount_Label = new System.Windows.Forms.Label();
            this.AvailblProd_display = new System.Windows.Forms.RichTextBox();
            this.AvailablProd_label = new System.Windows.Forms.Label();
            this.Total_label = new System.Windows.Forms.Label();
            this.Print_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Item_txtbox
            // 
            this.Item_txtbox.Location = new System.Drawing.Point(12, 239);
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
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item";
            // 
            // Add_Btn
            // 
            this.Add_Btn.BackColor = System.Drawing.Color.Green;
            this.Add_Btn.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_Btn.Location = new System.Drawing.Point(12, 272);
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
            this.Minus_Btn.Location = new System.Drawing.Point(46, 272);
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
            this.Enter_Btn.Location = new System.Drawing.Point(227, 272);
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
            // Confirm_btn
            // 
            this.Confirm_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Confirm_btn.Location = new System.Drawing.Point(541, 392);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(94, 29);
            this.Confirm_btn.TabIndex = 6;
            this.Confirm_btn.Text = "Confirm";
            this.Confirm_btn.UseVisualStyleBackColor = false;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
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
            this.ItemCount_Label.Location = new System.Drawing.Point(125, 283);
            this.ItemCount_Label.Name = "ItemCount_Label";
            this.ItemCount_Label.Size = new System.Drawing.Size(0, 18);
            this.ItemCount_Label.TabIndex = 8;
            // 
            // AvailblProd_display
            // 
            this.AvailblProd_display.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AvailblProd_display.Location = new System.Drawing.Point(12, 82);
            this.AvailblProd_display.Name = "AvailblProd_display";
            this.AvailblProd_display.Size = new System.Drawing.Size(350, 120);
            this.AvailblProd_display.TabIndex = 9;
            this.AvailblProd_display.Text = "";
            // 
            // AvailablProd_label
            // 
            this.AvailablProd_label.AutoSize = true;
            this.AvailablProd_label.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AvailablProd_label.Location = new System.Drawing.Point(12, 61);
            this.AvailablProd_label.Name = "AvailablProd_label";
            this.AvailablProd_label.Size = new System.Drawing.Size(167, 18);
            this.AvailablProd_label.TabIndex = 10;
            this.AvailablProd_label.Text = "Available Products";
            // 
            // Total_label
            // 
            this.Total_label.AutoSize = true;
            this.Total_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Total_label.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Total_label.ForeColor = System.Drawing.Color.Lime;
            this.Total_label.Location = new System.Drawing.Point(384, 396);
            this.Total_label.Name = "Total_label";
            this.Total_label.Size = new System.Drawing.Size(57, 20);
            this.Total_label.TabIndex = 11;
            this.Total_label.Text = "Total: ";
            // 
            // Print_btn
            // 
            this.Print_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Print_btn.Location = new System.Drawing.Point(694, 392);
            this.Print_btn.Name = "Print_btn";
            this.Print_btn.Size = new System.Drawing.Size(94, 29);
            this.Print_btn.TabIndex = 12;
            this.Print_btn.Text = "Print";
            this.Print_btn.UseVisualStyleBackColor = false;
            this.Print_btn.Click += new System.EventHandler(this.Print_btn_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Print_btn);
            this.Controls.Add(this.Total_label);
            this.Controls.Add(this.AvailablProd_label);
            this.Controls.Add(this.AvailblProd_display);
            this.Controls.Add(this.ItemCount_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.DisplayScreen);
            this.Controls.Add(this.Enter_Btn);
            this.Controls.Add(this.Minus_Btn);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Item_txtbox);
            this.Name = "Checkout";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ItemCount_Label;
        private System.Windows.Forms.RichTextBox AvailblProd_display;
        private System.Windows.Forms.Label AvailablProd_label;
        private System.Windows.Forms.Label Total_label;
        private System.Windows.Forms.Button Print_btn;
    }
}

