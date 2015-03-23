namespace Talend2Chouette
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ImportationTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lab_Purge = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Lab_BaseDDimport = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lab_NbDeJour = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Chk_Purge = new System.Windows.Forms.CheckBox();
            this.progressImport = new System.Windows.Forms.ProgressBar();
            this.Btn_ValideImport = new System.Windows.Forms.Button();
            this.DateFin = new System.Windows.Forms.DateTimePicker();
            this.DateDebut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_OpenExport = new System.Windows.Forms.Button();
            this.Lab_Filename = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Lab_BaseDDExport = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lab_Format = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Txt_Filename = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Combo_Format = new System.Windows.Forms.ComboBox();
            this.progressExport = new System.Windows.Forms.ProgressBar();
            this.Btn_ValideExport = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Chk_Confirme = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_MiseEnProd = new System.Windows.Forms.Button();
            this.ImportationTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportationTab
            // 
            this.ImportationTab.Controls.Add(this.tabPage1);
            this.ImportationTab.Controls.Add(this.tabPage2);
            this.ImportationTab.Controls.Add(this.tabPage3);
            this.ImportationTab.Location = new System.Drawing.Point(12, 12);
            this.ImportationTab.Name = "ImportationTab";
            this.ImportationTab.SelectedIndex = 0;
            this.ImportationTab.Size = new System.Drawing.Size(433, 275);
            this.ImportationTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(425, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Import";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lab_Purge);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.Lab_BaseDDimport);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Lab_NbDeJour);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(219, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details :";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Lab_Purge
            // 
            this.Lab_Purge.AutoSize = true;
            this.Lab_Purge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Purge.Location = new System.Drawing.Point(70, 162);
            this.Lab_Purge.Name = "Lab_Purge";
            this.Lab_Purge.Size = new System.Drawing.Size(57, 17);
            this.Lab_Purge.TabIndex = 6;
            this.Lab_Purge.Text = "Purger";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "La base de donnée sera :";
            // 
            // Lab_BaseDDimport
            // 
            this.Lab_BaseDDimport.AutoSize = true;
            this.Lab_BaseDDimport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_BaseDDimport.Location = new System.Drawing.Point(60, 108);
            this.Lab_BaseDDimport.Name = "Lab_BaseDDimport";
            this.Lab_BaseDDimport.Size = new System.Drawing.Size(67, 17);
            this.Lab_BaseDDimport.TabIndex = 4;
            this.Lab_BaseDDimport.Text = "PréProd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "La base de donnée utilisée est :";
            // 
            // Lab_NbDeJour
            // 
            this.Lab_NbDeJour.AutoSize = true;
            this.Lab_NbDeJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_NbDeJour.Location = new System.Drawing.Point(60, 47);
            this.Lab_NbDeJour.Name = "Lab_NbDeJour";
            this.Lab_NbDeJour.Size = new System.Drawing.Size(67, 17);
            this.Lab_NbDeJour.TabIndex = 2;
            this.Lab_NbDeJour.Text = "0 Jours.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "L\'importation va porter sur  : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Chk_Purge);
            this.groupBox1.Controls.Add(this.progressImport);
            this.groupBox1.Controls.Add(this.Btn_ValideImport);
            this.groupBox1.Controls.Add(this.DateFin);
            this.groupBox1.Controls.Add(this.DateDebut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options :";
            // 
            // Chk_Purge
            // 
            this.Chk_Purge.AutoSize = true;
            this.Chk_Purge.Checked = true;
            this.Chk_Purge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_Purge.Location = new System.Drawing.Point(57, 130);
            this.Chk_Purge.Name = "Chk_Purge";
            this.Chk_Purge.Size = new System.Drawing.Size(94, 17);
            this.Chk_Purge.TabIndex = 6;
            this.Chk_Purge.Text = "Purger la base";
            this.Chk_Purge.UseVisualStyleBackColor = true;
            this.Chk_Purge.CheckedChanged += new System.EventHandler(this.Chk_Purge_CheckedChanged);
            // 
            // progressImport
            // 
            this.progressImport.Location = new System.Drawing.Point(6, 208);
            this.progressImport.Name = "progressImport";
            this.progressImport.Size = new System.Drawing.Size(188, 23);
            this.progressImport.TabIndex = 5;
            // 
            // Btn_ValideImport
            // 
            this.Btn_ValideImport.Font = new System.Drawing.Font("Calibri Light", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ValideImport.Location = new System.Drawing.Point(6, 162);
            this.Btn_ValideImport.Name = "Btn_ValideImport";
            this.Btn_ValideImport.Size = new System.Drawing.Size(188, 40);
            this.Btn_ValideImport.TabIndex = 4;
            this.Btn_ValideImport.Text = "Lancer l\'importation.";
            this.Btn_ValideImport.UseVisualStyleBackColor = true;
            this.Btn_ValideImport.Click += new System.EventHandler(this.Btn_ValideImport_Click);
            // 
            // DateFin
            // 
            this.DateFin.Location = new System.Drawing.Point(6, 94);
            this.DateFin.Name = "DateFin";
            this.DateFin.Size = new System.Drawing.Size(188, 20);
            this.DateFin.TabIndex = 3;
            this.DateFin.ValueChanged += new System.EventHandler(this.DateFin_ValueChanged);
            // 
            // DateDebut
            // 
            this.DateDebut.Location = new System.Drawing.Point(6, 44);
            this.DateDebut.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.DateDebut.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.Size = new System.Drawing.Size(188, 20);
            this.DateDebut.TabIndex = 2;
            this.DateDebut.ValueChanged += new System.EventHandler(this.DateDebut_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de Fin : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date de Début : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(425, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Export";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_OpenExport);
            this.groupBox3.Controls.Add(this.Lab_Filename);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.Lab_BaseDDExport);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.Lab_Format);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(219, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 237);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details :";
            // 
            // Btn_OpenExport
            // 
            this.Btn_OpenExport.Location = new System.Drawing.Point(19, 194);
            this.Btn_OpenExport.Name = "Btn_OpenExport";
            this.Btn_OpenExport.Size = new System.Drawing.Size(172, 37);
            this.Btn_OpenExport.TabIndex = 7;
            this.Btn_OpenExport.Text = "Ouvrir les exports existants";
            this.Btn_OpenExport.UseVisualStyleBackColor = true;
            this.Btn_OpenExport.Click += new System.EventHandler(this.Btn_OpenExport_Click);
            // 
            // Lab_Filename
            // 
            this.Lab_Filename.AutoSize = true;
            this.Lab_Filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Filename.Location = new System.Drawing.Point(16, 171);
            this.Lab_Filename.Name = "Lab_Filename";
            this.Lab_Filename.Size = new System.Drawing.Size(155, 15);
            this.Lab_Filename.TabIndex = 6;
            this.Lab_Filename.Text = "090215-ExportNeptune";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Le fichier exporté sera :";
            // 
            // Lab_BaseDDExport
            // 
            this.Lab_BaseDDExport.AutoSize = true;
            this.Lab_BaseDDExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_BaseDDExport.Location = new System.Drawing.Point(60, 105);
            this.Lab_BaseDDExport.Name = "Lab_BaseDDExport";
            this.Lab_BaseDDExport.Size = new System.Drawing.Size(86, 17);
            this.Lab_BaseDDExport.TabIndex = 4;
            this.Lab_BaseDDExport.Text = "Production";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "La base de donnée utilisée est :";
            // 
            // Lab_Format
            // 
            this.Lab_Format.AutoSize = true;
            this.Lab_Format.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Format.Location = new System.Drawing.Point(60, 47);
            this.Lab_Format.Name = "Lab_Format";
            this.Lab_Format.Size = new System.Drawing.Size(0, 17);
            this.Lab_Format.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Le Format de l\'exportation sera :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Txt_Filename);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.Combo_Format);
            this.groupBox4.Controls.Add(this.progressExport);
            this.groupBox4.Controls.Add(this.Btn_ValideExport);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 237);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options :";
            // 
            // Txt_Filename
            // 
            this.Txt_Filename.Location = new System.Drawing.Point(6, 105);
            this.Txt_Filename.Name = "Txt_Filename";
            this.Txt_Filename.Size = new System.Drawing.Size(188, 20);
            this.Txt_Filename.TabIndex = 8;
            this.Txt_Filename.Text = "ExportNeptune";
            this.Txt_Filename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Filename.Leave += new System.EventHandler(this.Txt_Filename_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Nom du fichier exporté :";
            // 
            // Combo_Format
            // 
            this.Combo_Format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Format.FormattingEnabled = true;
            this.Combo_Format.Items.AddRange(new object[] {
            "NEPTUNE"});
            this.Combo_Format.Location = new System.Drawing.Point(0, 44);
            this.Combo_Format.Name = "Combo_Format";
            this.Combo_Format.Size = new System.Drawing.Size(194, 21);
            this.Combo_Format.TabIndex = 6;
            this.Combo_Format.SelectedIndexChanged += new System.EventHandler(this.Combo_Format_SelectedIndexChanged);
            // 
            // progressExport
            // 
            this.progressExport.Location = new System.Drawing.Point(6, 194);
            this.progressExport.Name = "progressExport";
            this.progressExport.Size = new System.Drawing.Size(188, 23);
            this.progressExport.TabIndex = 5;
            // 
            // Btn_ValideExport
            // 
            this.Btn_ValideExport.Font = new System.Drawing.Font("Calibri Light", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ValideExport.Location = new System.Drawing.Point(6, 148);
            this.Btn_ValideExport.Name = "Btn_ValideExport";
            this.Btn_ValideExport.Size = new System.Drawing.Size(188, 40);
            this.Btn_ValideExport.TabIndex = 4;
            this.Btn_ValideExport.Text = "Lancer l\'exportation.";
            this.Btn_ValideExport.UseVisualStyleBackColor = true;
            this.Btn_ValideExport.Click += new System.EventHandler(this.Btn_ValideExport_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Format d\'export :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(425, 249);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mise en Production";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Chk_Confirme);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.Btn_MiseEnProd);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(413, 237);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " ";
            // 
            // Chk_Confirme
            // 
            this.Chk_Confirme.AutoSize = true;
            this.Chk_Confirme.Location = new System.Drawing.Point(127, 132);
            this.Chk_Confirme.Name = "Chk_Confirme";
            this.Chk_Confirme.Size = new System.Drawing.Size(209, 17);
            this.Chk_Confirme.TabIndex = 6;
            this.Chk_Confirme.Text = "Cochez moi pour dévérouiller le bouton";
            this.Chk_Confirme.UseVisualStyleBackColor = true;
            this.Chk_Confirme.CheckedChanged += new System.EventHandler(this.Chk_Confirme_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(124, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(187, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "- La mise en production est irréversible";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(247, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "- La base de \"Production\" actuelle sera supprimée.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "- Une \"Pré-Prod\" doit exister.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Voici les détails :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pour la mise en Production, cliquer sur le bouton \"Mise en Production\"";
            // 
            // Btn_MiseEnProd
            // 
            this.Btn_MiseEnProd.Enabled = false;
            this.Btn_MiseEnProd.Location = new System.Drawing.Point(6, 155);
            this.Btn_MiseEnProd.Name = "Btn_MiseEnProd";
            this.Btn_MiseEnProd.Size = new System.Drawing.Size(401, 38);
            this.Btn_MiseEnProd.TabIndex = 0;
            this.Btn_MiseEnProd.Text = "- Mise En Production -";
            this.Btn_MiseEnProd.UseVisualStyleBackColor = true;
            this.Btn_MiseEnProd.Click += new System.EventHandler(this.Btn_MiseEnProd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 299);
            this.Controls.Add(this.ImportationTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "~~ Talend2Chouette~~";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ImportationTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ImportationTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lab_NbDeJour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressImport;
        private System.Windows.Forms.Button Btn_ValideImport;
        private System.Windows.Forms.DateTimePicker DateFin;
        private System.Windows.Forms.DateTimePicker DateDebut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lab_BaseDDimport;
        private System.Windows.Forms.Label Lab_Purge;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox Chk_Purge;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Lab_BaseDDExport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lab_Format;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox Combo_Format;
        private System.Windows.Forms.ProgressBar progressExport;
        private System.Windows.Forms.Button Btn_ValideExport;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Lab_Filename;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Txt_Filename;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_OpenExport;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_MiseEnProd;
        private System.Windows.Forms.CheckBox Chk_Confirme;
        private System.Windows.Forms.Label label14;
    }
}

