
namespace Hw_12._6
{
    partial class Painter
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
            this.tlpGroupBoxes = new System.Windows.Forms.TableLayoutPanel();
            this.gbColors = new System.Windows.Forms.GroupBox();
            this.rbColorBlack = new System.Windows.Forms.RadioButton();
            this.rbColorGreen = new System.Windows.Forms.RadioButton();
            this.rbColorBlue = new System.Windows.Forms.RadioButton();
            this.rbColorRed = new System.Windows.Forms.RadioButton();
            this.gbSizes = new System.Windows.Forms.GroupBox();
            this.rbColorLarge = new System.Windows.Forms.RadioButton();
            this.rbColorMedium = new System.Windows.Forms.RadioButton();
            this.rbSizeSmall = new System.Windows.Forms.RadioButton();
            this.tlpGroupBoxes.SuspendLayout();
            this.gbColors.SuspendLayout();
            this.gbSizes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpGroupBoxes
            // 
            this.tlpGroupBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tlpGroupBoxes.ColumnCount = 1;
            this.tlpGroupBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGroupBoxes.Controls.Add(this.gbColors, 0, 0);
            this.tlpGroupBoxes.Controls.Add(this.gbSizes, 0, 1);
            this.tlpGroupBoxes.Location = new System.Drawing.Point(0, -2);
            this.tlpGroupBoxes.Name = "tlpGroupBoxes";
            this.tlpGroupBoxes.RowCount = 2;
            this.tlpGroupBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGroupBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGroupBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGroupBoxes.Size = new System.Drawing.Size(262, 487);
            this.tlpGroupBoxes.TabIndex = 0;
            // 
            // gbColors
            // 
            this.gbColors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbColors.Controls.Add(this.rbColorBlack);
            this.gbColors.Controls.Add(this.rbColorGreen);
            this.gbColors.Controls.Add(this.rbColorBlue);
            this.gbColors.Controls.Add(this.rbColorRed);
            this.gbColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbColors.Location = new System.Drawing.Point(3, 3);
            this.gbColors.Name = "gbColors";
            this.gbColors.Size = new System.Drawing.Size(256, 237);
            this.gbColors.TabIndex = 0;
            this.gbColors.TabStop = false;
            this.gbColors.Text = "Color";
            // 
            // rbColorBlack
            // 
            this.rbColorBlack.AutoSize = true;
            this.rbColorBlack.Location = new System.Drawing.Point(19, 194);
            this.rbColorBlack.Name = "rbColorBlack";
            this.rbColorBlack.Size = new System.Drawing.Size(106, 36);
            this.rbColorBlack.TabIndex = 3;
            this.rbColorBlack.TabStop = true;
            this.rbColorBlack.Text = "Black";
            this.rbColorBlack.UseVisualStyleBackColor = true;
            // 
            // rbColorGreen
            // 
            this.rbColorGreen.AutoSize = true;
            this.rbColorGreen.Location = new System.Drawing.Point(19, 142);
            this.rbColorGreen.Name = "rbColorGreen";
            this.rbColorGreen.Size = new System.Drawing.Size(115, 36);
            this.rbColorGreen.TabIndex = 2;
            this.rbColorGreen.TabStop = true;
            this.rbColorGreen.Text = "Green";
            this.rbColorGreen.UseVisualStyleBackColor = true;
            // 
            // rbColorBlue
            // 
            this.rbColorBlue.AutoSize = true;
            this.rbColorBlue.Location = new System.Drawing.Point(19, 91);
            this.rbColorBlue.Name = "rbColorBlue";
            this.rbColorBlue.Size = new System.Drawing.Size(94, 36);
            this.rbColorBlue.TabIndex = 1;
            this.rbColorBlue.TabStop = true;
            this.rbColorBlue.Text = "Blue";
            this.rbColorBlue.UseVisualStyleBackColor = true;
            // 
            // rbColorRed
            // 
            this.rbColorRed.AutoSize = true;
            this.rbColorRed.Checked = true;
            this.rbColorRed.Location = new System.Drawing.Point(19, 37);
            this.rbColorRed.Name = "rbColorRed";
            this.rbColorRed.Size = new System.Drawing.Size(88, 36);
            this.rbColorRed.TabIndex = 0;
            this.rbColorRed.TabStop = true;
            this.rbColorRed.Text = "Red";
            this.rbColorRed.UseVisualStyleBackColor = true;
            // 
            // gbSizes
            // 
            this.gbSizes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSizes.Controls.Add(this.rbColorLarge);
            this.gbSizes.Controls.Add(this.rbColorMedium);
            this.gbSizes.Controls.Add(this.rbSizeSmall);
            this.gbSizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbSizes.Location = new System.Drawing.Point(3, 246);
            this.gbSizes.Name = "gbSizes";
            this.gbSizes.Size = new System.Drawing.Size(256, 238);
            this.gbSizes.TabIndex = 1;
            this.gbSizes.TabStop = false;
            this.gbSizes.Text = "Size";
            // 
            // rbColorLarge
            // 
            this.rbColorLarge.AutoSize = true;
            this.rbColorLarge.Location = new System.Drawing.Point(19, 155);
            this.rbColorLarge.Name = "rbColorLarge";
            this.rbColorLarge.Size = new System.Drawing.Size(109, 36);
            this.rbColorLarge.TabIndex = 3;
            this.rbColorLarge.TabStop = true;
            this.rbColorLarge.Text = "Large";
            this.rbColorLarge.UseVisualStyleBackColor = true;
            // 
            // rbColorMedium
            // 
            this.rbColorMedium.AutoSize = true;
            this.rbColorMedium.Location = new System.Drawing.Point(19, 102);
            this.rbColorMedium.Name = "rbColorMedium";
            this.rbColorMedium.Size = new System.Drawing.Size(137, 36);
            this.rbColorMedium.TabIndex = 2;
            this.rbColorMedium.Text = "Medium";
            this.rbColorMedium.UseVisualStyleBackColor = true;
            // 
            // rbSizeSmall
            // 
            this.rbSizeSmall.AutoSize = true;
            this.rbSizeSmall.Checked = true;
            this.rbSizeSmall.Location = new System.Drawing.Point(19, 48);
            this.rbSizeSmall.Name = "rbSizeSmall";
            this.rbSizeSmall.Size = new System.Drawing.Size(108, 36);
            this.rbSizeSmall.TabIndex = 1;
            this.rbSizeSmall.TabStop = true;
            this.rbSizeSmall.Text = "Small";
            this.rbSizeSmall.UseVisualStyleBackColor = true;
            // 
            // Painter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 485);
            this.Controls.Add(this.tlpGroupBoxes);
            this.MinimumSize = new System.Drawing.Size(636, 532);
            this.Name = "Painter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painter";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Painter_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Painter_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Painter_MouseUp);
            this.tlpGroupBoxes.ResumeLayout(false);
            this.gbColors.ResumeLayout(false);
            this.gbColors.PerformLayout();
            this.gbSizes.ResumeLayout(false);
            this.gbSizes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGroupBoxes;
        private System.Windows.Forms.GroupBox gbColors;
        private System.Windows.Forms.GroupBox gbSizes;
        private System.Windows.Forms.RadioButton rbColorBlack;
        private System.Windows.Forms.RadioButton rbColorGreen;
        private System.Windows.Forms.RadioButton rbColorBlue;
        private System.Windows.Forms.RadioButton rbColorRed;
        private System.Windows.Forms.RadioButton rbColorLarge;
        private System.Windows.Forms.RadioButton rbColorMedium;
        private System.Windows.Forms.RadioButton rbSizeSmall;
    }
}