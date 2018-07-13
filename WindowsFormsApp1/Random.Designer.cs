namespace WindowsFormsApp1
{
    partial class frmRandom
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbSetting = new System.Windows.Forms.GroupBox();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveSetting = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnResetDefault = new System.Windows.Forms.Button();
            this.grbShow = new System.Windows.Forms.GroupBox();
            this.rdbShow3 = new System.Windows.Forms.RadioButton();
            this.rdbShow = new System.Windows.Forms.RadioButton();
            this.rdbShow2 = new System.Windows.Forms.RadioButton();
            this.lblWaitingForResult = new System.Windows.Forms.Label();
            this.txtWaitingForResult = new System.Windows.Forms.TextBox();
            this.txtExpressionNum = new System.Windows.Forms.TextBox();
            this.txtWaitingTime = new System.Windows.Forms.TextBox();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.txtMinValue = new System.Windows.Forms.TextBox();
            this.txtRandomTimes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvUserResult = new System.Windows.Forms.ListView();
            this.grbAction = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.chkShowCurrentExpression = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblCurrentExpression = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grbUserResult = new System.Windows.Forms.GroupBox();
            this.txtRanDomLabel = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.btNextExpression = new System.Windows.Forms.Button();
            this.grbSetting.SuspendLayout();
            this.grbShow.SuspendLayout();
            this.grbAction.SuspendLayout();
            this.grbUserResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Random Times:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Min Value:";
            // 
            // grbSetting
            // 
            this.grbSetting.Controls.Add(this.cboOperator);
            this.grbSetting.Controls.Add(this.label6);
            this.grbSetting.Controls.Add(this.btnSaveSetting);
            this.grbSetting.Controls.Add(this.btnClear);
            this.grbSetting.Controls.Add(this.btnResetDefault);
            this.grbSetting.Controls.Add(this.grbShow);
            this.grbSetting.Controls.Add(this.txtExpressionNum);
            this.grbSetting.Controls.Add(this.txtWaitingTime);
            this.grbSetting.Controls.Add(this.txtMaxValue);
            this.grbSetting.Controls.Add(this.txtMinValue);
            this.grbSetting.Controls.Add(this.txtRandomTimes);
            this.grbSetting.Controls.Add(this.label1);
            this.grbSetting.Controls.Add(this.label5);
            this.grbSetting.Controls.Add(this.label4);
            this.grbSetting.Controls.Add(this.label3);
            this.grbSetting.Controls.Add(this.label2);
            this.grbSetting.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbSetting.Location = new System.Drawing.Point(2, 1);
            this.grbSetting.Name = "grbSetting";
            this.grbSetting.Size = new System.Drawing.Size(333, 318);
            this.grbSetting.TabIndex = 2;
            this.grbSetting.TabStop = false;
            this.grbSetting.Text = "Settings";
            // 
            // cboOperator
            // 
            this.cboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "+-"});
            this.cboOperator.Location = new System.Drawing.Point(199, 156);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(128, 21);
            this.cboOperator.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(4, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Operator";
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.Location = new System.Drawing.Point(231, 274);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(83, 23);
            this.btnSaveSetting.TabIndex = 4;
            this.btnSaveSetting.Text = "Save Setting";
            this.btnSaveSetting.UseVisualStyleBackColor = true;
            this.btnSaveSetting.Click += new System.EventHandler(this.btnSaveSetting_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(43, 274);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnResetDefault
            // 
            this.btnResetDefault.Location = new System.Drawing.Point(130, 274);
            this.btnResetDefault.Name = "btnResetDefault";
            this.btnResetDefault.Size = new System.Drawing.Size(95, 23);
            this.btnResetDefault.TabIndex = 4;
            this.btnResetDefault.Text = "ResetDefault";
            this.btnResetDefault.UseVisualStyleBackColor = true;
            this.btnResetDefault.Click += new System.EventHandler(this.btnResetDefault_Click);
            // 
            // grbShow
            // 
            this.grbShow.Controls.Add(this.rdbShow3);
            this.grbShow.Controls.Add(this.rdbShow);
            this.grbShow.Controls.Add(this.rdbShow2);
            this.grbShow.Controls.Add(this.lblWaitingForResult);
            this.grbShow.Controls.Add(this.txtWaitingForResult);
            this.grbShow.Location = new System.Drawing.Point(1, 180);
            this.grbShow.Name = "grbShow";
            this.grbShow.Size = new System.Drawing.Size(327, 88);
            this.grbShow.TabIndex = 6;
            this.grbShow.TabStop = false;
            this.grbShow.Text = "Show result setting";
            // 
            // rdbShow3
            // 
            this.rdbShow3.AutoSize = true;
            this.rdbShow3.Location = new System.Drawing.Point(8, 65);
            this.rdbShow3.Name = "rdbShow3";
            this.rdbShow3.Size = new System.Drawing.Size(115, 17);
            this.rdbShow3.TabIndex = 5;
            this.rdbShow3.Text = "Manual Input result";
            this.rdbShow3.UseVisualStyleBackColor = true;
            this.rdbShow3.CheckedChanged += new System.EventHandler(this.rdbShow3_CheckedChanged);
            // 
            // rdbShow
            // 
            this.rdbShow.AutoSize = true;
            this.rdbShow.Checked = true;
            this.rdbShow.Location = new System.Drawing.Point(6, 19);
            this.rdbShow.Name = "rdbShow";
            this.rdbShow.Size = new System.Drawing.Size(166, 17);
            this.rdbShow.TabIndex = 5;
            this.rdbShow.TabStop = true;
            this.rdbShow.Text = "Show result after Double click";
            this.rdbShow.UseVisualStyleBackColor = true;
            this.rdbShow.CheckedChanged += new System.EventHandler(this.rdbShow_CheckedChanged);
            // 
            // rdbShow2
            // 
            this.rdbShow2.AutoSize = true;
            this.rdbShow2.Location = new System.Drawing.Point(8, 42);
            this.rdbShow2.Name = "rdbShow2";
            this.rdbShow2.Size = new System.Drawing.Size(103, 17);
            this.rdbShow2.TabIndex = 5;
            this.rdbShow2.Text = "Auto show result";
            this.rdbShow2.UseVisualStyleBackColor = true;
            this.rdbShow2.CheckedChanged += new System.EventHandler(this.rdbShow2_CheckedChanged);
            // 
            // lblWaitingForResult
            // 
            this.lblWaitingForResult.AutoSize = true;
            this.lblWaitingForResult.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWaitingForResult.Location = new System.Drawing.Point(110, 45);
            this.lblWaitingForResult.Name = "lblWaitingForResult";
            this.lblWaitingForResult.Size = new System.Drawing.Size(114, 13);
            this.lblWaitingForResult.TabIndex = 1;
            this.lblWaitingForResult.Text = "After this milisecond(s):";
            this.lblWaitingForResult.Visible = false;
            // 
            // txtWaitingForResult
            // 
            this.txtWaitingForResult.Location = new System.Drawing.Point(226, 42);
            this.txtWaitingForResult.Name = "txtWaitingForResult";
            this.txtWaitingForResult.Size = new System.Drawing.Size(95, 20);
            this.txtWaitingForResult.TabIndex = 4;
            this.txtWaitingForResult.Visible = false;
            this.txtWaitingForResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWaitingForResult_KeyPress);
            // 
            // txtExpressionNum
            // 
            this.txtExpressionNum.Location = new System.Drawing.Point(199, 129);
            this.txtExpressionNum.Name = "txtExpressionNum";
            this.txtExpressionNum.Size = new System.Drawing.Size(129, 20);
            this.txtExpressionNum.TabIndex = 4;
            this.txtExpressionNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWaitingTime_KeyPress);
            // 
            // txtWaitingTime
            // 
            this.txtWaitingTime.Location = new System.Drawing.Point(200, 101);
            this.txtWaitingTime.Name = "txtWaitingTime";
            this.txtWaitingTime.Size = new System.Drawing.Size(128, 20);
            this.txtWaitingTime.TabIndex = 4;
            this.txtWaitingTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWaitingTime_KeyPress);
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(200, 71);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(128, 20);
            this.txtMaxValue.TabIndex = 4;
            this.txtMaxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMaxValue_KeyPress);
            // 
            // txtMinValue
            // 
            this.txtMinValue.Location = new System.Drawing.Point(200, 44);
            this.txtMinValue.Name = "txtMinValue";
            this.txtMinValue.Size = new System.Drawing.Size(128, 20);
            this.txtMinValue.TabIndex = 4;
            this.txtMinValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinValue_KeyPress);
            // 
            // txtRandomTimes
            // 
            this.txtRandomTimes.Location = new System.Drawing.Point(200, 13);
            this.txtRandomTimes.Name = "txtRandomTimes";
            this.txtRandomTimes.Size = new System.Drawing.Size(128, 20);
            this.txtRandomTimes.TabIndex = 4;
            this.txtRandomTimes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRandomTimes_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(3, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Number Of Expression:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(4, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Time to show random result (milisecond):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Max Value:";
            // 
            // lvUserResult
            // 
            this.lvUserResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvUserResult.Location = new System.Drawing.Point(5, 19);
            this.lvUserResult.Name = "lvUserResult";
            this.lvUserResult.Size = new System.Drawing.Size(321, 358);
            this.lvUserResult.TabIndex = 3;
            this.lvUserResult.UseCompatibleStateImageBehavior = false;
            // 
            // grbAction
            // 
            this.grbAction.Controls.Add(this.btnStop);
            this.grbAction.Controls.Add(this.chkShowCurrentExpression);
            this.grbAction.Controls.Add(this.btnStart);
            this.grbAction.Controls.Add(this.lblCurrentExpression);
            this.grbAction.Location = new System.Drawing.Point(338, 1);
            this.grbAction.Name = "grbAction";
            this.grbAction.Size = new System.Drawing.Size(930, 87);
            this.grbAction.TabIndex = 4;
            this.grbAction.TabStop = false;
            this.grbAction.Text = "Action";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(164, 24);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(105, 33);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // chkShowCurrentExpression
            // 
            this.chkShowCurrentExpression.AutoSize = true;
            this.chkShowCurrentExpression.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkShowCurrentExpression.Location = new System.Drawing.Point(26, 63);
            this.chkShowCurrentExpression.Name = "chkShowCurrentExpression";
            this.chkShowCurrentExpression.Size = new System.Drawing.Size(147, 17);
            this.chkShowCurrentExpression.TabIndex = 5;
            this.chkShowCurrentExpression.Text = "Show Current Expression:";
            this.chkShowCurrentExpression.UseVisualStyleBackColor = true;
            this.chkShowCurrentExpression.CheckedChanged += new System.EventHandler(this.chkShowCurrentExpression_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(26, 24);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 33);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblCurrentExpression
            // 
            this.lblCurrentExpression.AutoSize = true;
            this.lblCurrentExpression.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrentExpression.Location = new System.Drawing.Point(171, 64);
            this.lblCurrentExpression.Name = "lblCurrentExpression";
            this.lblCurrentExpression.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentExpression.TabIndex = 1;
            this.lblCurrentExpression.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grbUserResult
            // 
            this.grbUserResult.Controls.Add(this.lvUserResult);
            this.grbUserResult.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbUserResult.Location = new System.Drawing.Point(3, 325);
            this.grbUserResult.Name = "grbUserResult";
            this.grbUserResult.Size = new System.Drawing.Size(332, 383);
            this.grbUserResult.TabIndex = 7;
            this.grbUserResult.TabStop = false;
            this.grbUserResult.Text = "User Result";
            // 
            // txtRanDomLabel
            // 
            this.txtRanDomLabel.AutoSize = true;
            this.txtRanDomLabel.Font = new System.Drawing.Font("Arial", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRanDomLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtRanDomLabel.Location = new System.Drawing.Point(341, 91);
            this.txtRanDomLabel.Name = "txtRanDomLabel";
            this.txtRanDomLabel.Size = new System.Drawing.Size(896, 299);
            this.txtRanDomLabel.TabIndex = 8;
            this.txtRanDomLabel.Text = "Ready";
            this.txtRanDomLabel.Visible = false;
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btNext.Enabled = false;
            this.btNext.FlatAppearance.BorderSize = 0;
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.ForeColor = System.Drawing.Color.White;
            this.btNext.Location = new System.Drawing.Point(603, 646);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(181, 56);
            this.btNext.TabIndex = 9;
            this.btNext.Text = "Hiển thị kết quả";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btNextExpression
            // 
            this.btNextExpression.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btNextExpression.Enabled = false;
            this.btNextExpression.FlatAppearance.BorderSize = 0;
            this.btNextExpression.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNextExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNextExpression.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btNextExpression.Location = new System.Drawing.Point(812, 646);
            this.btNextExpression.Name = "btNextExpression";
            this.btNextExpression.Size = new System.Drawing.Size(202, 56);
            this.btNextExpression.TabIndex = 10;
            this.btNextExpression.Text = "Phép tính tiếp theo";
            this.btNextExpression.UseVisualStyleBackColor = false;
            this.btNextExpression.Click += new System.EventHandler(this.btNextExpression_Click);
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btNextExpression);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.txtRanDomLabel);
            this.Controls.Add(this.grbUserResult);
            this.Controls.Add(this.grbAction);
            this.Controls.Add(this.grbSetting);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmRandom";
            this.Text = "Random";
            this.DoubleClick += new System.EventHandler(this.frmRandom_DoubleClick);
            this.grbSetting.ResumeLayout(false);
            this.grbSetting.PerformLayout();
            this.grbShow.ResumeLayout(false);
            this.grbShow.PerformLayout();
            this.grbAction.ResumeLayout(false);
            this.grbAction.PerformLayout();
            this.grbUserResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbSetting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWaitingTime;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.TextBox txtMinValue;
        private System.Windows.Forms.TextBox txtRandomTimes;
        private System.Windows.Forms.Label lblWaitingForResult;
        private System.Windows.Forms.TextBox txtWaitingForResult;
        private System.Windows.Forms.GroupBox grbShow;
        private System.Windows.Forms.RadioButton rdbShow3;
        private System.Windows.Forms.RadioButton rdbShow;
        private System.Windows.Forms.RadioButton rdbShow2;
        private System.Windows.Forms.ListView lvUserResult;
        private System.Windows.Forms.Button btnSaveSetting;
        private System.Windows.Forms.Button btnResetDefault;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtExpressionNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbAction;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblCurrentExpression;
        private System.Windows.Forms.CheckBox chkShowCurrentExpression;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grbUserResult;
        private System.Windows.Forms.Label txtRanDomLabel;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btNextExpression;
    }
}

