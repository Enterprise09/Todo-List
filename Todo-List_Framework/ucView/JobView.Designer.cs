﻿
namespace Todo_List_Framework.ucView
{
    partial class JobView
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_from = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_request = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_state_img = new System.Windows.Forms.Label();
            this.lbl_del_button = new System.Windows.Forms.Label();
            this.lbl_endLine = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_from.Font = new System.Drawing.Font("MesloLGS NF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_from.Location = new System.Drawing.Point(77, 28);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(129, 39);
            this.lbl_from.TabIndex = 3;
            this.lbl_from.Text = "From";
            this.lbl_from.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("MesloLGS NF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(4, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stat";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("MesloLGS NF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "End";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_request
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_request, 2);
            this.lbl_request.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_request.Font = new System.Drawing.Font("MesloLGS NF", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_request.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_request.Location = new System.Drawing.Point(4, 148);
            this.lbl_request.Name = "lbl_request";
            this.lbl_request.Size = new System.Drawing.Size(202, 151);
            this.lbl_request.TabIndex = 2;
            this.lbl_request.Text = "Request";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("MesloLGS NF", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_request, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_from, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_state_img, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_del_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_endLine, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.27885F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.27885F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.27885F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.07254F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 300);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_state_img
            // 
            this.lbl_state_img.AutoSize = true;
            this.lbl_state_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_state_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_state_img.Font = new System.Drawing.Font("MesloLGS NF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_state_img.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_state_img.Image = global::Todo_List_Framework.Properties.Resources.complete;
            this.lbl_state_img.Location = new System.Drawing.Point(77, 108);
            this.lbl_state_img.Name = "lbl_state_img";
            this.lbl_state_img.Size = new System.Drawing.Size(129, 39);
            this.lbl_state_img.TabIndex = 3;
            this.lbl_state_img.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_state_img.Click += new System.EventHandler(this.lbl_state_img_Click);
            // 
            // lbl_del_button
            // 
            this.lbl_del_button.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_del_button, 2);
            this.lbl_del_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_del_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_del_button.Image = global::Todo_List_Framework.Properties.Resources.yellow_del_button1;
            this.lbl_del_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_del_button.Location = new System.Drawing.Point(4, 1);
            this.lbl_del_button.Name = "lbl_del_button";
            this.lbl_del_button.Size = new System.Drawing.Size(202, 26);
            this.lbl_del_button.TabIndex = 4;
            this.lbl_del_button.Click += new System.EventHandler(this.lbl_del_button_Click);
            // 
            // lbl_endLine
            // 
            this.lbl_endLine.AutoSize = true;
            this.lbl_endLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_endLine.Font = new System.Drawing.Font("MesloLGS NF", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_endLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_endLine.Location = new System.Drawing.Point(77, 68);
            this.lbl_endLine.Name = "lbl_endLine";
            this.lbl_endLine.Size = new System.Drawing.Size(129, 39);
            this.lbl_endLine.TabIndex = 3;
            this.lbl_endLine.Text = "End To";
            this.lbl_endLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JobView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(254)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JobView";
            this.Size = new System.Drawing.Size(210, 300);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lbl_state_img;
        internal System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lbl_request;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_del_button;
        internal System.Windows.Forms.Label lbl_endLine;
    }
}
