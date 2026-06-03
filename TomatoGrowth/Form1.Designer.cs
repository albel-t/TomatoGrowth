namespace TomatoGrowth
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonTick = new System.Windows.Forms.Button();
            this.richTextBoxLogs = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelBranches = new System.Windows.Forms.Label();
            this.labelBushiness = new System.Windows.Forms.Label();
            this.labelCurlyMax = new System.Windows.Forms.Label();
            this.labelCurlyMin = new System.Windows.Forms.Label();
            this.labelDeviation = new System.Windows.Forms.Label();
            this.labelDyingOff = new System.Windows.Forms.Label();
            this.labelFade = new System.Windows.Forms.Label();
            this.labelFall = new System.Windows.Forms.Label();
            this.labelMaxLen = new System.Windows.Forms.Label();
            this.labelPlasticity = new System.Windows.Forms.Label();
            this.labelSlimness = new System.Windows.Forms.Label();
            this.labelStepMaxLen = new System.Windows.Forms.Label();
            this.labelStepMinLen = new System.Windows.Forms.Label();
            this.labelVegetation = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelYouth = new System.Windows.Forms.Label();
            this.textBoxBranches = new System.Windows.Forms.TextBox();
            this.textBoxBushiness = new System.Windows.Forms.TextBox();
            this.textBoxCurlyMax = new System.Windows.Forms.TextBox();
            this.textBoxCurlyMin = new System.Windows.Forms.TextBox();
            this.textBoxDeviation = new System.Windows.Forms.TextBox();
            this.textBoxDyingOff = new System.Windows.Forms.TextBox();
            this.textBoxFade = new System.Windows.Forms.TextBox();
            this.textBoxFall = new System.Windows.Forms.TextBox();
            this.textBoxMaxLen = new System.Windows.Forms.TextBox();
            this.textBoxPlasticity = new System.Windows.Forms.TextBox();
            this.textBoxSlimness = new System.Windows.Forms.TextBox();
            this.textBoxStepMaxLen = new System.Windows.Forms.TextBox();
            this.textBoxStepMinLen = new System.Windows.Forms.TextBox();
            this.textBoxStepX = new System.Windows.Forms.TextBox();
            this.textBoxStepY = new System.Windows.Forms.TextBox();
            this.textBoxTickPerClick = new System.Windows.Forms.TextBox();
            this.textBoxVegetation = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxYouth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 621);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(7, 16);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(104, 45);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(40, 22);
            this.buttonRun.TabIndex = 5;
            this.buttonRun.Text = "Run";
            this.buttonRun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonTick
            // 
            this.buttonTick.Location = new System.Drawing.Point(104, 16);
            this.buttonTick.Name = "buttonTick";
            this.buttonTick.Size = new System.Drawing.Size(75, 23);
            this.buttonTick.TabIndex = 5;
            this.buttonTick.Text = "Tick";
            this.buttonTick.UseVisualStyleBackColor = true;
            this.buttonTick.Click += new System.EventHandler(this.buttonTick_Click);
            // 
            // richTextBoxLogs
            // 
            this.richTextBoxLogs.Location = new System.Drawing.Point(513, 437);
            this.richTextBoxLogs.Name = "richTextBoxLogs";
            this.richTextBoxLogs.Size = new System.Drawing.Size(433, 214);
            this.richTextBoxLogs.TabIndex = 17;
            this.richTextBoxLogs.Text = "";
            // 
            // labelBranches
            // 
            this.labelBranches.AutoSize = true;
            this.labelBranches.Location = new System.Drawing.Point(9, 158);
            this.labelBranches.Name = "labelBranches";
            this.labelBranches.Size = new System.Drawing.Size(52, 13);
            this.labelBranches.TabIndex = 25;
            this.labelBranches.Text = "Branches";
            this.toolTip1.SetToolTip(this.labelBranches, "ВЕТВИ \nКоличество боковых ветвей (деток)");
            // 
            // labelBushiness
            // 
            this.labelBushiness.AutoSize = true;
            this.labelBushiness.Location = new System.Drawing.Point(15, 72);
            this.labelBushiness.Name = "labelBushiness";
            this.labelBushiness.Size = new System.Drawing.Size(55, 13);
            this.labelBushiness.TabIndex = 4;
            this.labelBushiness.Text = "Bushiness";
            this.toolTip1.SetToolTip(this.labelBushiness, "КУСТАРНОСТЬ \n(скорость отращивания боковых ветвей)");
            // 
            // labelCurlyMax
            // 
            this.labelCurlyMax.AutoSize = true;
            this.labelCurlyMax.Location = new System.Drawing.Point(18, 74);
            this.labelCurlyMax.Name = "labelCurlyMax";
            this.labelCurlyMax.Size = new System.Drawing.Size(50, 13);
            this.labelCurlyMax.TabIndex = 32;
            this.labelCurlyMax.Text = "CurlyMax";
            this.toolTip1.SetToolTip(this.labelCurlyMax, "МАКС.КУДРЯВОСТЬ \nМаксимальная изогнутость (деток) от центральной");
            // 
            // labelCurlyMin
            // 
            this.labelCurlyMin.AutoSize = true;
            this.labelCurlyMin.Location = new System.Drawing.Point(18, 48);
            this.labelCurlyMin.Name = "labelCurlyMin";
            this.labelCurlyMin.Size = new System.Drawing.Size(47, 13);
            this.labelCurlyMin.TabIndex = 7;
            this.labelCurlyMin.Text = "CurlyMin";
            this.toolTip1.SetToolTip(this.labelCurlyMin, "МИН.КУДРЯВОСТЬ \nМинимальная изогнутость (деток) от центральной");
            // 
            // labelDeviation
            // 
            this.labelDeviation.AutoSize = true;
            this.labelDeviation.Location = new System.Drawing.Point(18, 22);
            this.labelDeviation.Name = "labelDeviation";
            this.labelDeviation.Size = new System.Drawing.Size(52, 13);
            this.labelDeviation.TabIndex = 7;
            this.labelDeviation.Text = "Deviation";
            this.toolTip1.SetToolTip(this.labelDeviation, "ОТКЛОНЕНИЕ \nОтклонение направления роста главной ветки от прошлого звена");
            // 
            // labelDyingOff
            // 
            this.labelDyingOff.AutoSize = true;
            this.labelDyingOff.Location = new System.Drawing.Point(9, 80);
            this.labelDyingOff.Name = "labelDyingOff";
            this.labelDyingOff.Size = new System.Drawing.Size(48, 13);
            this.labelDyingOff.TabIndex = 7;
            this.labelDyingOff.Text = "DyingOff";
            this.toolTip1.SetToolTip(this.labelDyingOff, "ОТМИРАНИЕ \nВозраст окончания пассивной фазы, переход в фазу отмирания");
            // 
            // labelFade
            // 
            this.labelFade.AutoSize = true;
            this.labelFade.Location = new System.Drawing.Point(15, 20);
            this.labelFade.Name = "labelFade";
            this.labelFade.Size = new System.Drawing.Size(31, 13);
            this.labelFade.TabIndex = 19;
            this.labelFade.Text = "Fade";
            this.toolTip1.SetToolTip(this.labelFade, "УВЯДАНИЕ \nВероятность отмирания пассивных веток");
            // 
            // labelFall
            // 
            this.labelFall.AutoSize = true;
            this.labelFall.Location = new System.Drawing.Point(18, 152);
            this.labelFall.Name = "labelFall";
            this.labelFall.Size = new System.Drawing.Size(23, 13);
            this.labelFall.TabIndex = 32;
            this.labelFall.Text = "Fall";
            this.toolTip1.SetToolTip(this.labelFall, "ПАДЕНИЕ \nВероятность падения ветки");
            // 
            // labelMaxLen
            // 
            this.labelMaxLen.AutoSize = true;
            this.labelMaxLen.Location = new System.Drawing.Point(9, 28);
            this.labelMaxLen.Name = "labelMaxLen";
            this.labelMaxLen.Size = new System.Drawing.Size(45, 13);
            this.labelMaxLen.TabIndex = 2;
            this.labelMaxLen.Text = "MaxLen";
            this.toolTip1.SetToolTip(this.labelMaxLen, "МАКС.ДЛИННА \nМаксимальная длина от корня в ступенях");
            // 
            // labelPlasticity
            // 
            this.labelPlasticity.AutoSize = true;
            this.labelPlasticity.Location = new System.Drawing.Point(18, 178);
            this.labelPlasticity.Name = "labelPlasticity";
            this.labelPlasticity.Size = new System.Drawing.Size(48, 13);
            this.labelPlasticity.TabIndex = 32;
            this.labelPlasticity.Text = "Plasticity";
            this.toolTip1.SetToolTip(this.labelPlasticity, "ПЛАСТИЧНОСТЬ \nМаксимальное разовое отклонение от прошлого положения");
            // 
            // labelSlimness
            // 
            this.labelSlimness.AutoSize = true;
            this.labelSlimness.Location = new System.Drawing.Point(18, 100);
            this.labelSlimness.Name = "labelSlimness";
            this.labelSlimness.Size = new System.Drawing.Size(48, 13);
            this.labelSlimness.TabIndex = 22;
            this.labelSlimness.Text = "Slimness";
            this.toolTip1.SetToolTip(this.labelSlimness, "СТРОЙНОСТЬ \nТяга к солнцу 0 - против солнца, 100 - к солнцу");
            // 
            // labelStepMaxLen
            // 
            this.labelStepMaxLen.AutoSize = true;
            this.labelStepMaxLen.Location = new System.Drawing.Point(2, 106);
            this.labelStepMaxLen.Name = "labelStepMaxLen";
            this.labelStepMaxLen.Size = new System.Drawing.Size(67, 13);
            this.labelStepMaxLen.TabIndex = 35;
            this.labelStepMaxLen.Text = "StepMaxLen";
            this.toolTip1.SetToolTip(this.labelStepMaxLen, "МАКС.ДЛИН.ШАГА \nМаксимальная длина ступени");
            // 
            // labelStepMinLen
            // 
            this.labelStepMinLen.AutoSize = true;
            this.labelStepMinLen.Location = new System.Drawing.Point(2, 132);
            this.labelStepMinLen.Name = "labelStepMinLen";
            this.labelStepMinLen.Size = new System.Drawing.Size(64, 13);
            this.labelStepMinLen.TabIndex = 35;
            this.labelStepMinLen.Text = "StepMinLen";
            this.toolTip1.SetToolTip(this.labelStepMinLen, "МАКС.ДЛИН.ШАГА \nМинимальная длина ступени");
            // 
            // labelVegetation
            // 
            this.labelVegetation.AutoSize = true;
            this.labelVegetation.Location = new System.Drawing.Point(15, 46);
            this.labelVegetation.Name = "labelVegetation";
            this.labelVegetation.Size = new System.Drawing.Size(58, 13);
            this.labelVegetation.TabIndex = 11;
            this.labelVegetation.Text = "Vegetation";
            this.toolTip1.SetToolTip(this.labelVegetation, "ВЕГЕТАТИВНОСТЬ \nВероятность роста новых ветвей");
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(18, 126);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(41, 13);
            this.labelWeight.TabIndex = 32;
            this.labelWeight.Text = "Weight";
            this.toolTip1.SetToolTip(this.labelWeight, "ВЕС \nВлияние гравитации");
            // 
            // labelYouth
            // 
            this.labelYouth.AutoSize = true;
            this.labelYouth.Location = new System.Drawing.Point(9, 54);
            this.labelYouth.Name = "labelYouth";
            this.labelYouth.Size = new System.Drawing.Size(35, 13);
            this.labelYouth.TabIndex = 9;
            this.labelYouth.Text = "Youth";
            this.toolTip1.SetToolTip(this.labelYouth, "МОЛОДОСТЬ \nВозраст окончания роста, переход в пассивную фазу");
            // 
            // textBoxBranches
            // 
            this.textBoxBranches.Location = new System.Drawing.Point(75, 155);
            this.textBoxBranches.Name = "textBoxBranches";
            this.textBoxBranches.Size = new System.Drawing.Size(48, 20);
            this.textBoxBranches.TabIndex = 24;
            this.textBoxBranches.Text = "1";
            // 
            // textBoxBushiness
            // 
            this.textBoxBushiness.Location = new System.Drawing.Point(81, 69);
            this.textBoxBushiness.Name = "textBoxBushiness";
            this.textBoxBushiness.Size = new System.Drawing.Size(48, 20);
            this.textBoxBushiness.TabIndex = 3;
            this.textBoxBushiness.Text = "20";
            // 
            // textBoxCurlyMax
            // 
            this.textBoxCurlyMax.Location = new System.Drawing.Point(84, 71);
            this.textBoxCurlyMax.Name = "textBoxCurlyMax";
            this.textBoxCurlyMax.Size = new System.Drawing.Size(48, 20);
            this.textBoxCurlyMax.TabIndex = 31;
            this.textBoxCurlyMax.Text = "50";
            // 
            // textBoxCurlyMin
            // 
            this.textBoxCurlyMin.Location = new System.Drawing.Point(84, 45);
            this.textBoxCurlyMin.Name = "textBoxCurlyMin";
            this.textBoxCurlyMin.Size = new System.Drawing.Size(48, 20);
            this.textBoxCurlyMin.TabIndex = 31;
            this.textBoxCurlyMin.Text = "10";
            // 
            // textBoxDeviation
            // 
            this.textBoxDeviation.Location = new System.Drawing.Point(84, 19);
            this.textBoxDeviation.Name = "textBoxDeviation";
            this.textBoxDeviation.Size = new System.Drawing.Size(48, 20);
            this.textBoxDeviation.TabIndex = 31;
            this.textBoxDeviation.Text = "10";
            // 
            // textBoxDyingOff
            // 
            this.textBoxDyingOff.Location = new System.Drawing.Point(75, 77);
            this.textBoxDyingOff.Name = "textBoxDyingOff";
            this.textBoxDyingOff.Size = new System.Drawing.Size(48, 20);
            this.textBoxDyingOff.TabIndex = 6;
            this.textBoxDyingOff.Text = "8";
            // 
            // textBoxFade
            // 
            this.textBoxFade.Location = new System.Drawing.Point(81, 17);
            this.textBoxFade.Name = "textBoxFade";
            this.textBoxFade.Size = new System.Drawing.Size(48, 20);
            this.textBoxFade.TabIndex = 18;
            this.textBoxFade.Text = "1";
            // 
            // textBoxFall
            // 
            this.textBoxFall.Location = new System.Drawing.Point(84, 149);
            this.textBoxFall.Name = "textBoxFall";
            this.textBoxFall.Size = new System.Drawing.Size(48, 20);
            this.textBoxFall.TabIndex = 31;
            this.textBoxFall.Text = "1";
            // 
            // textBoxMaxLen
            // 
            this.textBoxMaxLen.Location = new System.Drawing.Point(75, 25);
            this.textBoxMaxLen.Name = "textBoxMaxLen";
            this.textBoxMaxLen.Size = new System.Drawing.Size(48, 20);
            this.textBoxMaxLen.TabIndex = 1;
            this.textBoxMaxLen.Text = "12";
            // 
            // textBoxPlasticity
            // 
            this.textBoxPlasticity.Location = new System.Drawing.Point(84, 175);
            this.textBoxPlasticity.Name = "textBoxPlasticity";
            this.textBoxPlasticity.Size = new System.Drawing.Size(48, 20);
            this.textBoxPlasticity.TabIndex = 31;
            this.textBoxPlasticity.Text = "8";
            // 
            // textBoxSlimness
            // 
            this.textBoxSlimness.Location = new System.Drawing.Point(84, 97);
            this.textBoxSlimness.Name = "textBoxSlimness";
            this.textBoxSlimness.Size = new System.Drawing.Size(48, 20);
            this.textBoxSlimness.TabIndex = 21;
            this.textBoxSlimness.Text = "70";
            // 
            // textBoxStepMaxLen
            // 
            this.textBoxStepMaxLen.Location = new System.Drawing.Point(75, 103);
            this.textBoxStepMaxLen.Name = "textBoxStepMaxLen";
            this.textBoxStepMaxLen.Size = new System.Drawing.Size(48, 20);
            this.textBoxStepMaxLen.TabIndex = 34;
            this.textBoxStepMaxLen.Text = "30";
            // 
            // textBoxStepMinLen
            // 
            this.textBoxStepMinLen.Location = new System.Drawing.Point(75, 129);
            this.textBoxStepMinLen.Name = "textBoxStepMinLen";
            this.textBoxStepMinLen.Size = new System.Drawing.Size(48, 20);
            this.textBoxStepMinLen.TabIndex = 34;
            this.textBoxStepMinLen.Text = "20";
            // 
            // textBoxStepX
            // 
            this.textBoxStepX.Location = new System.Drawing.Point(208, 4);
            this.textBoxStepX.Name = "textBoxStepX";
            this.textBoxStepX.Size = new System.Drawing.Size(48, 20);
            this.textBoxStepX.TabIndex = 27;
            this.textBoxStepX.Text = "200";
            // 
            // textBoxStepY
            // 
            this.textBoxStepY.Location = new System.Drawing.Point(2, 322);
            this.textBoxStepY.Name = "textBoxStepY";
            this.textBoxStepY.Size = new System.Drawing.Size(30, 20);
            this.textBoxStepY.TabIndex = 28;
            this.textBoxStepY.Text = "500";
            // 
            // textBoxTickPerClick
            // 
            this.textBoxTickPerClick.Location = new System.Drawing.Point(142, 46);
            this.textBoxTickPerClick.Name = "textBoxTickPerClick";
            this.textBoxTickPerClick.Size = new System.Drawing.Size(25, 20);
            this.textBoxTickPerClick.TabIndex = 34;
            this.textBoxTickPerClick.Text = "5";
            // 
            // textBoxVegetation
            // 
            this.textBoxVegetation.Location = new System.Drawing.Point(81, 43);
            this.textBoxVegetation.Name = "textBoxVegetation";
            this.textBoxVegetation.Size = new System.Drawing.Size(48, 20);
            this.textBoxVegetation.TabIndex = 10;
            this.textBoxVegetation.Text = "45";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(84, 123);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(48, 20);
            this.textBoxWeight.TabIndex = 31;
            this.textBoxWeight.Text = "20";
            // 
            // textBoxYouth
            // 
            this.textBoxYouth.Location = new System.Drawing.Point(75, 51);
            this.textBoxYouth.Name = "textBoxYouth";
            this.textBoxYouth.Size = new System.Drawing.Size(48, 20);
            this.textBoxYouth.TabIndex = 8;
            this.textBoxYouth.Text = "6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "bourgeon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "days";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(129, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "days";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(138, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(135, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(138, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(129, 158);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "branches";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 301);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Y";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(188, 7);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "X";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(138, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "%";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(129, 106);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(18, 13);
            this.label23.TabIndex = 36;
            this.label23.Text = "px";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(129, 132);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(18, 13);
            this.label26.TabIndex = 36;
            this.label26.Text = "px";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(138, 22);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(15, 13);
            this.label28.TabIndex = 16;
            this.label28.Text = "%";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(138, 126);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(15, 13);
            this.label30.TabIndex = 33;
            this.label30.Text = "%";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(138, 152);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(15, 13);
            this.label32.TabIndex = 33;
            this.label32.Text = "%";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(138, 178);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(15, 13);
            this.label34.TabIndex = 33;
            this.label34.Text = "%";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(166, 50);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(14, 13);
            this.label35.TabIndex = 36;
            this.label35.Text = "T";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "MaxAngle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "branches";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxYouth);
            this.groupBox1.Controls.Add(this.textBoxMaxLen);
            this.groupBox1.Controls.Add(this.labelMaxLen);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.textBoxDyingOff);
            this.groupBox1.Controls.Add(this.labelDyingOff);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.labelYouth);
            this.groupBox1.Controls.Add(this.labelStepMinLen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelStepMaxLen);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxStepMinLen);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxBranches);
            this.groupBox1.Controls.Add(this.textBoxStepMaxLen);
            this.groupBox1.Controls.Add(this.labelBranches);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(521, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 209);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Final values";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelBushiness);
            this.groupBox2.Controls.Add(this.textBoxBushiness);
            this.groupBox2.Controls.Add(this.textBoxVegetation);
            this.groupBox2.Controls.Add(this.labelVegetation);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxFade);
            this.groupBox2.Controls.Add(this.labelFade);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(521, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 98);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Growth";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxFall);
            this.groupBox3.Controls.Add(this.textBoxCurlyMax);
            this.groupBox3.Controls.Add(this.textBoxWeight);
            this.groupBox3.Controls.Add(this.labelCurlyMin);
            this.groupBox3.Controls.Add(this.textBoxPlasticity);
            this.groupBox3.Controls.Add(this.labelDeviation);
            this.groupBox3.Controls.Add(this.labelWeight);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.labelFall);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.labelPlasticity);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.textBoxCurlyMin);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.textBoxDeviation);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.labelCurlyMax);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.textBoxSlimness);
            this.groupBox3.Controls.Add(this.labelSlimness);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(727, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 209);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Divergent";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonGenerate);
            this.groupBox5.Controls.Add(this.buttonTick);
            this.groupBox5.Controls.Add(this.textBoxTickPerClick);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.buttonRun);
            this.groupBox5.Location = new System.Drawing.Point(727, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 148);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tools";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 663);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxStepY);
            this.Controls.Add(this.textBoxStepX);
            this.Controls.Add(this.richTextBoxLogs);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxMaxLen;
        private System.Windows.Forms.Label labelMaxLen;
        private System.Windows.Forms.Label labelBushiness;
        private System.Windows.Forms.TextBox textBoxBushiness;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelDyingOff;
        private System.Windows.Forms.TextBox textBoxDyingOff;
        private System.Windows.Forms.Label labelYouth;
        private System.Windows.Forms.TextBox textBoxYouth;
        private System.Windows.Forms.Label labelVegetation;
        private System.Windows.Forms.TextBox textBoxVegetation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBoxLogs;
        private System.Windows.Forms.Label labelCurlyMin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelFade;
        private System.Windows.Forms.TextBox textBoxFade;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelSlimness;
        private System.Windows.Forms.TextBox textBoxSlimness;
        private System.Windows.Forms.Button buttonTick;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelBranches;
        private System.Windows.Forms.TextBox textBoxBranches;
        private System.Windows.Forms.TextBox textBoxStepX;
        private System.Windows.Forms.TextBox textBoxStepY;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labelCurlyMax;
        private System.Windows.Forms.TextBox textBoxCurlyMax;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelStepMaxLen;
        private System.Windows.Forms.TextBox textBoxStepMaxLen;
        private System.Windows.Forms.TextBox textBoxStepMinLen;
        private System.Windows.Forms.Label labelStepMinLen;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxCurlyMin;
        private System.Windows.Forms.Label labelDeviation;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxDeviation;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxFall;
        private System.Windows.Forms.Label labelFall;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBoxPlasticity;
        private System.Windows.Forms.Label labelPlasticity;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textBoxTickPerClick;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

