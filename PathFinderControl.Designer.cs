
namespace EasyRpgCommands
{
    partial class PathFinderControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PathFinderControl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonMoveRoute = new System.Windows.Forms.Button();
            this.buttonStepForward = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.eventidText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkDebug = new System.Windows.Forms.CheckBox();
            this.checkAllowDiag = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioFind = new System.Windows.Forms.RadioButton();
            this.radioWait = new System.Windows.Forms.RadioButton();
            this.radioSkip = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkSkip = new System.Windows.Forms.CheckBox();
            this.rmSelectVariableEx7 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx6 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx5 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx4 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx3 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx1 = new EasyRpgCommands.RmSelectVariableEx();
            this.rmSelectVariableEx2 = new EasyRpgCommands.RmSelectVariableEx();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Event ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Target X:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkSkip);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx7);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.eventidText);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkDebug);
            this.groupBox1.Controls.Add(this.checkAllowDiag);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx5);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx3);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rmSelectVariableEx2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 599);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path Finder (Requires EasyRPG Player)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonMoveRoute);
            this.groupBox2.Controls.Add(this.buttonStepForward);
            this.groupBox2.Location = new System.Drawing.Point(788, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 117);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Templates";
            // 
            // buttonMoveRoute
            // 
            this.buttonMoveRoute.Location = new System.Drawing.Point(6, 25);
            this.buttonMoveRoute.Name = "buttonMoveRoute";
            this.buttonMoveRoute.Size = new System.Drawing.Size(224, 34);
            this.buttonMoveRoute.TabIndex = 26;
            this.buttonMoveRoute.Text = "Move To Target";
            this.buttonMoveRoute.UseVisualStyleBackColor = true;
            this.buttonMoveRoute.Click += new System.EventHandler(this.buttonMoveRoute_Click);
            // 
            // buttonStepForward
            // 
            this.buttonStepForward.Location = new System.Drawing.Point(6, 65);
            this.buttonStepForward.Name = "buttonStepForward";
            this.buttonStepForward.Size = new System.Drawing.Size(224, 34);
            this.buttonStepForward.TabIndex = 27;
            this.buttonStepForward.Text = "One Step Forward";
            this.buttonStepForward.UseVisualStyleBackColor = true;
            this.buttonStepForward.Click += new System.EventHandler(this.buttonStepForward_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 512);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(280, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Comma seperated list of IDs to ignore:";
            // 
            // eventidText
            // 
            this.eventidText.Location = new System.Drawing.Point(9, 544);
            this.eventidText.Name = "eventidText";
            this.eventidText.Size = new System.Drawing.Size(1041, 26);
            this.eventidText.TabIndex = 24;
            this.eventidText.TextChanged += new System.EventHandler(this.eventidText_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(543, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(508, 40);
            this.label10.TabIndex = 23;
            this.label10.Text = "When set to \"Variable (or Ref)\" the value defines the start of an array\r\nThe firs" +
    "t item of the array is the \"length\", followed by \"length\" event IDs.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Event ignore list:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(544, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(471, 40);
            this.label8.TabIndex = 20;
            this.label8.Text = "After calculating the route, move up to \"steps\" tiles in the direction\r\n-1 = No l" +
    "imit\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(510, 60);
            this.label7.TabIndex = 19;
            this.label7.Text = "How long to do the pathfinding before giving up when no route is found.\r\nReducing" +
    " this number improves the performance but can fail to find\r\na route.";
            // 
            // checkDebug
            // 
            this.checkDebug.AutoSize = true;
            this.checkDebug.Location = new System.Drawing.Point(586, 257);
            this.checkDebug.Name = "checkDebug";
            this.checkDebug.Size = new System.Drawing.Size(287, 24);
            this.checkDebug.TabIndex = 18;
            this.checkDebug.Text = "Debug output to terminal and logfile";
            this.checkDebug.UseVisualStyleBackColor = true;
            // 
            // checkAllowDiag
            // 
            this.checkAllowDiag.AutoSize = true;
            this.checkAllowDiag.Location = new System.Drawing.Point(143, 258);
            this.checkAllowDiag.Name = "checkAllowDiag";
            this.checkAllowDiag.Size = new System.Drawing.Size(214, 24);
            this.checkAllowDiag.TabIndex = 17;
            this.checkAllowDiag.Text = "Allow diagonal movement";
            this.checkAllowDiag.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Flags:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Max Route Steps:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max Iterations:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Target Y:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioSkip);
            this.groupBox3.Controls.Add(this.radioWait);
            this.groupBox3.Controls.Add(this.radioFind);
            this.groupBox3.Location = new System.Drawing.Point(10, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 139);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pathfinding Flags";
            // 
            // radioFind
            // 
            this.radioFind.AutoSize = true;
            this.radioFind.Location = new System.Drawing.Point(7, 26);
            this.radioFind.Name = "radioFind";
            this.radioFind.Size = new System.Drawing.Size(197, 24);
            this.radioFind.TabIndex = 0;
            this.radioFind.TabStop = true;
            this.radioFind.Text = "Find path and continue";
            this.radioFind.UseVisualStyleBackColor = true;
            this.radioFind.CheckedChanged += new System.EventHandler(this.radioFind_CheckedChanged);
            // 
            // radioWait
            // 
            this.radioWait.AutoSize = true;
            this.radioWait.Location = new System.Drawing.Point(7, 57);
            this.radioWait.Name = "radioWait";
            this.radioWait.Size = new System.Drawing.Size(445, 24);
            this.radioWait.TabIndex = 1;
            this.radioWait.TabStop = true;
            this.radioWait.Text = "Wait, until event stops moving, then find path and continue";
            this.radioWait.UseVisualStyleBackColor = true;
            this.radioWait.CheckedChanged += new System.EventHandler(this.radioFind_CheckedChanged);
            // 
            // radioSkip
            // 
            this.radioSkip.AutoSize = true;
            this.radioSkip.Location = new System.Drawing.Point(7, 88);
            this.radioSkip.Name = "radioSkip";
            this.radioSkip.Size = new System.Drawing.Size(393, 24);
            this.radioSkip.TabIndex = 2;
            this.radioSkip.TabStop = true;
            this.radioSkip.Text = "Skip pathfinding when the event is currently moving";
            this.radioSkip.UseVisualStyleBackColor = true;
            this.radioSkip.CheckedChanged += new System.EventHandler(this.radioFind_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(475, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(524, 160);
            this.label12.TabIndex = 30;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 438);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Move Frequency:";
            // 
            // checkSkip
            // 
            this.checkSkip.AutoSize = true;
            this.checkSkip.Location = new System.Drawing.Point(364, 257);
            this.checkSkip.Name = "checkSkip";
            this.checkSkip.Size = new System.Drawing.Size(216, 24);
            this.checkSkip.TabIndex = 33;
            this.checkSkip.Text = "Skip steps if cannot move";
            this.checkSkip.UseVisualStyleBackColor = true;
            // 
            // rmSelectVariableEx7
            // 
            this.rmSelectVariableEx7.ItemWidth1 = 100;
            this.rmSelectVariableEx7.ItemWidth2 = 120;
            this.rmSelectVariableEx7.Location = new System.Drawing.Point(143, 433);
            this.rmSelectVariableEx7.Name = "rmSelectVariableEx7";
            this.rmSelectVariableEx7.NumericButtonClick = null;
            this.rmSelectVariableEx7.NumericValue = 0;
            this.rmSelectVariableEx7.SelectedType = cmdcs.RmSelectVariableEx.ValueType.NumericLiteral;
            this.rmSelectVariableEx7.SelectedTypeIndex = 0;
            this.rmSelectVariableEx7.Size = new System.Drawing.Size(398, 35);
            this.rmSelectVariableEx7.StringButtonClick = null;
            this.rmSelectVariableEx7.StringValue = "";
            this.rmSelectVariableEx7.TabIndex = 32;
            this.rmSelectVariableEx7.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx7.ValueRange")));
            this.rmSelectVariableEx7.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.NumericLiteral,
        cmdcs.RmSelectVariableEx.ValueType.Variable,
        cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            // 
            // rmSelectVariableEx6
            // 
            this.rmSelectVariableEx6.ItemWidth1 = 100;
            this.rmSelectVariableEx6.ItemWidth2 = 120;
            this.rmSelectVariableEx6.Location = new System.Drawing.Point(143, 474);
            this.rmSelectVariableEx6.Name = "rmSelectVariableEx6";
            this.rmSelectVariableEx6.NumericButtonClick = null;
            this.rmSelectVariableEx6.NumericValue = 0;
            this.rmSelectVariableEx6.SelectedType = cmdcs.RmSelectVariableEx.ValueType.NumericLiteral;
            this.rmSelectVariableEx6.SelectedTypeIndex = 0;
            this.rmSelectVariableEx6.Size = new System.Drawing.Size(398, 35);
            this.rmSelectVariableEx6.StringButtonClick = null;
            this.rmSelectVariableEx6.StringValue = "";
            this.rmSelectVariableEx6.TabIndex = 21;
            this.rmSelectVariableEx6.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx6.ValueRange")));
            this.rmSelectVariableEx6.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.NumericLiteral,
        cmdcs.RmSelectVariableEx.ValueType.Variable,
        cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            this.rmSelectVariableEx6.ValueTypeChanged += new cmdcs.RmSelectVariableEx.ValueTypeChangedEventHandler(this.rmSelectVariableEx6_ValueTypeChanged);
            // 
            // rmSelectVariableEx5
            // 
            this.rmSelectVariableEx5.ItemWidth1 = 100;
            this.rmSelectVariableEx5.ItemWidth2 = 120;
            this.rmSelectVariableEx5.Location = new System.Drawing.Point(143, 215);
            this.rmSelectVariableEx5.Name = "rmSelectVariableEx5";
            this.rmSelectVariableEx5.NumericButtonClick = null;
            this.rmSelectVariableEx5.NumericValue = 0;
            this.rmSelectVariableEx5.SelectedType = cmdcs.RmSelectVariableEx.ValueType.NumericLiteral;
            this.rmSelectVariableEx5.SelectedTypeIndex = 0;
            this.rmSelectVariableEx5.Size = new System.Drawing.Size(398, 35);
            this.rmSelectVariableEx5.StringButtonClick = null;
            this.rmSelectVariableEx5.StringValue = "";
            this.rmSelectVariableEx5.TabIndex = 9;
            this.rmSelectVariableEx5.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx5.ValueRange")));
            this.rmSelectVariableEx5.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.NumericLiteral,
        cmdcs.RmSelectVariableEx.ValueType.Variable,
        cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            // 
            // rmSelectVariableEx4
            // 
            this.rmSelectVariableEx4.ItemWidth1 = 100;
            this.rmSelectVariableEx4.ItemWidth2 = 120;
            this.rmSelectVariableEx4.Location = new System.Drawing.Point(143, 148);
            this.rmSelectVariableEx4.Name = "rmSelectVariableEx4";
            this.rmSelectVariableEx4.NumericButtonClick = null;
            this.rmSelectVariableEx4.NumericValue = 0;
            this.rmSelectVariableEx4.SelectedType = cmdcs.RmSelectVariableEx.ValueType.NumericLiteral;
            this.rmSelectVariableEx4.SelectedTypeIndex = 0;
            this.rmSelectVariableEx4.Size = new System.Drawing.Size(398, 35);
            this.rmSelectVariableEx4.StringButtonClick = null;
            this.rmSelectVariableEx4.StringValue = "";
            this.rmSelectVariableEx4.TabIndex = 8;
            this.rmSelectVariableEx4.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx4.ValueRange")));
            this.rmSelectVariableEx4.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.NumericLiteral,
        cmdcs.RmSelectVariableEx.ValueType.Variable,
        cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            // 
            // rmSelectVariableEx3
            // 
            this.rmSelectVariableEx3.ItemWidth1 = 100;
            this.rmSelectVariableEx3.ItemWidth2 = 120;
            this.rmSelectVariableEx3.Location = new System.Drawing.Point(143, 107);
            this.rmSelectVariableEx3.Name = "rmSelectVariableEx3";
            this.rmSelectVariableEx3.NumericButtonClick = null;
            this.rmSelectVariableEx3.NumericValue = 0;
            this.rmSelectVariableEx3.SelectedType = cmdcs.RmSelectVariableEx.ValueType.NumericLiteral;
            this.rmSelectVariableEx3.SelectedTypeIndex = 0;
            this.rmSelectVariableEx3.Size = new System.Drawing.Size(398, 35);
            this.rmSelectVariableEx3.StringButtonClick = null;
            this.rmSelectVariableEx3.StringValue = "";
            this.rmSelectVariableEx3.TabIndex = 6;
            this.rmSelectVariableEx3.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx3.ValueRange")));
            this.rmSelectVariableEx3.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.NumericLiteral,
        cmdcs.RmSelectVariableEx.ValueType.Variable,
        cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            // 
            // rmSelectVariableEx1
            // 
            this.rmSelectVariableEx1.ItemWidth1 = 100;
            this.rmSelectVariableEx1.ItemWidth2 = 120;
            this.rmSelectVariableEx1.Location = new System.Drawing.Point(143, 25);
            this.rmSelectVariableEx1.Name = "rmSelectVariableEx1";
            this.rmSelectVariableEx1.NumericButtonClick = null;
            this.rmSelectVariableEx1.NumericValue = 0;
            this.rmSelectVariableEx1.SelectedType = cmdcs.RmSelectVariableEx.ValueType.EventId;
            this.rmSelectVariableEx1.SelectedTypeIndex = 0;
            this.rmSelectVariableEx1.Size = new System.Drawing.Size(398, 35);
            this.rmSelectVariableEx1.StringButtonClick = null;
            this.rmSelectVariableEx1.StringValue = "";
            this.rmSelectVariableEx1.TabIndex = 2;
            this.rmSelectVariableEx1.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx1.ValueRange")));
            this.rmSelectVariableEx1.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.EventId,
        cmdcs.RmSelectVariableEx.ValueType.Variable,
        cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            // 
            // rmSelectVariableEx2
            // 
            this.rmSelectVariableEx2.ItemWidth1 = 100;
            this.rmSelectVariableEx2.ItemWidth2 = 120;
            this.rmSelectVariableEx2.Location = new System.Drawing.Point(143, 66);
            this.rmSelectVariableEx2.Name = "rmSelectVariableEx2";
            this.rmSelectVariableEx2.NumericButtonClick = null;
            this.rmSelectVariableEx2.NumericValue = 0;
            this.rmSelectVariableEx2.SelectedType = cmdcs.RmSelectVariableEx.ValueType.NumericLiteral;
            this.rmSelectVariableEx2.SelectedTypeIndex = 0;
            this.rmSelectVariableEx2.Size = new System.Drawing.Size(398, 35);
            this.rmSelectVariableEx2.StringButtonClick = null;
            this.rmSelectVariableEx2.StringValue = "";
            this.rmSelectVariableEx2.TabIndex = 3;
            this.rmSelectVariableEx2.ValueRange = ((System.ValueTuple<int, int>)(resources.GetObject("rmSelectVariableEx2.ValueRange")));
            this.rmSelectVariableEx2.ValueTypeArray = new cmdcs.RmSelectVariableEx.ValueType[] {
        cmdcs.RmSelectVariableEx.ValueType.NumericLiteral,
        cmdcs.RmSelectVariableEx.ValueType.Variable,
        cmdcs.RmSelectVariableEx.ValueType.VariableRef};
            // 
            // PathFinderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "PathFinderControl";
            this.Size = new System.Drawing.Size(1085, 605);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RmSelectVariableEx rmSelectVariableEx1;
        private RmSelectVariableEx rmSelectVariableEx2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private RmSelectVariableEx rmSelectVariableEx3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private RmSelectVariableEx rmSelectVariableEx5;
        private RmSelectVariableEx rmSelectVariableEx4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox eventidText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private RmSelectVariableEx rmSelectVariableEx6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkDebug;
        private System.Windows.Forms.CheckBox checkAllowDiag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonMoveRoute;
        private System.Windows.Forms.Button buttonStepForward;
        private RmSelectVariableEx rmSelectVariableEx7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioSkip;
        private System.Windows.Forms.RadioButton radioWait;
        private System.Windows.Forms.RadioButton radioFind;
        private System.Windows.Forms.CheckBox checkSkip;
    }
}
