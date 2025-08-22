namespace WeatherApp
{
	partial class WeatherForecast
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
			this.cityNameTxt = new System.Windows.Forms.TextBox();
			this.enterCityLbl = new System.Windows.Forms.Label();
			this.weatherSearchBtn = new System.Windows.Forms.Button();
			this.cityNameLbl = new System.Windows.Forms.Label();
			this.temperatureLbl = new System.Windows.Forms.Label();
			this.descriptionLbl = new System.Windows.Forms.Label();
			this.humidityLbl = new System.Windows.Forms.Label();
			this.windSpeedLbl = new System.Windows.Forms.Label();
			this.weatherIcon = new System.Windows.Forms.PictureBox();
			this.welcomeLbl = new System.Windows.Forms.Label();
			this.displayCityName = new System.Windows.Forms.Label();
			this.displayTemperature = new System.Windows.Forms.Label();
			this.displayDescription = new System.Windows.Forms.Label();
			this.displayHumidity = new System.Windows.Forms.Label();
			this.displayWindSpeed = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cityNameTxt
			// 
			this.cityNameTxt.Location = new System.Drawing.Point(306, 71);
			this.cityNameTxt.Name = "cityNameTxt";
			this.cityNameTxt.Size = new System.Drawing.Size(146, 20);
			this.cityNameTxt.TabIndex = 0;
			// 
			// enterCityLbl
			// 
			this.enterCityLbl.AutoSize = true;
			this.enterCityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.enterCityLbl.Location = new System.Drawing.Point(268, 48);
			this.enterCityLbl.Name = "enterCityLbl";
			this.enterCityLbl.Size = new System.Drawing.Size(213, 20);
			this.enterCityLbl.TabIndex = 1;
			this.enterCityLbl.Text = "Введите название города:";
			// 
			// weatherSearchBtn
			// 
			this.weatherSearchBtn.Location = new System.Drawing.Point(335, 97);
			this.weatherSearchBtn.Name = "weatherSearchBtn";
			this.weatherSearchBtn.Size = new System.Drawing.Size(83, 40);
			this.weatherSearchBtn.TabIndex = 2;
			this.weatherSearchBtn.Text = "Поиск";
			this.weatherSearchBtn.UseVisualStyleBackColor = true;
			this.weatherSearchBtn.Click += new System.EventHandler(this.weatherSearchBtn_Click);
			// 
			// cityNameLbl
			// 
			this.cityNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cityNameLbl.AutoSize = true;
			this.cityNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cityNameLbl.Location = new System.Drawing.Point(10, 26);
			this.cityNameLbl.Name = "cityNameLbl";
			this.cityNameLbl.Size = new System.Drawing.Size(156, 20);
			this.cityNameLbl.TabIndex = 3;
			this.cityNameLbl.Text = "Название города";
			this.cityNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// temperatureLbl
			// 
			this.temperatureLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.temperatureLbl.AutoSize = true;
			this.temperatureLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.temperatureLbl.Location = new System.Drawing.Point(180, 26);
			this.temperatureLbl.Name = "temperatureLbl";
			this.temperatureLbl.Size = new System.Drawing.Size(119, 20);
			this.temperatureLbl.TabIndex = 4;
			this.temperatureLbl.Text = "Температура";
			this.temperatureLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// descriptionLbl
			// 
			this.descriptionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.descriptionLbl.AutoSize = true;
			this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.descriptionLbl.Location = new System.Drawing.Point(352, 26);
			this.descriptionLbl.Name = "descriptionLbl";
			this.descriptionLbl.Size = new System.Drawing.Size(91, 20);
			this.descriptionLbl.TabIndex = 5;
			this.descriptionLbl.Text = "Описание";
			this.descriptionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// humidityLbl
			// 
			this.humidityLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.humidityLbl.AutoSize = true;
			this.humidityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.humidityLbl.Location = new System.Drawing.Point(509, 26);
			this.humidityLbl.Name = "humidityLbl";
			this.humidityLbl.Size = new System.Drawing.Size(103, 20);
			this.humidityLbl.TabIndex = 6;
			this.humidityLbl.Text = "Влажность";
			this.humidityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// windSpeedLbl
			// 
			this.windSpeedLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.windSpeedLbl.AutoSize = true;
			this.windSpeedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.windSpeedLbl.Location = new System.Drawing.Point(633, 26);
			this.windSpeedLbl.Name = "windSpeedLbl";
			this.windSpeedLbl.Size = new System.Drawing.Size(144, 20);
			this.windSpeedLbl.TabIndex = 7;
			this.windSpeedLbl.Text = "Скорость ветра";
			this.windSpeedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// weatherIcon
			// 
			this.weatherIcon.Location = new System.Drawing.Point(571, 71);
			this.weatherIcon.Name = "weatherIcon";
			this.weatherIcon.Size = new System.Drawing.Size(140, 66);
			this.weatherIcon.TabIndex = 8;
			this.weatherIcon.TabStop = false;
			// 
			// welcomeLbl
			// 
			this.welcomeLbl.AutoSize = true;
			this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.welcomeLbl.Location = new System.Drawing.Point(192, 9);
			this.welcomeLbl.Name = "welcomeLbl";
			this.welcomeLbl.Size = new System.Drawing.Size(388, 24);
			this.welcomeLbl.TabIndex = 9;
			this.welcomeLbl.Text = "Добро пожаловать в прогноз погоды!";
			// 
			// displayCityName
			// 
			this.displayCityName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.displayCityName.AutoSize = true;
			this.displayCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.displayCityName.Location = new System.Drawing.Point(81, 100);
			this.displayCityName.Name = "displayCityName";
			this.displayCityName.Size = new System.Drawing.Size(14, 20);
			this.displayCityName.TabIndex = 10;
			this.displayCityName.Text = "-";
			// 
			// displayTemperature
			// 
			this.displayTemperature.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.displayTemperature.AutoSize = true;
			this.displayTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.displayTemperature.Location = new System.Drawing.Point(232, 100);
			this.displayTemperature.Name = "displayTemperature";
			this.displayTemperature.Size = new System.Drawing.Size(14, 20);
			this.displayTemperature.TabIndex = 11;
			this.displayTemperature.Text = "-";
			this.displayTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// displayDescription
			// 
			this.displayDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.displayDescription.AutoSize = true;
			this.displayDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.displayDescription.Location = new System.Drawing.Point(391, 100);
			this.displayDescription.Name = "displayDescription";
			this.displayDescription.Size = new System.Drawing.Size(14, 20);
			this.displayDescription.TabIndex = 12;
			this.displayDescription.Text = "-";
			this.displayDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// displayHumidity
			// 
			this.displayHumidity.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.displayHumidity.AutoSize = true;
			this.displayHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.displayHumidity.Location = new System.Drawing.Point(554, 100);
			this.displayHumidity.Name = "displayHumidity";
			this.displayHumidity.Size = new System.Drawing.Size(14, 20);
			this.displayHumidity.TabIndex = 13;
			this.displayHumidity.Text = "-";
			this.displayHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// displayWindSpeed
			// 
			this.displayWindSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.displayWindSpeed.AutoSize = true;
			this.displayWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.displayWindSpeed.Location = new System.Drawing.Point(698, 100);
			this.displayWindSpeed.Name = "displayWindSpeed";
			this.displayWindSpeed.Size = new System.Drawing.Size(14, 20);
			this.displayWindSpeed.TabIndex = 14;
			this.displayWindSpeed.Text = "-";
			this.displayWindSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.97102F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.02898F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
			this.tableLayoutPanel1.Controls.Add(this.displayHumidity, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.temperatureLbl, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.windSpeedLbl, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.displayDescription, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.displayTemperature, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.humidityLbl, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.displayCityName, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.cityNameLbl, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.descriptionLbl, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.displayWindSpeed, 4, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 164);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 147);
			this.tableLayoutPanel1.TabIndex = 15;
			// 
			// WeatherForecast
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(806, 370);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.welcomeLbl);
			this.Controls.Add(this.weatherIcon);
			this.Controls.Add(this.weatherSearchBtn);
			this.Controls.Add(this.enterCityLbl);
			this.Controls.Add(this.cityNameTxt);
			this.Name = "WeatherForecast";
			this.Text = "Прогноз погоды";
			((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox cityNameTxt;
		private System.Windows.Forms.Label enterCityLbl;
		private System.Windows.Forms.Button weatherSearchBtn;
		private System.Windows.Forms.Label cityNameLbl;
		private System.Windows.Forms.Label temperatureLbl;
		private System.Windows.Forms.Label descriptionLbl;
		private System.Windows.Forms.Label humidityLbl;
		private System.Windows.Forms.Label windSpeedLbl;
		private System.Windows.Forms.PictureBox weatherIcon;
		private System.Windows.Forms.Label welcomeLbl;
		private System.Windows.Forms.Label displayCityName;
		private System.Windows.Forms.Label displayTemperature;
		private System.Windows.Forms.Label displayDescription;
		private System.Windows.Forms.Label displayHumidity;
		private System.Windows.Forms.Label displayWindSpeed;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}

