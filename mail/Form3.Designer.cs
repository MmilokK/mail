namespace mail
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.Messages = new System.Windows.Forms.DataGridView();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.DayRadioButton = new System.Windows.Forms.RadioButton();
            this.WeekRadioButton = new System.Windows.Forms.RadioButton();
            this.YearRadioButton = new System.Windows.Forms.RadioButton();
            this.AllTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Messages)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1186, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "получить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Messages
            // 
            this.Messages.AllowUserToAddRows = false;
            this.Messages.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Messages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Messages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Messages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Messages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Messages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Messages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Messages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.from,
            this.data,
            this.subject,
            this.message});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Messages.DefaultCellStyle = dataGridViewCellStyle3;
            this.Messages.Location = new System.Drawing.Point(12, 12);
            this.Messages.Name = "Messages";
            this.Messages.ReadOnly = true;
            this.Messages.RowTemplate.Height = 25;
            this.Messages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Messages.Size = new System.Drawing.Size(1093, 307);
            this.Messages.TabIndex = 12;
            this.Messages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Messages_CellMouseClick);
            // 
            // from
            // 
            this.from.HeaderText = "от кого";
            this.from.Name = "from";
            this.from.ReadOnly = true;
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.data.FillWeight = 60F;
            this.data.HeaderText = "дата";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 210;
            // 
            // subject
            // 
            this.subject.HeaderText = "тема";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            // 
            // message
            // 
            this.message.HeaderText = "сообщение";
            this.message.Name = "message";
            this.message.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1082, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DayRadioButton
            // 
            this.DayRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DayRadioButton.AutoSize = true;
            this.DayRadioButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DayRadioButton.Location = new System.Drawing.Point(1112, 34);
            this.DayRadioButton.Name = "DayRadioButton";
            this.DayRadioButton.Size = new System.Drawing.Size(66, 22);
            this.DayRadioButton.TabIndex = 14;
            this.DayRadioButton.Text = "день";
            this.DayRadioButton.UseVisualStyleBackColor = true;
            this.DayRadioButton.CheckedChanged += new System.EventHandler(this.DayRadioButton_CheckedChanged);
            // 
            // WeekRadioButton
            // 
            this.WeekRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekRadioButton.AutoSize = true;
            this.WeekRadioButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WeekRadioButton.Location = new System.Drawing.Point(1112, 59);
            this.WeekRadioButton.Name = "WeekRadioButton";
            this.WeekRadioButton.Size = new System.Drawing.Size(85, 22);
            this.WeekRadioButton.TabIndex = 15;
            this.WeekRadioButton.Text = "неделя";
            this.WeekRadioButton.UseVisualStyleBackColor = true;
            this.WeekRadioButton.CheckedChanged += new System.EventHandler(this.WeekRadioButton_CheckedChanged);
            // 
            // YearRadioButton
            // 
            this.YearRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YearRadioButton.AutoSize = true;
            this.YearRadioButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YearRadioButton.Location = new System.Drawing.Point(1112, 84);
            this.YearRadioButton.Name = "YearRadioButton";
            this.YearRadioButton.Size = new System.Drawing.Size(55, 22);
            this.YearRadioButton.TabIndex = 16;
            this.YearRadioButton.Text = "год";
            this.YearRadioButton.UseVisualStyleBackColor = true;
            this.YearRadioButton.CheckedChanged += new System.EventHandler(this.YearRadioButton_CheckedChanged);
            // 
            // AllTimeRadioButton
            // 
            this.AllTimeRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AllTimeRadioButton.AutoSize = true;
            this.AllTimeRadioButton.Checked = true;
            this.AllTimeRadioButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AllTimeRadioButton.Location = new System.Drawing.Point(1112, 109);
            this.AllTimeRadioButton.Name = "AllTimeRadioButton";
            this.AllTimeRadioButton.Size = new System.Drawing.Size(111, 22);
            this.AllTimeRadioButton.TabIndex = 17;
            this.AllTimeRadioButton.TabStop = true;
            this.AllTimeRadioButton.Text = "все время";
            this.AllTimeRadioButton.UseVisualStyleBackColor = true;
            this.AllTimeRadioButton.CheckedChanged += new System.EventHandler(this.AllTimeRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1111, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Сортировка по дате";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllTimeRadioButton);
            this.Controls.Add(this.YearRadioButton);
            this.Controls.Add(this.WeekRadioButton);
            this.Controls.Add(this.DayRadioButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Получение";
            ((System.ComponentModel.ISupportInitialize)(this.Messages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private DataGridView Messages;
        private Button button2;
        private RadioButton DayRadioButton;
        private RadioButton WeekRadioButton;
        private RadioButton YearRadioButton;
        private RadioButton AllTimeRadioButton;
        private Label label1;
        private DataGridViewTextBoxColumn from;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn message;
    }
}