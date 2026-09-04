namespace Silk_Client
{
    partial class Silk
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
            TitlePanel = new Panel();
            TitleMirror = new Label();
            MinimizeButton = new Button();
            CloseButton = new Button();
            ApplicationLabel = new Label();
            ApplicationTextbox = new TextBox();
            DetailsTextbox = new TextBox();
            DetailsLabel = new Label();
            StateTextbox = new TextBox();
            StateLabel = new Label();
            ActivityComboBox = new ComboBox();
            ActivityTypeLabel = new Label();
            ElapsedTimeLabel = new Label();
            ElapsedCheckbox = new CheckBox();
            Image1Label = new Label();
            LargeTextbox = new TextBox();
            SmallTextbox = new TextBox();
            Image2Label = new Label();
            Image1Text = new Label();
            LargeTextTextbox = new TextBox();
            SmallTextTextbox = new TextBox();
            Image2Text = new Label();
            ApplyDiscordRPC = new Button();
            SaveSettingButton = new Button();
            LoadConfigButton = new Button();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = Color.FromArgb(33, 33, 33);
            TitlePanel.Controls.Add(TitleMirror);
            TitlePanel.Controls.Add(MinimizeButton);
            TitlePanel.Controls.Add(CloseButton);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(804, 40);
            TitlePanel.TabIndex = 0;
            // 
            // TitleMirror
            // 
            TitleMirror.AutoSize = true;
            TitleMirror.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleMirror.ForeColor = Color.FromArgb(165, 20, 180);
            TitleMirror.Location = new Point(11, 11);
            TitleMirror.Name = "TitleMirror";
            TitleMirror.Size = new Size(89, 18);
            TitleMirror.TabIndex = 14;
            TitleMirror.Text = "SILKCORD";
            // 
            // MinimizeButton
            // 
            MinimizeButton.BackColor = Color.FromArgb(33, 33, 33);
            MinimizeButton.FlatAppearance.BorderSize = 0;
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MinimizeButton.ForeColor = Color.FromArgb(165, 20, 180);
            MinimizeButton.Location = new Point(727, 0);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(40, 40);
            MinimizeButton.TabIndex = 13;
            MinimizeButton.Text = "-";
            MinimizeButton.UseVisualStyleBackColor = false;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(33, 33, 33);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.ForeColor = Color.FromArgb(165, 20, 180);
            CloseButton.Location = new Point(764, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(40, 40);
            CloseButton.TabIndex = 12;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // ApplicationLabel
            // 
            ApplicationLabel.AutoSize = true;
            ApplicationLabel.BackColor = Color.Transparent;
            ApplicationLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApplicationLabel.ForeColor = Color.FromArgb(165, 20, 180);
            ApplicationLabel.Location = new Point(12, 60);
            ApplicationLabel.Name = "ApplicationLabel";
            ApplicationLabel.Size = new Size(156, 30);
            ApplicationLabel.TabIndex = 1;
            ApplicationLabel.Text = "Application ID: ";
            // 
            // ApplicationTextbox
            // 
            ApplicationTextbox.Location = new Point(174, 67);
            ApplicationTextbox.Name = "ApplicationTextbox";
            ApplicationTextbox.Size = new Size(555, 23);
            ApplicationTextbox.TabIndex = 2;
            // 
            // DetailsTextbox
            // 
            DetailsTextbox.Location = new Point(174, 129);
            DetailsTextbox.Name = "DetailsTextbox";
            DetailsTextbox.Size = new Size(555, 23);
            DetailsTextbox.TabIndex = 4;
            // 
            // DetailsLabel
            // 
            DetailsLabel.AutoSize = true;
            DetailsLabel.BackColor = Color.Transparent;
            DetailsLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DetailsLabel.ForeColor = Color.FromArgb(165, 20, 180);
            DetailsLabel.Location = new Point(81, 122);
            DetailsLabel.Name = "DetailsLabel";
            DetailsLabel.Size = new Size(87, 30);
            DetailsLabel.TabIndex = 3;
            DetailsLabel.Text = "Details: ";
            // 
            // StateTextbox
            // 
            StateTextbox.Location = new Point(174, 194);
            StateTextbox.Name = "StateTextbox";
            StateTextbox.Size = new Size(555, 23);
            StateTextbox.TabIndex = 6;
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.BackColor = Color.Transparent;
            StateLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StateLabel.ForeColor = Color.FromArgb(165, 20, 180);
            StateLabel.Location = new Point(98, 185);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(70, 30);
            StateLabel.TabIndex = 5;
            StateLabel.Text = "State: ";
            // 
            // ActivityComboBox
            // 
            ActivityComboBox.FormattingEnabled = true;
            ActivityComboBox.Items.AddRange(new object[] { "Playing", "Watching", "Listening" });
            ActivityComboBox.Location = new Point(548, 255);
            ActivityComboBox.Name = "ActivityComboBox";
            ActivityComboBox.Size = new Size(181, 23);
            ActivityComboBox.TabIndex = 7;
            // 
            // ActivityTypeLabel
            // 
            ActivityTypeLabel.AutoSize = true;
            ActivityTypeLabel.BackColor = Color.Transparent;
            ActivityTypeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActivityTypeLabel.ForeColor = Color.FromArgb(165, 20, 180);
            ActivityTypeLabel.Location = new Point(401, 248);
            ActivityTypeLabel.Name = "ActivityTypeLabel";
            ActivityTypeLabel.Size = new Size(141, 30);
            ActivityTypeLabel.TabIndex = 8;
            ActivityTypeLabel.Text = "Activity Type: ";
            // 
            // ElapsedTimeLabel
            // 
            ElapsedTimeLabel.AutoSize = true;
            ElapsedTimeLabel.BackColor = Color.Transparent;
            ElapsedTimeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ElapsedTimeLabel.ForeColor = Color.FromArgb(165, 20, 180);
            ElapsedTimeLabel.Location = new Point(98, 248);
            ElapsedTimeLabel.Name = "ElapsedTimeLabel";
            ElapsedTimeLabel.Size = new Size(191, 30);
            ElapsedTimeLabel.TabIndex = 9;
            ElapsedTimeLabel.Text = "Show Elapsed Time";
            // 
            // ElapsedCheckbox
            // 
            ElapsedCheckbox.AutoSize = true;
            ElapsedCheckbox.Checked = true;
            ElapsedCheckbox.CheckState = CheckState.Checked;
            ElapsedCheckbox.Location = new Point(295, 259);
            ElapsedCheckbox.Name = "ElapsedCheckbox";
            ElapsedCheckbox.Size = new Size(15, 14);
            ElapsedCheckbox.TabIndex = 10;
            ElapsedCheckbox.UseVisualStyleBackColor = true;
            // 
            // Image1Label
            // 
            Image1Label.AutoSize = true;
            Image1Label.BackColor = Color.Transparent;
            Image1Label.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Image1Label.ForeColor = Color.FromArgb(165, 20, 180);
            Image1Label.Location = new Point(12, 323);
            Image1Label.Name = "Image1Label";
            Image1Label.Size = new Size(172, 30);
            Image1Label.TabIndex = 11;
            Image1Label.Text = "Large Image Key:";
            // 
            // LargeTextbox
            // 
            LargeTextbox.Location = new Point(190, 330);
            LargeTextbox.Name = "LargeTextbox";
            LargeTextbox.Size = new Size(205, 23);
            LargeTextbox.TabIndex = 12;
            // 
            // SmallTextbox
            // 
            SmallTextbox.Location = new Point(584, 332);
            SmallTextbox.Name = "SmallTextbox";
            SmallTextbox.Size = new Size(205, 23);
            SmallTextbox.TabIndex = 14;
            // 
            // Image2Label
            // 
            Image2Label.AutoSize = true;
            Image2Label.BackColor = Color.Transparent;
            Image2Label.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Image2Label.ForeColor = Color.FromArgb(165, 20, 180);
            Image2Label.Location = new Point(406, 325);
            Image2Label.Name = "Image2Label";
            Image2Label.Size = new Size(171, 30);
            Image2Label.TabIndex = 13;
            Image2Label.Text = "Small Image Key:";
            // 
            // Image1Text
            // 
            Image1Text.AutoSize = true;
            Image1Text.BackColor = Color.Transparent;
            Image1Text.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Image1Text.ForeColor = Color.FromArgb(165, 20, 180);
            Image1Text.Location = new Point(7, 393);
            Image1Text.Name = "Image1Text";
            Image1Text.Size = new Size(176, 30);
            Image1Text.TabIndex = 15;
            Image1Text.Text = "Large Image Text:";
            // 
            // LargeTextTextbox
            // 
            LargeTextTextbox.Location = new Point(190, 400);
            LargeTextTextbox.Name = "LargeTextTextbox";
            LargeTextTextbox.Size = new Size(205, 23);
            LargeTextTextbox.TabIndex = 16;
            // 
            // SmallTextTextbox
            // 
            SmallTextTextbox.Location = new Point(584, 400);
            SmallTextTextbox.Name = "SmallTextTextbox";
            SmallTextTextbox.Size = new Size(205, 23);
            SmallTextTextbox.TabIndex = 18;
            // 
            // Image2Text
            // 
            Image2Text.AutoSize = true;
            Image2Text.BackColor = Color.Transparent;
            Image2Text.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Image2Text.ForeColor = Color.FromArgb(165, 20, 180);
            Image2Text.Location = new Point(402, 393);
            Image2Text.Name = "Image2Text";
            Image2Text.Size = new Size(175, 30);
            Image2Text.TabIndex = 17;
            Image2Text.Text = "Small Image Text:";
            // 
            // ApplyDiscordRPC
            // 
            ApplyDiscordRPC.FlatStyle = FlatStyle.Flat;
            ApplyDiscordRPC.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApplyDiscordRPC.ForeColor = Color.FromArgb(165, 20, 180);
            ApplyDiscordRPC.Location = new Point(609, 488);
            ApplyDiscordRPC.Name = "ApplyDiscordRPC";
            ApplyDiscordRPC.Size = new Size(180, 40);
            ApplyDiscordRPC.TabIndex = 19;
            ApplyDiscordRPC.Text = "Apply";
            ApplyDiscordRPC.UseVisualStyleBackColor = true;
            ApplyDiscordRPC.Click += ApplyDiscordRPC_Click;
            // 
            // SaveSettingButton
            // 
            SaveSettingButton.FlatStyle = FlatStyle.Flat;
            SaveSettingButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveSettingButton.ForeColor = Color.FromArgb(165, 20, 180);
            SaveSettingButton.Location = new Point(423, 488);
            SaveSettingButton.Name = "SaveSettingButton";
            SaveSettingButton.Size = new Size(180, 40);
            SaveSettingButton.TabIndex = 20;
            SaveSettingButton.Text = "Save";
            SaveSettingButton.UseVisualStyleBackColor = true;
            SaveSettingButton.Click += SaveSettingButton_Click;
            // 
            // LoadConfigButton
            // 
            LoadConfigButton.FlatStyle = FlatStyle.Flat;
            LoadConfigButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoadConfigButton.ForeColor = Color.FromArgb(165, 20, 180);
            LoadConfigButton.Location = new Point(12, 488);
            LoadConfigButton.Name = "LoadConfigButton";
            LoadConfigButton.Size = new Size(180, 40);
            LoadConfigButton.TabIndex = 21;
            LoadConfigButton.Text = "Load";
            LoadConfigButton.UseVisualStyleBackColor = true;
            LoadConfigButton.Click += LoadConfigButton_Click;
            // 
            // Silk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(804, 540);
            Controls.Add(LoadConfigButton);
            Controls.Add(SaveSettingButton);
            Controls.Add(ApplyDiscordRPC);
            Controls.Add(SmallTextTextbox);
            Controls.Add(Image2Text);
            Controls.Add(LargeTextTextbox);
            Controls.Add(Image1Text);
            Controls.Add(SmallTextbox);
            Controls.Add(Image2Label);
            Controls.Add(LargeTextbox);
            Controls.Add(Image1Label);
            Controls.Add(ElapsedCheckbox);
            Controls.Add(ElapsedTimeLabel);
            Controls.Add(ActivityTypeLabel);
            Controls.Add(ActivityComboBox);
            Controls.Add(StateTextbox);
            Controls.Add(StateLabel);
            Controls.Add(DetailsTextbox);
            Controls.Add(DetailsLabel);
            Controls.Add(ApplicationTextbox);
            Controls.Add(ApplicationLabel);
            Controls.Add(TitlePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Silk";
            ShowIcon = false;
            Load += Silk_Load;
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TitlePanel;
        private Label TitleMirror;
        private Button MinimizeButton;
        private Button CloseButton;
        private Label ApplicationLabel;
        private TextBox ApplicationTextbox;
        private TextBox DetailsTextbox;
        private Label DetailsLabel;
        private TextBox StateTextbox;
        private Label StateLabel;
        private ComboBox ActivityComboBox;
        private Label ActivityTypeLabel;
        private Label ElapsedTimeLabel;
        private CheckBox ElapsedCheckbox;
        private Label Image1Label;
        private TextBox LargeTextbox;
        private TextBox SmallTextbox;
        private Label Image2Label;
        private Label Image1Text;
        private TextBox LargeTextTextbox;
        private TextBox SmallTextTextbox;
        private Label Image2Text;
        private Button ApplyDiscordRPC;
        private Button SaveSettingButton;
        private Button LoadConfigButton;
    }
}
