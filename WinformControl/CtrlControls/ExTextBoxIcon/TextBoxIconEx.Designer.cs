﻿namespace CtrlControls.ExTextBoxIcon
{
    partial class TextBoxIconEx
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BaseText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BaseText
            // 
            this.BaseText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BaseText.Font = new System.Drawing.Font("宋体", 12F);
            this.BaseText.Location = new System.Drawing.Point(0, 6);
            this.BaseText.Name = "BaseText";
            this.BaseText.Size = new System.Drawing.Size(98, 19);
            this.BaseText.TabIndex = 0;
            this.BaseText.MouseLeave += new System.EventHandler(this.BaseText_MouseLeave);
            this.BaseText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseText_MouseMove);
            // 
            // TextBoxIconEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BaseText);
            this.Name = "TextBoxIconEx";
            this.Size = new System.Drawing.Size(100, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BaseText;
    }
}
