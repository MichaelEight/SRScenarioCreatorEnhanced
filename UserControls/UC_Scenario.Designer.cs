﻿namespace SRScenarioCreatorEnhanced.UserControls
{
    partial class UC_Scenario
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelScenarioName = new System.Windows.Forms.Label();
            this.labelCacheName = new System.Windows.Forms.Label();
            this.comboScenarioName = new System.Windows.Forms.ComboBox();
            this.comboCacheName = new System.Windows.Forms.ComboBox();
            this.checkCacheName = new System.Windows.Forms.CheckBox();
            this.checkOOF = new System.Windows.Forms.CheckBox();
            this.comboOOF = new System.Windows.Forms.ComboBox();
            this.comboMapName = new System.Windows.Forms.ComboBox();
            this.labelOOF = new System.Windows.Forms.Label();
            this.labelMapName = new System.Windows.Forms.Label();
            this.checkNewMap = new System.Windows.Forms.CheckBox();
            this.comboPPLX = new System.Windows.Forms.ComboBox();
            this.comboUnit = new System.Windows.Forms.ComboBox();
            this.labelPPLX = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.comboTERX = new System.Windows.Forms.ComboBox();
            this.comboTTRX = new System.Windows.Forms.ComboBox();
            this.labelTERX = new System.Windows.Forms.Label();
            this.labelTTRX = new System.Windows.Forms.Label();
            this.comboProfile = new System.Windows.Forms.ComboBox();
            this.comboNewsItems = new System.Windows.Forms.ComboBox();
            this.labelProfile = new System.Windows.Forms.Label();
            this.labelNewsItems = new System.Windows.Forms.Label();
            this.comboPostCache = new System.Windows.Forms.ComboBox();
            this.labelPostCache = new System.Windows.Forms.Label();
            this.comboPreCache = new System.Windows.Forms.ComboBox();
            this.comboOOB = new System.Windows.Forms.ComboBox();
            this.labelPreCache = new System.Windows.Forms.Label();
            this.labelOOB = new System.Windows.Forms.Label();
            this.comboWM = new System.Windows.Forms.ComboBox();
            this.comboCVP = new System.Windows.Forms.ComboBox();
            this.labelWM = new System.Windows.Forms.Label();
            this.labelCVP = new System.Windows.Forms.Label();
            this.checkModifyCVP = new System.Windows.Forms.CheckBox();
            this.checkModifyWM = new System.Windows.Forms.CheckBox();
            this.checkModifyOOB = new System.Windows.Forms.CheckBox();
            this.checkNoneditDefault = new System.Windows.Forms.CheckBox();
            this.labelGeneralInformation = new System.Windows.Forms.Label();
            this.labelMapFiles = new System.Windows.Forms.Label();
            this.labelNonEditableData = new System.Windows.Forms.Label();
            this.labelEditableData = new System.Windows.Forms.Label();
            this.labelRequiredScenarioName = new System.Windows.Forms.Label();
            this.labelRequiredCacheName = new System.Windows.Forms.Label();
            this.labelRequiredMapName = new System.Windows.Forms.Label();
            this.labelRequiredOOF = new System.Windows.Forms.Label();
            this.labelRequiredCVP = new System.Windows.Forms.Label();
            this.labelRequiredWM = new System.Windows.Forms.Label();
            this.labelRequiredUnit = new System.Windows.Forms.Label();
            this.labelRequiredPPLX = new System.Windows.Forms.Label();
            this.labelRequiredTTRX = new System.Windows.Forms.Label();
            this.labelRequiredTERX = new System.Windows.Forms.Label();
            this.labelRequiredNewsItems = new System.Windows.Forms.Label();
            this.labelRequiredProfile = new System.Windows.Forms.Label();
            this.labelRequiredInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelScenarioName
            // 
            this.labelScenarioName.AutoSize = true;
            this.labelScenarioName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScenarioName.Location = new System.Drawing.Point(80, 139);
            this.labelScenarioName.Name = "labelScenarioName";
            this.labelScenarioName.Size = new System.Drawing.Size(226, 34);
            this.labelScenarioName.TabIndex = 0;
            this.labelScenarioName.Text = "Scenario Name";
            this.labelScenarioName.SizeChanged += new System.EventHandler(this.labels_SizeChanged);
            // 
            // labelCacheName
            // 
            this.labelCacheName.AutoSize = true;
            this.labelCacheName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCacheName.Location = new System.Drawing.Point(104, 189);
            this.labelCacheName.Name = "labelCacheName";
            this.labelCacheName.Size = new System.Drawing.Size(202, 34);
            this.labelCacheName.TabIndex = 1;
            this.labelCacheName.Text = "Cache Name";
            this.labelCacheName.SizeChanged += new System.EventHandler(this.labels_SizeChanged);
            // 
            // comboScenarioName
            // 
            this.comboScenarioName.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comboScenarioName.FormattingEnabled = true;
            this.comboScenarioName.Location = new System.Drawing.Point(312, 136);
            this.comboScenarioName.Name = "comboScenarioName";
            this.comboScenarioName.Size = new System.Drawing.Size(266, 42);
            this.comboScenarioName.TabIndex = 2;
            this.comboScenarioName.SelectedIndexChanged += new System.EventHandler(this.comboScenarioName_SelectedIndexChanged);
            this.comboScenarioName.TextUpdate += new System.EventHandler(this.comboScenarioName_TextUpdate);
            // 
            // comboCacheName
            // 
            this.comboCacheName.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comboCacheName.FormattingEnabled = true;
            this.comboCacheName.Location = new System.Drawing.Point(312, 186);
            this.comboCacheName.Name = "comboCacheName";
            this.comboCacheName.Size = new System.Drawing.Size(266, 42);
            this.comboCacheName.TabIndex = 3;
            this.comboCacheName.SelectedIndexChanged += new System.EventHandler(this.comboCacheName_TextUpdate);
            this.comboCacheName.TextUpdate += new System.EventHandler(this.comboCacheName_TextUpdate);
            // 
            // checkCacheName
            // 
            this.checkCacheName.AutoSize = true;
            this.checkCacheName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkCacheName.Location = new System.Drawing.Point(600, 198);
            this.checkCacheName.Name = "checkCacheName";
            this.checkCacheName.Size = new System.Drawing.Size(277, 27);
            this.checkCacheName.TabIndex = 4;
            this.checkCacheName.Text = "Same as Scenario Name";
            this.checkCacheName.UseVisualStyleBackColor = true;
            this.checkCacheName.CheckedChanged += new System.EventHandler(this.checkCacheName_CheckedChanged);
            // 
            // checkOOF
            // 
            this.checkOOF.AutoSize = true;
            this.checkOOF.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkOOF.Location = new System.Drawing.Point(1496, 198);
            this.checkOOF.Name = "checkOOF";
            this.checkOOF.Size = new System.Drawing.Size(238, 27);
            this.checkOOF.TabIndex = 9;
            this.checkOOF.Text = "Same as Map Name";
            this.checkOOF.UseVisualStyleBackColor = true;
            this.checkOOF.CheckedChanged += new System.EventHandler(this.checkOOF_CheckedChanged);
            // 
            // comboOOF
            // 
            this.comboOOF.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comboOOF.FormattingEnabled = true;
            this.comboOOF.Location = new System.Drawing.Point(1201, 189);
            this.comboOOF.Name = "comboOOF";
            this.comboOOF.Size = new System.Drawing.Size(266, 42);
            this.comboOOF.TabIndex = 8;
            this.comboOOF.SelectedIndexChanged += new System.EventHandler(this.comboOOF_TextUpdate);
            this.comboOOF.TextUpdate += new System.EventHandler(this.comboOOF_TextUpdate);
            // 
            // comboMapName
            // 
            this.comboMapName.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comboMapName.FormattingEnabled = true;
            this.comboMapName.Location = new System.Drawing.Point(1201, 139);
            this.comboMapName.Name = "comboMapName";
            this.comboMapName.Size = new System.Drawing.Size(266, 42);
            this.comboMapName.TabIndex = 7;
            this.comboMapName.SelectedIndexChanged += new System.EventHandler(this.comboMapName_TextUpdate);
            this.comboMapName.TextUpdate += new System.EventHandler(this.comboMapName_TextUpdate);
            // 
            // labelOOF
            // 
            this.labelOOF.AutoSize = true;
            this.labelOOF.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOOF.Location = new System.Drawing.Point(1112, 192);
            this.labelOOF.Name = "labelOOF";
            this.labelOOF.Size = new System.Drawing.Size(77, 34);
            this.labelOOF.TabIndex = 6;
            this.labelOOF.Text = "OOF";
            this.labelOOF.SizeChanged += new System.EventHandler(this.labels_SizeChanged);
            // 
            // labelMapName
            // 
            this.labelMapName.AutoSize = true;
            this.labelMapName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMapName.Location = new System.Drawing.Point(1019, 141);
            this.labelMapName.Name = "labelMapName";
            this.labelMapName.Size = new System.Drawing.Size(170, 34);
            this.labelMapName.TabIndex = 5;
            this.labelMapName.Text = "Map Name";
            this.labelMapName.SizeChanged += new System.EventHandler(this.labels_SizeChanged);
            // 
            // checkNewMap
            // 
            this.checkNewMap.AutoSize = true;
            this.checkNewMap.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkNewMap.Location = new System.Drawing.Point(1496, 148);
            this.checkNewMap.Name = "checkNewMap";
            this.checkNewMap.Size = new System.Drawing.Size(208, 27);
            this.checkNewMap.TabIndex = 10;
            this.checkNewMap.Text = "Create New Map";
            this.checkNewMap.UseVisualStyleBackColor = true;
            this.checkNewMap.CheckedChanged += new System.EventHandler(this.checkNewMap_CheckedChanged);
            // 
            // comboPPLX
            // 
            this.comboPPLX.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comboPPLX.FormattingEnabled = true;
            this.comboPPLX.Location = new System.Drawing.Point(312, 565);
            this.comboPPLX.Name = "comboPPLX";
            this.comboPPLX.Size = new System.Drawing.Size(266, 42);
            this.comboPPLX.TabIndex = 14;
            this.comboPPLX.SelectedIndexChanged += new System.EventHandler(this.comboPPLX_TextUpdate);
            this.comboPPLX.TextUpdate += new System.EventHandler(this.comboPPLX_TextUpdate);
            // 
            // comboUnit
            // 
            this.comboUnit.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comboUnit.FormattingEnabled = true;
            this.comboUnit.Location = new System.Drawing.Point(312, 515);
            this.comboUnit.Name = "comboUnit";
            this.comboUnit.Size = new System.Drawing.Size(266, 42);
            this.comboUnit.TabIndex = 13;
            this.comboUnit.SelectedIndexChanged += new System.EventHandler(this.comboUnit_TextUpdate);
            this.comboUnit.TextUpdate += new System.EventHandler(this.comboUnit_TextUpdate);
            // 
            // labelPPLX
            // 
            this.labelPPLX.AutoSize = true;
            this.labelPPLX.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPPLX.Location = new System.Drawing.Point(222, 573);
            this.labelPPLX.Name = "labelPPLX";
            this.labelPPLX.Size = new System.Drawing.Size(79, 34);
            this.labelPPLX.TabIndex = 12;
            this.labelPPLX.Text = "PPLX";
            this.labelPPLX.SizeChanged += new System.EventHandler(this.labels_SizeChanged);
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUnit.Location = new System.Drawing.Point(222, 523);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(70, 34);
            this.labelUnit.TabIndex = 11;
            this.labelUnit.Text = "UNIT";
            this.labelUnit.SizeChanged += new System.EventHandler(this.labels_SizeChanged);
            // 
            // comboTERX
            // 
            this.comboTERX.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comboTERX.FormattingEnabled = true;
            this.comboTERX.Location = new System.Drawing.Point(312, 663);
            this.comboTERX.Name = "comboTERX";
            this.comboTERX.Size = new System.Drawing.Size(266, 42);
            this.comboTERX.TabIndex = 18;
            this.comboTERX.SelectedIndexChanged += new System.EventHandler(this.comboTERX_TextUpdate);
            this.comboTERX.TextUpdate += new System.EventHandler(this.comboTERX_TextUpdate);
            // 
            // comboTTRX
            // 
            this.comboTTRX.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comboTTRX.FormattingEnabled = true;
            this.comboTTRX.Location = new System.Drawing.Point(312, 613);
            this.comboTTRX.Name = "comboTTRX";
            this.comboTTRX.Size = new System.Drawing.Size(266, 42);
            this.comboTTRX.TabIndex = 17;
            this.comboTTRX.SelectedIndexChanged += new System.EventHandler(this.comboTTRX_TextUpdate);
            this.comboTTRX.TextUpdate += new System.EventHandler(this.comboTTRX_TextUpdate);
            // 
            // labelTERX
            // 
            this.labelTERX.AutoSize = true;
            this.labelTERX.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTERX.Location = new System.Drawing.Point(222, 671);
            this.labelTERX.Name = "labelTERX";
            this.labelTERX.Size = new System.Drawing.Size(75, 34);
            this.labelTERX.TabIndex = 16;
            this.labelTERX.Text = "TERX";
            this.labelTERX.SizeChanged += new System.EventHandler(this.labels_SizeChanged);
            // 
            // labelTTRX
            // 
            this.labelTTRX.AutoSize = true;
            this.labelTTRX.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTTRX.Location = new System.Drawing.Point(222, 621);
            this.labelTTRX.Name = "labelTTRX";
            this.labelTTRX.Size = new System.Drawing.Size(71, 34);
            this.labelTTRX.TabIndex = 15;
            this.labelTTRX.Text = "TTRX";
            this.labelTTRX.SizeChanged += new System.EventHandler(this.labels_SizeChanged);
            // 
            // comboProfile
            // 
            this.comboProfile.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comboProfile.FormattingEnabled = true;
            this.comboProfile.Location = new System.Drawing.Point(312, 761);
            this.comboProfile.Name = "comboProfile";
            this.comboProfile.Size = new System.Drawing.Size(266, 42);
            this.comboProfile.TabIndex = 22;
            this.comboProfile.SelectedIndexChanged += new System.EventHandler(this.comboProfile_TextUpdate);
            this.comboProfile.TextUpdate += new System.EventHandler(this.comboProfile_TextUpdate);
            // 
            // comboNewsItems
            // 
            this.comboNewsItems.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comboNewsItems.FormattingEnabled = true;
            this.comboNewsItems.Location = new System.Drawing.Point(312, 711);
            this.comboNewsItems.Name = "comboNewsItems";
            this.comboNewsItems.Size = new System.Drawing.Size(266, 42);
            this.comboNewsItems.TabIndex = 21;
            this.comboNewsItems.SelectedIndexChanged += new System.EventHandler(this.comboNewsItems_TextUpdate);
            this.comboNewsItems.TextUpdate += new System.EventHandler(this.comboNewsItems_TextUpdate);
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProfile.Location = new System.Drawing.Point(171, 764);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(121, 34);
            this.labelProfile.TabIndex = 20;
            this.labelProfile.Text = "PROFILE";
            this.labelProfile.SizeChanged += new System.EventHandler(this.labels_SizeChanged);
            // 
            // labelNewsItems
            // 
            this.labelNewsItems.AutoSize = true;
            this.labelNewsItems.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNewsItems.Location = new System.Drawing.Point(134, 719);
            this.labelNewsItems.Name = "labelNewsItems";
            this.labelNewsItems.Size = new System.Drawing.Size(163, 34);
            this.labelNewsItems.TabIndex = 19;
            this.labelNewsItems.Text = "NEWSITEMS";
            this.labelNewsItems.SizeChanged += new System.EventHandler(this.labels_SizeChanged);
            // 
            // comboPostCache
            // 
            this.comboPostCache.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comboPostCache.FormattingEnabled = true;
            this.comboPostCache.Location = new System.Drawing.Point(1201, 706);
            this.comboPostCache.Name = "comboPostCache";
            this.comboPostCache.Size = new System.Drawing.Size(266, 42);
            this.comboPostCache.TabIndex = 35;
            this.comboPostCache.SelectedIndexChanged += new System.EventHandler(this.comboPostCache_TextUpdate);
            this.comboPostCache.TextUpdate += new System.EventHandler(this.comboPostCache_TextUpdate);
            // 
            // labelPostCache
            // 
            this.labelPostCache.AutoSize = true;
            this.labelPostCache.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPostCache.Location = new System.Drawing.Point(1015, 709);
            this.labelPostCache.Name = "labelPostCache";
            this.labelPostCache.Size = new System.Drawing.Size(174, 34);
            this.labelPostCache.TabIndex = 33;
            this.labelPostCache.Text = "Post Cache";
            this.labelPostCache.SizeChanged += new System.EventHandler(this.labels_SizeChanged);
            // 
            // comboPreCache
            // 
            this.comboPreCache.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comboPreCache.FormattingEnabled = true;
            this.comboPreCache.Location = new System.Drawing.Point(1201, 658);
            this.comboPreCache.Name = "comboPreCache";
            this.comboPreCache.Size = new System.Drawing.Size(266, 42);
            this.comboPreCache.TabIndex = 32;
            this.comboPreCache.SelectedIndexChanged += new System.EventHandler(this.comboPreCache_TextUpdate);
            this.comboPreCache.TextUpdate += new System.EventHandler(this.comboPreCache_TextUpdate);
            // 
            // comboOOB
            // 
            this.comboOOB.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comboOOB.FormattingEnabled = true;
            this.comboOOB.Location = new System.Drawing.Point(1201, 608);
            this.comboOOB.Name = "comboOOB";
            this.comboOOB.Size = new System.Drawing.Size(266, 42);
            this.comboOOB.TabIndex = 31;
            this.comboOOB.SelectedIndexChanged += new System.EventHandler(this.comboOOB_TextUpdate);
            this.comboOOB.TextUpdate += new System.EventHandler(this.comboOOB_TextUpdate);
            // 
            // labelPreCache
            // 
            this.labelPreCache.AutoSize = true;
            this.labelPreCache.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPreCache.Location = new System.Drawing.Point(1027, 661);
            this.labelPreCache.Name = "labelPreCache";
            this.labelPreCache.Size = new System.Drawing.Size(162, 34);
            this.labelPreCache.TabIndex = 30;
            this.labelPreCache.Text = "Pre-Cache";
            this.labelPreCache.SizeChanged += new System.EventHandler(this.labels_SizeChanged);
            // 
            // labelOOB
            // 
            this.labelOOB.AutoSize = true;
            this.labelOOB.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOOB.Location = new System.Drawing.Point(1109, 613);
            this.labelOOB.Name = "labelOOB";
            this.labelOOB.Size = new System.Drawing.Size(79, 34);
            this.labelOOB.TabIndex = 29;
            this.labelOOB.Text = "OOB";
            this.labelOOB.SizeChanged += new System.EventHandler(this.labels_SizeChanged);
            // 
            // comboWM
            // 
            this.comboWM.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comboWM.FormattingEnabled = true;
            this.comboWM.Location = new System.Drawing.Point(1201, 560);
            this.comboWM.Name = "comboWM";
            this.comboWM.Size = new System.Drawing.Size(266, 42);
            this.comboWM.TabIndex = 28;
            this.comboWM.SelectedIndexChanged += new System.EventHandler(this.comboWM_TextUpdate);
            this.comboWM.TextUpdate += new System.EventHandler(this.comboWM_TextUpdate);
            // 
            // comboCVP
            // 
            this.comboCVP.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.comboCVP.FormattingEnabled = true;
            this.comboCVP.Location = new System.Drawing.Point(1201, 510);
            this.comboCVP.Name = "comboCVP";
            this.comboCVP.Size = new System.Drawing.Size(266, 42);
            this.comboCVP.TabIndex = 27;
            this.comboCVP.SelectedIndexChanged += new System.EventHandler(this.comboCVP_TextUpdate);
            this.comboCVP.TextUpdate += new System.EventHandler(this.comboCVP_TextUpdate);
            // 
            // labelWM
            // 
            this.labelWM.AutoSize = true;
            this.labelWM.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWM.Location = new System.Drawing.Point(1053, 563);
            this.labelWM.Name = "labelWM";
            this.labelWM.Size = new System.Drawing.Size(136, 34);
            this.labelWM.TabIndex = 26;
            this.labelWM.Text = "WMData";
            this.labelWM.SizeChanged += new System.EventHandler(this.labels_SizeChanged);
            // 
            // labelCVP
            // 
            this.labelCVP.AutoSize = true;
            this.labelCVP.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCVP.Location = new System.Drawing.Point(1112, 515);
            this.labelCVP.Name = "labelCVP";
            this.labelCVP.Size = new System.Drawing.Size(76, 34);
            this.labelCVP.TabIndex = 25;
            this.labelCVP.Text = "CVP";
            this.labelCVP.SizeChanged += new System.EventHandler(this.labels_SizeChanged);
            // 
            // checkModifyCVP
            // 
            this.checkModifyCVP.AutoSize = true;
            this.checkModifyCVP.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkModifyCVP.Location = new System.Drawing.Point(1496, 522);
            this.checkModifyCVP.Name = "checkModifyCVP";
            this.checkModifyCVP.Size = new System.Drawing.Size(100, 27);
            this.checkModifyCVP.TabIndex = 37;
            this.checkModifyCVP.Text = "Modify";
            this.checkModifyCVP.UseVisualStyleBackColor = true;
            this.checkModifyCVP.CheckedChanged += new System.EventHandler(this.checkModifyCVP_CheckedChanged);
            // 
            // checkModifyWM
            // 
            this.checkModifyWM.AutoSize = true;
            this.checkModifyWM.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkModifyWM.Location = new System.Drawing.Point(1496, 572);
            this.checkModifyWM.Name = "checkModifyWM";
            this.checkModifyWM.Size = new System.Drawing.Size(100, 27);
            this.checkModifyWM.TabIndex = 36;
            this.checkModifyWM.Text = "Modify";
            this.checkModifyWM.UseVisualStyleBackColor = true;
            this.checkModifyWM.CheckedChanged += new System.EventHandler(this.checkModifyWM_CheckedChanged);
            // 
            // checkModifyOOB
            // 
            this.checkModifyOOB.AutoSize = true;
            this.checkModifyOOB.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkModifyOOB.Location = new System.Drawing.Point(1496, 620);
            this.checkModifyOOB.Name = "checkModifyOOB";
            this.checkModifyOOB.Size = new System.Drawing.Size(100, 27);
            this.checkModifyOOB.TabIndex = 38;
            this.checkModifyOOB.Text = "Modify";
            this.checkModifyOOB.UseVisualStyleBackColor = true;
            this.checkModifyOOB.CheckedChanged += new System.EventHandler(this.checkModifyOOB_CheckedChanged);
            // 
            // checkNoneditDefault
            // 
            this.checkNoneditDefault.AutoSize = true;
            this.checkNoneditDefault.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkNoneditDefault.Location = new System.Drawing.Point(312, 471);
            this.checkNoneditDefault.Name = "checkNoneditDefault";
            this.checkNoneditDefault.Size = new System.Drawing.Size(193, 27);
            this.checkNoneditDefault.TabIndex = 39;
            this.checkNoneditDefault.Text = "Use Default Files";
            this.checkNoneditDefault.UseVisualStyleBackColor = true;
            this.checkNoneditDefault.CheckedChanged += new System.EventHandler(this.checkNoneditDefault_CheckedChanged);
            // 
            // labelGeneralInformation
            // 
            this.labelGeneralInformation.AutoSize = true;
            this.labelGeneralInformation.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.labelGeneralInformation.Location = new System.Drawing.Point(290, 69);
            this.labelGeneralInformation.Name = "labelGeneralInformation";
            this.labelGeneralInformation.Size = new System.Drawing.Size(326, 38);
            this.labelGeneralInformation.TabIndex = 41;
            this.labelGeneralInformation.Text = "General Information";
            // 
            // labelMapFiles
            // 
            this.labelMapFiles.AutoSize = true;
            this.labelMapFiles.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMapFiles.Location = new System.Drawing.Point(1272, 69);
            this.labelMapFiles.Name = "labelMapFiles";
            this.labelMapFiles.Size = new System.Drawing.Size(162, 38);
            this.labelMapFiles.TabIndex = 42;
            this.labelMapFiles.Text = "Map Files";
            // 
            // labelNonEditableData
            // 
            this.labelNonEditableData.AutoSize = true;
            this.labelNonEditableData.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.labelNonEditableData.Location = new System.Drawing.Point(199, 409);
            this.labelNonEditableData.Name = "labelNonEditableData";
            this.labelNonEditableData.Size = new System.Drawing.Size(379, 38);
            this.labelNonEditableData.TabIndex = 43;
            this.labelNonEditableData.Text = "Non-editable Data Files";
            // 
            // labelEditableData
            // 
            this.labelEditableData.AutoSize = true;
            this.labelEditableData.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.labelEditableData.Location = new System.Drawing.Point(1178, 442);
            this.labelEditableData.Name = "labelEditableData";
            this.labelEditableData.Size = new System.Drawing.Size(300, 38);
            this.labelEditableData.TabIndex = 44;
            this.labelEditableData.Text = "Editable Data Files";
            // 
            // labelRequiredScenarioName
            // 
            this.labelRequiredScenarioName.AutoSize = true;
            this.labelRequiredScenarioName.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRequiredScenarioName.ForeColor = System.Drawing.Color.Red;
            this.labelRequiredScenarioName.Location = new System.Drawing.Point(32, 141);
            this.labelRequiredScenarioName.Name = "labelRequiredScenarioName";
            this.labelRequiredScenarioName.Size = new System.Drawing.Size(53, 34);
            this.labelRequiredScenarioName.TabIndex = 45;
            this.labelRequiredScenarioName.Text = "(R)";
            // 
            // labelRequiredCacheName
            // 
            this.labelRequiredCacheName.AutoSize = true;
            this.labelRequiredCacheName.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRequiredCacheName.ForeColor = System.Drawing.Color.Red;
            this.labelRequiredCacheName.Location = new System.Drawing.Point(55, 189);
            this.labelRequiredCacheName.Name = "labelRequiredCacheName";
            this.labelRequiredCacheName.Size = new System.Drawing.Size(53, 34);
            this.labelRequiredCacheName.TabIndex = 46;
            this.labelRequiredCacheName.Text = "(R)";
            // 
            // labelRequiredMapName
            // 
            this.labelRequiredMapName.AutoSize = true;
            this.labelRequiredMapName.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRequiredMapName.ForeColor = System.Drawing.Color.Red;
            this.labelRequiredMapName.Location = new System.Drawing.Point(974, 142);
            this.labelRequiredMapName.Name = "labelRequiredMapName";
            this.labelRequiredMapName.Size = new System.Drawing.Size(53, 34);
            this.labelRequiredMapName.TabIndex = 47;
            this.labelRequiredMapName.Text = "(R)";
            // 
            // labelRequiredOOF
            // 
            this.labelRequiredOOF.AutoSize = true;
            this.labelRequiredOOF.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRequiredOOF.ForeColor = System.Drawing.Color.Red;
            this.labelRequiredOOF.Location = new System.Drawing.Point(1065, 192);
            this.labelRequiredOOF.Name = "labelRequiredOOF";
            this.labelRequiredOOF.Size = new System.Drawing.Size(53, 34);
            this.labelRequiredOOF.TabIndex = 48;
            this.labelRequiredOOF.Text = "(R)";
            // 
            // labelRequiredCVP
            // 
            this.labelRequiredCVP.AutoSize = true;
            this.labelRequiredCVP.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRequiredCVP.ForeColor = System.Drawing.Color.Red;
            this.labelRequiredCVP.Location = new System.Drawing.Point(1065, 516);
            this.labelRequiredCVP.Name = "labelRequiredCVP";
            this.labelRequiredCVP.Size = new System.Drawing.Size(53, 34);
            this.labelRequiredCVP.TabIndex = 49;
            this.labelRequiredCVP.Text = "(R)";
            // 
            // labelRequiredWM
            // 
            this.labelRequiredWM.AutoSize = true;
            this.labelRequiredWM.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRequiredWM.ForeColor = System.Drawing.Color.Red;
            this.labelRequiredWM.Location = new System.Drawing.Point(1003, 563);
            this.labelRequiredWM.Name = "labelRequiredWM";
            this.labelRequiredWM.Size = new System.Drawing.Size(53, 34);
            this.labelRequiredWM.TabIndex = 50;
            this.labelRequiredWM.Text = "(R)";
            // 
            // labelRequiredUnit
            // 
            this.labelRequiredUnit.AutoSize = true;
            this.labelRequiredUnit.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRequiredUnit.ForeColor = System.Drawing.Color.Red;
            this.labelRequiredUnit.Location = new System.Drawing.Point(171, 524);
            this.labelRequiredUnit.Name = "labelRequiredUnit";
            this.labelRequiredUnit.Size = new System.Drawing.Size(53, 34);
            this.labelRequiredUnit.TabIndex = 52;
            this.labelRequiredUnit.Text = "(R)";
            // 
            // labelRequiredPPLX
            // 
            this.labelRequiredPPLX.AutoSize = true;
            this.labelRequiredPPLX.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRequiredPPLX.ForeColor = System.Drawing.Color.Red;
            this.labelRequiredPPLX.Location = new System.Drawing.Point(171, 573);
            this.labelRequiredPPLX.Name = "labelRequiredPPLX";
            this.labelRequiredPPLX.Size = new System.Drawing.Size(53, 34);
            this.labelRequiredPPLX.TabIndex = 53;
            this.labelRequiredPPLX.Text = "(R)";
            // 
            // labelRequiredTTRX
            // 
            this.labelRequiredTTRX.AutoSize = true;
            this.labelRequiredTTRX.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRequiredTTRX.ForeColor = System.Drawing.Color.Red;
            this.labelRequiredTTRX.Location = new System.Drawing.Point(171, 622);
            this.labelRequiredTTRX.Name = "labelRequiredTTRX";
            this.labelRequiredTTRX.Size = new System.Drawing.Size(53, 34);
            this.labelRequiredTTRX.TabIndex = 54;
            this.labelRequiredTTRX.Text = "(R)";
            // 
            // labelRequiredTERX
            // 
            this.labelRequiredTERX.AutoSize = true;
            this.labelRequiredTERX.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRequiredTERX.ForeColor = System.Drawing.Color.Red;
            this.labelRequiredTERX.Location = new System.Drawing.Point(171, 672);
            this.labelRequiredTERX.Name = "labelRequiredTERX";
            this.labelRequiredTERX.Size = new System.Drawing.Size(53, 34);
            this.labelRequiredTERX.TabIndex = 55;
            this.labelRequiredTERX.Text = "(R)";
            // 
            // labelRequiredNewsItems
            // 
            this.labelRequiredNewsItems.AutoSize = true;
            this.labelRequiredNewsItems.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRequiredNewsItems.ForeColor = System.Drawing.Color.Red;
            this.labelRequiredNewsItems.Location = new System.Drawing.Point(80, 720);
            this.labelRequiredNewsItems.Name = "labelRequiredNewsItems";
            this.labelRequiredNewsItems.Size = new System.Drawing.Size(53, 34);
            this.labelRequiredNewsItems.TabIndex = 56;
            this.labelRequiredNewsItems.Text = "(R)";
            // 
            // labelRequiredProfile
            // 
            this.labelRequiredProfile.AutoSize = true;
            this.labelRequiredProfile.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRequiredProfile.ForeColor = System.Drawing.Color.Red;
            this.labelRequiredProfile.Location = new System.Drawing.Point(112, 765);
            this.labelRequiredProfile.Name = "labelRequiredProfile";
            this.labelRequiredProfile.Size = new System.Drawing.Size(53, 34);
            this.labelRequiredProfile.TabIndex = 57;
            this.labelRequiredProfile.Text = "(R)";
            // 
            // labelRequiredInfo
            // 
            this.labelRequiredInfo.AutoSize = true;
            this.labelRequiredInfo.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRequiredInfo.ForeColor = System.Drawing.Color.Red;
            this.labelRequiredInfo.Location = new System.Drawing.Point(1304, 837);
            this.labelRequiredInfo.Name = "labelRequiredInfo";
            this.labelRequiredInfo.Size = new System.Drawing.Size(371, 34);
            this.labelRequiredInfo.TabIndex = 58;
            this.labelRequiredInfo.Text = "(R) -- Required to Proceed";
            // 
            // UC_Scenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelRequiredInfo);
            this.Controls.Add(this.labelRequiredProfile);
            this.Controls.Add(this.labelRequiredNewsItems);
            this.Controls.Add(this.labelRequiredTERX);
            this.Controls.Add(this.labelRequiredTTRX);
            this.Controls.Add(this.labelRequiredPPLX);
            this.Controls.Add(this.labelRequiredUnit);
            this.Controls.Add(this.labelRequiredWM);
            this.Controls.Add(this.labelRequiredCVP);
            this.Controls.Add(this.labelRequiredOOF);
            this.Controls.Add(this.labelRequiredMapName);
            this.Controls.Add(this.labelRequiredCacheName);
            this.Controls.Add(this.labelRequiredScenarioName);
            this.Controls.Add(this.labelEditableData);
            this.Controls.Add(this.labelNonEditableData);
            this.Controls.Add(this.labelMapFiles);
            this.Controls.Add(this.labelGeneralInformation);
            this.Controls.Add(this.checkNoneditDefault);
            this.Controls.Add(this.checkModifyOOB);
            this.Controls.Add(this.checkModifyCVP);
            this.Controls.Add(this.checkModifyWM);
            this.Controls.Add(this.comboPostCache);
            this.Controls.Add(this.labelPostCache);
            this.Controls.Add(this.comboPreCache);
            this.Controls.Add(this.comboOOB);
            this.Controls.Add(this.labelPreCache);
            this.Controls.Add(this.labelOOB);
            this.Controls.Add(this.comboWM);
            this.Controls.Add(this.comboCVP);
            this.Controls.Add(this.labelWM);
            this.Controls.Add(this.labelCVP);
            this.Controls.Add(this.comboProfile);
            this.Controls.Add(this.comboNewsItems);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.labelNewsItems);
            this.Controls.Add(this.comboTERX);
            this.Controls.Add(this.comboTTRX);
            this.Controls.Add(this.labelTERX);
            this.Controls.Add(this.labelTTRX);
            this.Controls.Add(this.comboPPLX);
            this.Controls.Add(this.comboUnit);
            this.Controls.Add(this.labelPPLX);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.checkNewMap);
            this.Controls.Add(this.checkOOF);
            this.Controls.Add(this.comboOOF);
            this.Controls.Add(this.comboMapName);
            this.Controls.Add(this.labelOOF);
            this.Controls.Add(this.labelMapName);
            this.Controls.Add(this.checkCacheName);
            this.Controls.Add(this.comboCacheName);
            this.Controls.Add(this.comboScenarioName);
            this.Controls.Add(this.labelCacheName);
            this.Controls.Add(this.labelScenarioName);
            this.Name = "UC_Scenario";
            this.Size = new System.Drawing.Size(1800, 1000);
            this.SizeChanged += new System.EventHandler(this.labels_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScenarioName;
        private System.Windows.Forms.Label labelCacheName;
        private System.Windows.Forms.ComboBox comboScenarioName;
        private System.Windows.Forms.ComboBox comboCacheName;
        private System.Windows.Forms.CheckBox checkCacheName;
        private System.Windows.Forms.CheckBox checkOOF;
        private System.Windows.Forms.ComboBox comboOOF;
        private System.Windows.Forms.ComboBox comboMapName;
        private System.Windows.Forms.Label labelOOF;
        private System.Windows.Forms.Label labelMapName;
        private System.Windows.Forms.CheckBox checkNewMap;
        private System.Windows.Forms.ComboBox comboPPLX;
        private System.Windows.Forms.ComboBox comboUnit;
        private System.Windows.Forms.Label labelPPLX;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.ComboBox comboTERX;
        private System.Windows.Forms.ComboBox comboTTRX;
        private System.Windows.Forms.Label labelTERX;
        private System.Windows.Forms.Label labelTTRX;
        private System.Windows.Forms.ComboBox comboProfile;
        private System.Windows.Forms.ComboBox comboNewsItems;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Label labelNewsItems;
        private System.Windows.Forms.ComboBox comboPostCache;
        private System.Windows.Forms.Label labelPostCache;
        private System.Windows.Forms.ComboBox comboPreCache;
        private System.Windows.Forms.ComboBox comboOOB;
        private System.Windows.Forms.Label labelPreCache;
        private System.Windows.Forms.Label labelOOB;
        private System.Windows.Forms.ComboBox comboWM;
        private System.Windows.Forms.ComboBox comboCVP;
        private System.Windows.Forms.Label labelWM;
        private System.Windows.Forms.Label labelCVP;
        private System.Windows.Forms.CheckBox checkModifyCVP;
        private System.Windows.Forms.CheckBox checkModifyWM;
        private System.Windows.Forms.CheckBox checkModifyOOB;
        private System.Windows.Forms.CheckBox checkNoneditDefault;
        private System.Windows.Forms.Label labelGeneralInformation;
        private System.Windows.Forms.Label labelMapFiles;
        private System.Windows.Forms.Label labelNonEditableData;
        private System.Windows.Forms.Label labelEditableData;
        private System.Windows.Forms.Label labelRequiredScenarioName;
        private System.Windows.Forms.Label labelRequiredCacheName;
        private System.Windows.Forms.Label labelRequiredMapName;
        private System.Windows.Forms.Label labelRequiredOOF;
        private System.Windows.Forms.Label labelRequiredCVP;
        private System.Windows.Forms.Label labelRequiredWM;
        private System.Windows.Forms.Label labelRequiredUnit;
        private System.Windows.Forms.Label labelRequiredPPLX;
        private System.Windows.Forms.Label labelRequiredTTRX;
        private System.Windows.Forms.Label labelRequiredTERX;
        private System.Windows.Forms.Label labelRequiredNewsItems;
        private System.Windows.Forms.Label labelRequiredProfile;
        private System.Windows.Forms.Label labelRequiredInfo;
    }
}
