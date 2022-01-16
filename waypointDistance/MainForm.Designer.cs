/*
 * Created by SharpDevelop.
 * User: m e s s
 * Date: 1/16/2022
 * Time: 8:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WaypointDistance
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.calculateButton = new System.Windows.Forms.Button();
			this.waypoint1LatTB = new System.Windows.Forms.TextBox();
			this.waypoint1LongTB = new System.Windows.Forms.TextBox();
			this.waypoint1Label = new System.Windows.Forms.Label();
			this.calculateDistanceLabel = new System.Windows.Forms.Label();
			this.latitudeLabel = new System.Windows.Forms.Label();
			this.longitudeLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.waypoint2LongTB = new System.Windows.Forms.TextBox();
			this.waypoint2LatTB = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.resetButton = new System.Windows.Forms.Button();
			this.distanceLabel = new System.Windows.Forms.Label();
			this.bearingLabel = new System.Windows.Forms.Label();
			this.timeLabel = new System.Windows.Forms.Label();
			this.constantLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(402, 82);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(79, 34);
			this.calculateButton.TabIndex = 0;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.CalculateButtonClick);
			// 
			// waypoint1LatTB
			// 
			this.waypoint1LatTB.Location = new System.Drawing.Point(128, 89);
			this.waypoint1LatTB.Name = "waypoint1LatTB";
			this.waypoint1LatTB.Size = new System.Drawing.Size(121, 22);
			this.waypoint1LatTB.TabIndex = 1;
			// 
			// waypoint1LongTB
			// 
			this.waypoint1LongTB.Location = new System.Drawing.Point(261, 89);
			this.waypoint1LongTB.Name = "waypoint1LongTB";
			this.waypoint1LongTB.Size = new System.Drawing.Size(121, 22);
			this.waypoint1LongTB.TabIndex = 2;
			// 
			// waypoint1Label
			// 
			this.waypoint1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.waypoint1Label.Location = new System.Drawing.Point(12, 88);
			this.waypoint1Label.Name = "waypoint1Label";
			this.waypoint1Label.Size = new System.Drawing.Size(110, 23);
			this.waypoint1Label.TabIndex = 3;
			this.waypoint1Label.Text = "Waypoint 1";
			// 
			// calculateDistanceLabel
			// 
			this.calculateDistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calculateDistanceLabel.Location = new System.Drawing.Point(12, 9);
			this.calculateDistanceLabel.Name = "calculateDistanceLabel";
			this.calculateDistanceLabel.Size = new System.Drawing.Size(473, 35);
			this.calculateDistanceLabel.TabIndex = 4;
			this.calculateDistanceLabel.Text = "Waypoint Calculator";
			this.calculateDistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// latitudeLabel
			// 
			this.latitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.latitudeLabel.Location = new System.Drawing.Point(128, 63);
			this.latitudeLabel.Name = "latitudeLabel";
			this.latitudeLabel.Size = new System.Drawing.Size(100, 23);
			this.latitudeLabel.TabIndex = 5;
			this.latitudeLabel.Text = "Latitude";
			// 
			// longitudeLabel
			// 
			this.longitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.longitudeLabel.Location = new System.Drawing.Point(261, 63);
			this.longitudeLabel.Name = "longitudeLabel";
			this.longitudeLabel.Size = new System.Drawing.Size(100, 23);
			this.longitudeLabel.TabIndex = 6;
			this.longitudeLabel.Text = "Longitude";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 129);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Waypoint 2";
			// 
			// waypoint2LongTB
			// 
			this.waypoint2LongTB.Location = new System.Drawing.Point(261, 130);
			this.waypoint2LongTB.Name = "waypoint2LongTB";
			this.waypoint2LongTB.Size = new System.Drawing.Size(121, 22);
			this.waypoint2LongTB.TabIndex = 8;
			// 
			// waypoint2LatTB
			// 
			this.waypoint2LatTB.Location = new System.Drawing.Point(128, 130);
			this.waypoint2LatTB.Name = "waypoint2LatTB";
			this.waypoint2LatTB.Size = new System.Drawing.Size(121, 22);
			this.waypoint2LatTB.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Distance (KM)";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(168, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Bearing (°)";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(297, 178);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Time (s)";
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(402, 123);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(79, 34);
			this.resetButton.TabIndex = 13;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButtonClick);
			// 
			// distanceLabel
			// 
			this.distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.distanceLabel.Location = new System.Drawing.Point(12, 201);
			this.distanceLabel.Name = "distanceLabel";
			this.distanceLabel.Size = new System.Drawing.Size(100, 37);
			this.distanceLabel.TabIndex = 14;
			this.distanceLabel.Text = "-";
			this.distanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// bearingLabel
			// 
			this.bearingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bearingLabel.Location = new System.Drawing.Point(168, 201);
			this.bearingLabel.Name = "bearingLabel";
			this.bearingLabel.Size = new System.Drawing.Size(100, 37);
			this.bearingLabel.TabIndex = 15;
			this.bearingLabel.Text = "-";
			this.bearingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// timeLabel
			// 
			this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeLabel.Location = new System.Drawing.Point(297, 201);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(184, 37);
			this.timeLabel.TabIndex = 16;
			this.timeLabel.Text = "-";
			this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// constantLabel
			// 
			this.constantLabel.Location = new System.Drawing.Point(297, 245);
			this.constantLabel.Name = "constantLabel";
			this.constantLabel.Size = new System.Drawing.Size(167, 23);
			this.constantLabel.TabIndex = 17;
			this.constantLabel.Text = "*constant speed 2 knot";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 282);
			this.Controls.Add(this.constantLabel);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.bearingLabel);
			this.Controls.Add(this.distanceLabel);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.waypoint2LongTB);
			this.Controls.Add(this.waypoint2LatTB);
			this.Controls.Add(this.longitudeLabel);
			this.Controls.Add(this.latitudeLabel);
			this.Controls.Add(this.calculateDistanceLabel);
			this.Controls.Add(this.waypoint1Label);
			this.Controls.Add(this.waypoint1LongTB);
			this.Controls.Add(this.waypoint1LatTB);
			this.Controls.Add(this.calculateButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistem Navigasi Terintegrasi";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
			this.ActiveControl = waypoint1LatTB;
			
		}
		private System.Windows.Forms.Label constantLabel;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.Label bearingLabel;
		private System.Windows.Forms.Label distanceLabel;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox waypoint2LatTB;
		private System.Windows.Forms.TextBox waypoint2LongTB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label longitudeLabel;
		private System.Windows.Forms.Label latitudeLabel;
		private System.Windows.Forms.Label calculateDistanceLabel;
		private System.Windows.Forms.Label waypoint1Label;
		private System.Windows.Forms.TextBox waypoint1LongTB;
		private System.Windows.Forms.TextBox waypoint1LatTB;
		private System.Windows.Forms.Button calculateButton;
	}
}
