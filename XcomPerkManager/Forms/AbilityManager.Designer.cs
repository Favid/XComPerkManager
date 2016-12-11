namespace XcomPerkManager
{
    partial class AbilityManager
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
            this.cSquaddie3 = new System.Windows.Forms.ComboBox();
            this.soldierClassAbilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSquaddie2 = new System.Windows.Forms.ComboBox();
            this.soldierClassAbilityBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.soldierClassAbilityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.soldierClassAbilityBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cSquaddie1 = new System.Windows.Forms.ComboBox();
            this.laSquaddie = new System.Windows.Forms.Label();
            this.cBrigadier3 = new System.Windows.Forms.ComboBox();
            this.cBrigadier2 = new System.Windows.Forms.ComboBox();
            this.cBrigadier1 = new System.Windows.Forms.ComboBox();
            this.cColonel3 = new System.Windows.Forms.ComboBox();
            this.cColonel2 = new System.Windows.Forms.ComboBox();
            this.cColonel1 = new System.Windows.Forms.ComboBox();
            this.cMajor3 = new System.Windows.Forms.ComboBox();
            this.cMajor2 = new System.Windows.Forms.ComboBox();
            this.cMajor1 = new System.Windows.Forms.ComboBox();
            this.cCaptain3 = new System.Windows.Forms.ComboBox();
            this.cCaptain2 = new System.Windows.Forms.ComboBox();
            this.cCaptain1 = new System.Windows.Forms.ComboBox();
            this.cLieutenant3 = new System.Windows.Forms.ComboBox();
            this.cLieutenant2 = new System.Windows.Forms.ComboBox();
            this.cLieutenant1 = new System.Windows.Forms.ComboBox();
            this.cSergeant3 = new System.Windows.Forms.ComboBox();
            this.cSergeant2 = new System.Windows.Forms.ComboBox();
            this.cSergeant1 = new System.Windows.Forms.ComboBox();
            this.cCorporal3 = new System.Windows.Forms.ComboBox();
            this.cCorporal2 = new System.Windows.Forms.ComboBox();
            this.cCorporal1 = new System.Windows.Forms.ComboBox();
            this.laBrigadier = new System.Windows.Forms.Label();
            this.laColonel = new System.Windows.Forms.Label();
            this.laMajor = new System.Windows.Forms.Label();
            this.laCaptain = new System.Windows.Forms.Label();
            this.laLieutenant = new System.Windows.Forms.Label();
            this.laSergeant = new System.Windows.Forms.Label();
            this.laCorporal = new System.Windows.Forms.Label();
            this.laClass = new System.Windows.Forms.Label();
            this.cSquaddie6 = new System.Windows.Forms.ComboBox();
            this.cSquaddie5 = new System.Windows.Forms.ComboBox();
            this.cSquaddie4 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.soldierClassAbilityBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.laHelp = new System.Windows.Forms.Label();
            this.chDragAndDrop = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.soldierClassAbilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldierClassAbilityBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldierClassAbilityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldierClassAbilityBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldierClassAbilityBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // cSquaddie3
            // 
            this.cSquaddie3.AllowDrop = true;
            this.cSquaddie3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cSquaddie3.DataSource = this.soldierClassAbilityBindingSource;
            this.cSquaddie3.DisplayMember = "internalName";
            this.cSquaddie3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSquaddie3.FormattingEnabled = true;
            this.cSquaddie3.Location = new System.Drawing.Point(387, 76);
            this.cSquaddie3.Name = "cSquaddie3";
            this.cSquaddie3.Size = new System.Drawing.Size(121, 21);
            this.cSquaddie3.TabIndex = 68;
            this.cSquaddie3.ValueMember = "internalName";
            this.cSquaddie3.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cSquaddie3.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cSquaddie3.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cSquaddie3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // soldierClassAbilityBindingSource
            // 
            this.soldierClassAbilityBindingSource.DataSource = typeof(XcomPerkManager.SoldierClassAbility);
            // 
            // cSquaddie2
            // 
            this.cSquaddie2.AllowDrop = true;
            this.cSquaddie2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cSquaddie2.DataSource = this.soldierClassAbilityBindingSource;
            this.cSquaddie2.DisplayMember = "internalName";
            this.cSquaddie2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSquaddie2.FormattingEnabled = true;
            this.cSquaddie2.Location = new System.Drawing.Point(240, 76);
            this.cSquaddie2.Name = "cSquaddie2";
            this.cSquaddie2.Size = new System.Drawing.Size(121, 21);
            this.cSquaddie2.TabIndex = 67;
            this.cSquaddie2.ValueMember = "internalName";
            this.cSquaddie2.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cSquaddie2.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cSquaddie2.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cSquaddie2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // soldierClassAbilityBindingSource4
            // 
            this.soldierClassAbilityBindingSource4.DataSource = typeof(XcomPerkManager.SoldierClassAbility);
            // 
            // soldierClassAbilityBindingSource1
            // 
            this.soldierClassAbilityBindingSource1.DataSource = typeof(XcomPerkManager.SoldierClassAbility);
            // 
            // soldierClassAbilityBindingSource2
            // 
            this.soldierClassAbilityBindingSource2.DataSource = typeof(XcomPerkManager.SoldierClassAbility);
            // 
            // cSquaddie1
            // 
            this.cSquaddie1.AllowDrop = true;
            this.cSquaddie1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cSquaddie1.DataSource = this.soldierClassAbilityBindingSource;
            this.cSquaddie1.DisplayMember = "internalName";
            this.cSquaddie1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSquaddie1.FormattingEnabled = true;
            this.cSquaddie1.Location = new System.Drawing.Point(93, 76);
            this.cSquaddie1.Name = "cSquaddie1";
            this.cSquaddie1.Size = new System.Drawing.Size(121, 21);
            this.cSquaddie1.TabIndex = 66;
            this.cSquaddie1.ValueMember = "internalName";
            this.cSquaddie1.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cSquaddie1.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cSquaddie1.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cSquaddie1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // laSquaddie
            // 
            this.laSquaddie.AutoSize = true;
            this.laSquaddie.Location = new System.Drawing.Point(12, 84);
            this.laSquaddie.Name = "laSquaddie";
            this.laSquaddie.Size = new System.Drawing.Size(52, 13);
            this.laSquaddie.TabIndex = 65;
            this.laSquaddie.Text = "Squaddie";
            // 
            // cBrigadier3
            // 
            this.cBrigadier3.AllowDrop = true;
            this.cBrigadier3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cBrigadier3.DataSource = this.soldierClassAbilityBindingSource;
            this.cBrigadier3.DisplayMember = "internalName";
            this.cBrigadier3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBrigadier3.FormattingEnabled = true;
            this.cBrigadier3.Location = new System.Drawing.Point(387, 308);
            this.cBrigadier3.Name = "cBrigadier3";
            this.cBrigadier3.Size = new System.Drawing.Size(121, 21);
            this.cBrigadier3.TabIndex = 64;
            this.cBrigadier3.ValueMember = "internalName";
            this.cBrigadier3.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cBrigadier3.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cBrigadier3.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cBrigadier3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cBrigadier2
            // 
            this.cBrigadier2.AllowDrop = true;
            this.cBrigadier2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cBrigadier2.DataSource = this.soldierClassAbilityBindingSource;
            this.cBrigadier2.DisplayMember = "internalName";
            this.cBrigadier2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBrigadier2.FormattingEnabled = true;
            this.cBrigadier2.Location = new System.Drawing.Point(240, 308);
            this.cBrigadier2.Name = "cBrigadier2";
            this.cBrigadier2.Size = new System.Drawing.Size(121, 21);
            this.cBrigadier2.TabIndex = 63;
            this.cBrigadier2.ValueMember = "internalName";
            this.cBrigadier2.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cBrigadier2.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cBrigadier2.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cBrigadier2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cBrigadier1
            // 
            this.cBrigadier1.AllowDrop = true;
            this.cBrigadier1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cBrigadier1.DataSource = this.soldierClassAbilityBindingSource;
            this.cBrigadier1.DisplayMember = "internalName";
            this.cBrigadier1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBrigadier1.FormattingEnabled = true;
            this.cBrigadier1.Location = new System.Drawing.Point(93, 308);
            this.cBrigadier1.Name = "cBrigadier1";
            this.cBrigadier1.Size = new System.Drawing.Size(121, 21);
            this.cBrigadier1.TabIndex = 62;
            this.cBrigadier1.ValueMember = "internalName";
            this.cBrigadier1.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cBrigadier1.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cBrigadier1.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cBrigadier1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cColonel3
            // 
            this.cColonel3.AllowDrop = true;
            this.cColonel3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cColonel3.DataSource = this.soldierClassAbilityBindingSource;
            this.cColonel3.DisplayMember = "internalName";
            this.cColonel3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cColonel3.FormattingEnabled = true;
            this.cColonel3.Location = new System.Drawing.Point(387, 281);
            this.cColonel3.Name = "cColonel3";
            this.cColonel3.Size = new System.Drawing.Size(121, 21);
            this.cColonel3.TabIndex = 61;
            this.cColonel3.ValueMember = "internalName";
            this.cColonel3.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cColonel3.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cColonel3.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cColonel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cColonel2
            // 
            this.cColonel2.AllowDrop = true;
            this.cColonel2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cColonel2.DataSource = this.soldierClassAbilityBindingSource;
            this.cColonel2.DisplayMember = "internalName";
            this.cColonel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cColonel2.FormattingEnabled = true;
            this.cColonel2.Location = new System.Drawing.Point(240, 281);
            this.cColonel2.Name = "cColonel2";
            this.cColonel2.Size = new System.Drawing.Size(121, 21);
            this.cColonel2.TabIndex = 60;
            this.cColonel2.ValueMember = "internalName";
            this.cColonel2.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cColonel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cColonel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cColonel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cColonel1
            // 
            this.cColonel1.AllowDrop = true;
            this.cColonel1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cColonel1.DataSource = this.soldierClassAbilityBindingSource;
            this.cColonel1.DisplayMember = "internalName";
            this.cColonel1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cColonel1.FormattingEnabled = true;
            this.cColonel1.Location = new System.Drawing.Point(93, 281);
            this.cColonel1.Name = "cColonel1";
            this.cColonel1.Size = new System.Drawing.Size(121, 21);
            this.cColonel1.TabIndex = 59;
            this.cColonel1.ValueMember = "internalName";
            this.cColonel1.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cColonel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cColonel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cColonel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cMajor3
            // 
            this.cMajor3.AllowDrop = true;
            this.cMajor3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cMajor3.DataSource = this.soldierClassAbilityBindingSource;
            this.cMajor3.DisplayMember = "internalName";
            this.cMajor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMajor3.FormattingEnabled = true;
            this.cMajor3.Location = new System.Drawing.Point(387, 254);
            this.cMajor3.Name = "cMajor3";
            this.cMajor3.Size = new System.Drawing.Size(121, 21);
            this.cMajor3.TabIndex = 58;
            this.cMajor3.ValueMember = "internalName";
            this.cMajor3.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cMajor3.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cMajor3.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cMajor3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cMajor2
            // 
            this.cMajor2.AllowDrop = true;
            this.cMajor2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cMajor2.DataSource = this.soldierClassAbilityBindingSource;
            this.cMajor2.DisplayMember = "internalName";
            this.cMajor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMajor2.FormattingEnabled = true;
            this.cMajor2.Location = new System.Drawing.Point(240, 254);
            this.cMajor2.Name = "cMajor2";
            this.cMajor2.Size = new System.Drawing.Size(121, 21);
            this.cMajor2.TabIndex = 57;
            this.cMajor2.ValueMember = "internalName";
            this.cMajor2.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cMajor2.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cMajor2.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cMajor2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cMajor1
            // 
            this.cMajor1.AllowDrop = true;
            this.cMajor1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cMajor1.DataSource = this.soldierClassAbilityBindingSource;
            this.cMajor1.DisplayMember = "internalName";
            this.cMajor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMajor1.FormattingEnabled = true;
            this.cMajor1.Location = new System.Drawing.Point(93, 254);
            this.cMajor1.Name = "cMajor1";
            this.cMajor1.Size = new System.Drawing.Size(121, 21);
            this.cMajor1.TabIndex = 56;
            this.cMajor1.ValueMember = "internalName";
            this.cMajor1.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cMajor1.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cMajor1.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cMajor1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cCaptain3
            // 
            this.cCaptain3.AllowDrop = true;
            this.cCaptain3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cCaptain3.DataSource = this.soldierClassAbilityBindingSource;
            this.cCaptain3.DisplayMember = "internalName";
            this.cCaptain3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cCaptain3.FormattingEnabled = true;
            this.cCaptain3.Location = new System.Drawing.Point(387, 227);
            this.cCaptain3.Name = "cCaptain3";
            this.cCaptain3.Size = new System.Drawing.Size(121, 21);
            this.cCaptain3.TabIndex = 55;
            this.cCaptain3.ValueMember = "internalName";
            this.cCaptain3.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cCaptain3.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cCaptain3.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cCaptain3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cCaptain2
            // 
            this.cCaptain2.AllowDrop = true;
            this.cCaptain2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cCaptain2.DataSource = this.soldierClassAbilityBindingSource;
            this.cCaptain2.DisplayMember = "internalName";
            this.cCaptain2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cCaptain2.FormattingEnabled = true;
            this.cCaptain2.Location = new System.Drawing.Point(240, 227);
            this.cCaptain2.Name = "cCaptain2";
            this.cCaptain2.Size = new System.Drawing.Size(121, 21);
            this.cCaptain2.TabIndex = 54;
            this.cCaptain2.ValueMember = "internalName";
            this.cCaptain2.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cCaptain2.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cCaptain2.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cCaptain2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cCaptain1
            // 
            this.cCaptain1.AllowDrop = true;
            this.cCaptain1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cCaptain1.DataSource = this.soldierClassAbilityBindingSource;
            this.cCaptain1.DisplayMember = "internalName";
            this.cCaptain1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cCaptain1.FormattingEnabled = true;
            this.cCaptain1.Location = new System.Drawing.Point(93, 227);
            this.cCaptain1.Name = "cCaptain1";
            this.cCaptain1.Size = new System.Drawing.Size(121, 21);
            this.cCaptain1.TabIndex = 53;
            this.cCaptain1.ValueMember = "internalName";
            this.cCaptain1.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cCaptain1.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cCaptain1.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cCaptain1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cLieutenant3
            // 
            this.cLieutenant3.AllowDrop = true;
            this.cLieutenant3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cLieutenant3.DataSource = this.soldierClassAbilityBindingSource;
            this.cLieutenant3.DisplayMember = "internalName";
            this.cLieutenant3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cLieutenant3.FormattingEnabled = true;
            this.cLieutenant3.Location = new System.Drawing.Point(387, 200);
            this.cLieutenant3.Name = "cLieutenant3";
            this.cLieutenant3.Size = new System.Drawing.Size(121, 21);
            this.cLieutenant3.TabIndex = 52;
            this.cLieutenant3.ValueMember = "internalName";
            this.cLieutenant3.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cLieutenant3.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cLieutenant3.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cLieutenant3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cLieutenant2
            // 
            this.cLieutenant2.AllowDrop = true;
            this.cLieutenant2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cLieutenant2.DataSource = this.soldierClassAbilityBindingSource;
            this.cLieutenant2.DisplayMember = "internalName";
            this.cLieutenant2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cLieutenant2.FormattingEnabled = true;
            this.cLieutenant2.Location = new System.Drawing.Point(240, 200);
            this.cLieutenant2.Name = "cLieutenant2";
            this.cLieutenant2.Size = new System.Drawing.Size(121, 21);
            this.cLieutenant2.TabIndex = 51;
            this.cLieutenant2.ValueMember = "internalName";
            this.cLieutenant2.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cLieutenant2.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cLieutenant2.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cLieutenant2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cLieutenant1
            // 
            this.cLieutenant1.AllowDrop = true;
            this.cLieutenant1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cLieutenant1.DataSource = this.soldierClassAbilityBindingSource;
            this.cLieutenant1.DisplayMember = "internalName";
            this.cLieutenant1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cLieutenant1.FormattingEnabled = true;
            this.cLieutenant1.Location = new System.Drawing.Point(93, 200);
            this.cLieutenant1.Name = "cLieutenant1";
            this.cLieutenant1.Size = new System.Drawing.Size(121, 21);
            this.cLieutenant1.TabIndex = 50;
            this.cLieutenant1.ValueMember = "internalName";
            this.cLieutenant1.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cLieutenant1.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cLieutenant1.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cLieutenant1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cSergeant3
            // 
            this.cSergeant3.AllowDrop = true;
            this.cSergeant3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cSergeant3.DataSource = this.soldierClassAbilityBindingSource;
            this.cSergeant3.DisplayMember = "internalName";
            this.cSergeant3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSergeant3.FormattingEnabled = true;
            this.cSergeant3.Location = new System.Drawing.Point(387, 173);
            this.cSergeant3.Name = "cSergeant3";
            this.cSergeant3.Size = new System.Drawing.Size(121, 21);
            this.cSergeant3.TabIndex = 49;
            this.cSergeant3.ValueMember = "internalName";
            this.cSergeant3.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cSergeant3.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cSergeant3.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cSergeant3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cSergeant2
            // 
            this.cSergeant2.AllowDrop = true;
            this.cSergeant2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cSergeant2.DataSource = this.soldierClassAbilityBindingSource;
            this.cSergeant2.DisplayMember = "internalName";
            this.cSergeant2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSergeant2.FormattingEnabled = true;
            this.cSergeant2.Location = new System.Drawing.Point(240, 173);
            this.cSergeant2.Name = "cSergeant2";
            this.cSergeant2.Size = new System.Drawing.Size(121, 21);
            this.cSergeant2.TabIndex = 48;
            this.cSergeant2.ValueMember = "internalName";
            this.cSergeant2.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cSergeant2.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cSergeant2.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cSergeant2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cSergeant1
            // 
            this.cSergeant1.AllowDrop = true;
            this.cSergeant1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cSergeant1.DataSource = this.soldierClassAbilityBindingSource;
            this.cSergeant1.DisplayMember = "internalName";
            this.cSergeant1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSergeant1.FormattingEnabled = true;
            this.cSergeant1.Location = new System.Drawing.Point(93, 173);
            this.cSergeant1.Name = "cSergeant1";
            this.cSergeant1.Size = new System.Drawing.Size(121, 21);
            this.cSergeant1.TabIndex = 47;
            this.cSergeant1.ValueMember = "internalName";
            this.cSergeant1.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cSergeant1.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cSergeant1.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cSergeant1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cCorporal3
            // 
            this.cCorporal3.AllowDrop = true;
            this.cCorporal3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cCorporal3.DataSource = this.soldierClassAbilityBindingSource;
            this.cCorporal3.DisplayMember = "internalName";
            this.cCorporal3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cCorporal3.FormattingEnabled = true;
            this.cCorporal3.Location = new System.Drawing.Point(387, 146);
            this.cCorporal3.Name = "cCorporal3";
            this.cCorporal3.Size = new System.Drawing.Size(121, 21);
            this.cCorporal3.TabIndex = 46;
            this.cCorporal3.ValueMember = "internalName";
            this.cCorporal3.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cCorporal3.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cCorporal3.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cCorporal3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cCorporal2
            // 
            this.cCorporal2.AllowDrop = true;
            this.cCorporal2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cCorporal2.DataSource = this.soldierClassAbilityBindingSource;
            this.cCorporal2.DisplayMember = "internalName";
            this.cCorporal2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cCorporal2.FormattingEnabled = true;
            this.cCorporal2.Location = new System.Drawing.Point(240, 146);
            this.cCorporal2.Name = "cCorporal2";
            this.cCorporal2.Size = new System.Drawing.Size(121, 21);
            this.cCorporal2.TabIndex = 45;
            this.cCorporal2.ValueMember = "internalName";
            this.cCorporal2.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cCorporal2.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cCorporal2.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cCorporal2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cCorporal1
            // 
            this.cCorporal1.AllowDrop = true;
            this.cCorporal1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cCorporal1.DataSource = this.soldierClassAbilityBindingSource;
            this.cCorporal1.DisplayMember = "internalName";
            this.cCorporal1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cCorporal1.FormattingEnabled = true;
            this.cCorporal1.Location = new System.Drawing.Point(93, 146);
            this.cCorporal1.Name = "cCorporal1";
            this.cCorporal1.Size = new System.Drawing.Size(121, 21);
            this.cCorporal1.TabIndex = 44;
            this.cCorporal1.ValueMember = "internalName";
            this.cCorporal1.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cCorporal1.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cCorporal1.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cCorporal1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // laBrigadier
            // 
            this.laBrigadier.AutoSize = true;
            this.laBrigadier.Location = new System.Drawing.Point(12, 316);
            this.laBrigadier.Name = "laBrigadier";
            this.laBrigadier.Size = new System.Drawing.Size(48, 13);
            this.laBrigadier.TabIndex = 43;
            this.laBrigadier.Text = "Brigadier";
            // 
            // laColonel
            // 
            this.laColonel.AutoSize = true;
            this.laColonel.Location = new System.Drawing.Point(12, 289);
            this.laColonel.Name = "laColonel";
            this.laColonel.Size = new System.Drawing.Size(42, 13);
            this.laColonel.TabIndex = 42;
            this.laColonel.Text = "Colonel";
            // 
            // laMajor
            // 
            this.laMajor.AutoSize = true;
            this.laMajor.Location = new System.Drawing.Point(12, 262);
            this.laMajor.Name = "laMajor";
            this.laMajor.Size = new System.Drawing.Size(33, 13);
            this.laMajor.TabIndex = 41;
            this.laMajor.Text = "Major";
            // 
            // laCaptain
            // 
            this.laCaptain.AutoSize = true;
            this.laCaptain.Location = new System.Drawing.Point(12, 235);
            this.laCaptain.Name = "laCaptain";
            this.laCaptain.Size = new System.Drawing.Size(43, 13);
            this.laCaptain.TabIndex = 40;
            this.laCaptain.Text = "Captain";
            // 
            // laLieutenant
            // 
            this.laLieutenant.AutoSize = true;
            this.laLieutenant.Location = new System.Drawing.Point(12, 208);
            this.laLieutenant.Name = "laLieutenant";
            this.laLieutenant.Size = new System.Drawing.Size(57, 13);
            this.laLieutenant.TabIndex = 39;
            this.laLieutenant.Text = "Lieutenant";
            // 
            // laSergeant
            // 
            this.laSergeant.AutoSize = true;
            this.laSergeant.Location = new System.Drawing.Point(12, 181);
            this.laSergeant.Name = "laSergeant";
            this.laSergeant.Size = new System.Drawing.Size(50, 13);
            this.laSergeant.TabIndex = 38;
            this.laSergeant.Text = "Sergeant";
            // 
            // laCorporal
            // 
            this.laCorporal.AutoSize = true;
            this.laCorporal.Location = new System.Drawing.Point(12, 154);
            this.laCorporal.Name = "laCorporal";
            this.laCorporal.Size = new System.Drawing.Size(46, 13);
            this.laCorporal.TabIndex = 37;
            this.laCorporal.Text = "Corporal";
            // 
            // laClass
            // 
            this.laClass.AutoSize = true;
            this.laClass.Location = new System.Drawing.Point(12, 9);
            this.laClass.Name = "laClass";
            this.laClass.Size = new System.Drawing.Size(41, 13);
            this.laClass.TabIndex = 36;
            this.laClass.Text = "Assault";
            // 
            // cSquaddie6
            // 
            this.cSquaddie6.AllowDrop = true;
            this.cSquaddie6.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cSquaddie6.DataSource = this.soldierClassAbilityBindingSource;
            this.cSquaddie6.DisplayMember = "internalName";
            this.cSquaddie6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSquaddie6.FormattingEnabled = true;
            this.cSquaddie6.Location = new System.Drawing.Point(387, 103);
            this.cSquaddie6.Name = "cSquaddie6";
            this.cSquaddie6.Size = new System.Drawing.Size(121, 21);
            this.cSquaddie6.TabIndex = 71;
            this.cSquaddie6.ValueMember = "internalName";
            this.cSquaddie6.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cSquaddie6.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cSquaddie6.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cSquaddie6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cSquaddie5
            // 
            this.cSquaddie5.AllowDrop = true;
            this.cSquaddie5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cSquaddie5.DataSource = this.soldierClassAbilityBindingSource;
            this.cSquaddie5.DisplayMember = "internalName";
            this.cSquaddie5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSquaddie5.FormattingEnabled = true;
            this.cSquaddie5.Location = new System.Drawing.Point(240, 103);
            this.cSquaddie5.Name = "cSquaddie5";
            this.cSquaddie5.Size = new System.Drawing.Size(121, 21);
            this.cSquaddie5.TabIndex = 70;
            this.cSquaddie5.ValueMember = "internalName";
            this.cSquaddie5.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cSquaddie5.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cSquaddie5.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cSquaddie5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // cSquaddie4
            // 
            this.cSquaddie4.AllowDrop = true;
            this.cSquaddie4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soldierClassAbilityBindingSource, "internalName", true));
            this.cSquaddie4.DataSource = this.soldierClassAbilityBindingSource;
            this.cSquaddie4.DisplayMember = "internalName";
            this.cSquaddie4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSquaddie4.FormattingEnabled = true;
            this.cSquaddie4.Location = new System.Drawing.Point(93, 103);
            this.cSquaddie4.Name = "cSquaddie4";
            this.cSquaddie4.Size = new System.Drawing.Size(121, 21);
            this.cSquaddie4.TabIndex = 69;
            this.cSquaddie4.ValueMember = "internalName";
            this.cSquaddie4.SelectedIndexChanged += new System.EventHandler(this.cAbility_SelectedIndexChanged);
            this.cSquaddie4.DragDrop += new System.Windows.Forms.DragEventHandler(this.cAbility_DragDrop);
            this.cSquaddie4.DragEnter += new System.Windows.Forms.DragEventHandler(this.cAbility_DragEnter);
            this.cSquaddie4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cAbility_MouseDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 72;
            this.checkBox1.Text = "Allow AWC Abilities";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(352, 428);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 73;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(433, 428);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 74;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // soldierClassAbilityBindingSource3
            // 
            this.soldierClassAbilityBindingSource3.DataSource = typeof(XcomPerkManager.SoldierClassAbility);
            // 
            // laHelp
            // 
            this.laHelp.Location = new System.Drawing.Point(15, 355);
            this.laHelp.Name = "laHelp";
            this.laHelp.Size = new System.Drawing.Size(493, 70);
            this.laHelp.TabIndex = 75;
            this.laHelp.Text = "A close quarters specialist that excels at dealing high critical damage and takin" +
    "g hits. Not very effective at longer ranges.";
            // 
            // chDragAndDrop
            // 
            this.chDragAndDrop.AutoSize = true;
            this.chDragAndDrop.Location = new System.Drawing.Point(159, 35);
            this.chDragAndDrop.Name = "chDragAndDrop";
            this.chDragAndDrop.Size = new System.Drawing.Size(96, 17);
            this.chDragAndDrop.TabIndex = 76;
            this.chDragAndDrop.Text = "Drag and Drop";
            this.chDragAndDrop.UseVisualStyleBackColor = true;
            // 
            // AbilityManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 463);
            this.Controls.Add(this.chDragAndDrop);
            this.Controls.Add(this.laHelp);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cSquaddie6);
            this.Controls.Add(this.cSquaddie5);
            this.Controls.Add(this.cSquaddie4);
            this.Controls.Add(this.cSquaddie3);
            this.Controls.Add(this.cSquaddie2);
            this.Controls.Add(this.cSquaddie1);
            this.Controls.Add(this.laSquaddie);
            this.Controls.Add(this.cBrigadier3);
            this.Controls.Add(this.cBrigadier2);
            this.Controls.Add(this.cBrigadier1);
            this.Controls.Add(this.cColonel3);
            this.Controls.Add(this.cColonel2);
            this.Controls.Add(this.cColonel1);
            this.Controls.Add(this.cMajor3);
            this.Controls.Add(this.cMajor2);
            this.Controls.Add(this.cMajor1);
            this.Controls.Add(this.cCaptain3);
            this.Controls.Add(this.cCaptain2);
            this.Controls.Add(this.cCaptain1);
            this.Controls.Add(this.cLieutenant3);
            this.Controls.Add(this.cLieutenant2);
            this.Controls.Add(this.cLieutenant1);
            this.Controls.Add(this.cSergeant3);
            this.Controls.Add(this.cSergeant2);
            this.Controls.Add(this.cSergeant1);
            this.Controls.Add(this.cCorporal3);
            this.Controls.Add(this.cCorporal2);
            this.Controls.Add(this.cCorporal1);
            this.Controls.Add(this.laBrigadier);
            this.Controls.Add(this.laColonel);
            this.Controls.Add(this.laMajor);
            this.Controls.Add(this.laCaptain);
            this.Controls.Add(this.laLieutenant);
            this.Controls.Add(this.laSergeant);
            this.Controls.Add(this.laCorporal);
            this.Controls.Add(this.laClass);
            this.Name = "AbilityManager";
            this.Text = "AbilityManager";
            this.Load += new System.EventHandler(this.AbilityManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soldierClassAbilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldierClassAbilityBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldierClassAbilityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldierClassAbilityBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldierClassAbilityBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cSquaddie3;
        private System.Windows.Forms.ComboBox cSquaddie2;
        private System.Windows.Forms.ComboBox cSquaddie1;
        private System.Windows.Forms.Label laSquaddie;
        private System.Windows.Forms.ComboBox cBrigadier3;
        private System.Windows.Forms.ComboBox cBrigadier2;
        private System.Windows.Forms.ComboBox cBrigadier1;
        private System.Windows.Forms.ComboBox cColonel3;
        private System.Windows.Forms.ComboBox cColonel2;
        private System.Windows.Forms.ComboBox cColonel1;
        private System.Windows.Forms.ComboBox cMajor3;
        private System.Windows.Forms.ComboBox cMajor2;
        private System.Windows.Forms.ComboBox cMajor1;
        private System.Windows.Forms.ComboBox cCaptain3;
        private System.Windows.Forms.ComboBox cCaptain2;
        private System.Windows.Forms.ComboBox cCaptain1;
        private System.Windows.Forms.ComboBox cLieutenant3;
        private System.Windows.Forms.ComboBox cLieutenant2;
        private System.Windows.Forms.ComboBox cLieutenant1;
        private System.Windows.Forms.ComboBox cSergeant3;
        private System.Windows.Forms.ComboBox cSergeant2;
        private System.Windows.Forms.ComboBox cSergeant1;
        private System.Windows.Forms.ComboBox cCorporal3;
        private System.Windows.Forms.ComboBox cCorporal2;
        private System.Windows.Forms.ComboBox cCorporal1;
        private System.Windows.Forms.Label laBrigadier;
        private System.Windows.Forms.Label laColonel;
        private System.Windows.Forms.Label laMajor;
        private System.Windows.Forms.Label laCaptain;
        private System.Windows.Forms.Label laLieutenant;
        private System.Windows.Forms.Label laSergeant;
        private System.Windows.Forms.Label laCorporal;
        private System.Windows.Forms.Label laClass;
        private System.Windows.Forms.ComboBox cSquaddie6;
        private System.Windows.Forms.ComboBox cSquaddie5;
        private System.Windows.Forms.ComboBox cSquaddie4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.BindingSource soldierClassAbilityBindingSource;
        private System.Windows.Forms.BindingSource soldierClassAbilityBindingSource1;
        private System.Windows.Forms.BindingSource soldierClassAbilityBindingSource2;
        private System.Windows.Forms.BindingSource soldierClassAbilityBindingSource4;
        private System.Windows.Forms.BindingSource soldierClassAbilityBindingSource3;
        private System.Windows.Forms.Label laHelp;
        private System.Windows.Forms.CheckBox chDragAndDrop;
    }
}