namespace ElementaryCellularAutomaton
{
    partial class Form_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label_Range = new System.Windows.Forms.Label();
            this.button_StartStop = new System.Windows.Forms.Button();
            this.textBox_Rule = new System.Windows.Forms.TextBox();
            this.label_Rule = new System.Windows.Forms.Label();
            this.dataGridView_Space = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Space)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label_Range);
            this.splitContainer1.Panel1.Controls.Add(this.button_StartStop);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_Rule);
            this.splitContainer1.Panel1.Controls.Add(this.label_Rule);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_Space);
            this.splitContainer1.Size = new System.Drawing.Size(784, 441);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 0;
            // 
            // label_Range
            // 
            this.label_Range.AutoSize = true;
            this.label_Range.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Range.ForeColor = System.Drawing.Color.Red;
            this.label_Range.Location = new System.Drawing.Point(111, 113);
            this.label_Range.Name = "label_Range";
            this.label_Range.Size = new System.Drawing.Size(64, 13);
            this.label_Range.TabIndex = 3;
            this.label_Range.Text = "от 0 до 255";
            // 
            // button_StartStop
            // 
            this.button_StartStop.AutoSize = true;
            this.button_StartStop.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_StartStop.Location = new System.Drawing.Point(32, 216);
            this.button_StartStop.Name = "button_StartStop";
            this.button_StartStop.Size = new System.Drawing.Size(132, 33);
            this.button_StartStop.TabIndex = 2;
            this.button_StartStop.Text = "Старт / Стоп";
            this.button_StartStop.UseVisualStyleBackColor = true;
            this.button_StartStop.Click += new System.EventHandler(this.button_StartStop_Click);
            // 
            // textBox_Rule
            // 
            this.textBox_Rule.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Rule.Location = new System.Drawing.Point(92, 129);
            this.textBox_Rule.Name = "textBox_Rule";
            this.textBox_Rule.Size = new System.Drawing.Size(100, 29);
            this.textBox_Rule.TabIndex = 1;
            this.textBox_Rule.Text = "110";
            // 
            // label_Rule
            // 
            this.label_Rule.AutoSize = true;
            this.label_Rule.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Rule.Location = new System.Drawing.Point(9, 132);
            this.label_Rule.Name = "label_Rule";
            this.label_Rule.Size = new System.Drawing.Size(79, 21);
            this.label_Rule.TabIndex = 0;
            this.label_Rule.Text = "Правило";
            // 
            // dataGridView_Space
            // 
            this.dataGridView_Space.AllowUserToAddRows = false;
            this.dataGridView_Space.AllowUserToDeleteRows = false;
            this.dataGridView_Space.AllowUserToResizeColumns = false;
            this.dataGridView_Space.AllowUserToResizeRows = false;
            this.dataGridView_Space.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Space.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Space.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Space.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Space.GridColor = System.Drawing.Color.Black;
            this.dataGridView_Space.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Space.MultiSelect = false;
            this.dataGridView_Space.Name = "dataGridView_Space";
            this.dataGridView_Space.ReadOnly = true;
            this.dataGridView_Space.RowHeadersVisible = false;
            this.dataGridView_Space.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Space.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_Space.Size = new System.Drawing.Size(584, 441);
            this.dataGridView_Space.TabIndex = 0;
            this.dataGridView_Space.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_main";
            this.Text = "Form_main";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Space)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView_Space;
        private System.Windows.Forms.Button button_StartStop;
        private System.Windows.Forms.TextBox textBox_Rule;
        private System.Windows.Forms.Label label_Rule;
        private System.Windows.Forms.Label label_Range;
        private System.Windows.Forms.Timer timer;
    }
}

