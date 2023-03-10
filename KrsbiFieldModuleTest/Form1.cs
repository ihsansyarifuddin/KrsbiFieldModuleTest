using KrsbiFieldModule.Singleton.Robot;
using KrsbiFieldModule.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrsbiFieldModuleTest
{
    public partial class Form1 : Form
    {
        private Robot1 robot1;
        private Robot2 robot2;
        private Robot3 robot3;
        private Robot4 robot4;
        private Robot5 robot5;
        private RobotG robotG;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fieldLoader1.LoadConfig();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            robot1 = Robot1.GetInstance();
            robot2 = Robot2.GetInstance();
            robot3 = Robot3.GetInstance();
            robot4 = Robot4.GetInstance();
            robot5 = Robot5.GetInstance();
            robotG = RobotG.GetInstance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var robot = comboBox1.Text;
                var x = int.Parse(xTextbox.Text);
                var y = int.Parse(yTextbox.Text);
                var h = double.Parse(hTextbox.Text);
                //Config location should be C:\\Users\{username}\field.json
                var fieldConfig = fieldLoader1.GetField().GetFieldConfig();
                KeyValuePair<string, object> isEnable;
                switch (robot)
                {
                    case "Robot 1":
                        isEnable = fieldConfig.Where(item => item.Key == "teamRobot1").FirstOrDefault();
                        if (isEnable.Value == null) break;
                        if(bool.Parse(isEnable.Value.ToString()) == true) RobotHandler.MoveRobotToCoordinate(robot1, new Point(x, y), h);
                        break;
                    case "Robot 2":
                        isEnable = fieldConfig.Where(item => item.Key == "teamRobot2").FirstOrDefault();
                        if (isEnable.Value == null) break;
                        if (bool.Parse(isEnable.Value.ToString()) == true) RobotHandler.MoveRobotToCoordinate(robot2, new Point(x, y), h);
                        break;
                    case "Robot 3":
                        isEnable = fieldConfig.Where(item => item.Key == "teamRobot3").FirstOrDefault();
                        if (isEnable.Value == null) break;
                        if (bool.Parse(isEnable.Value.ToString()) == true) RobotHandler.MoveRobotToCoordinate(robot3, new Point(x, y), h);
                        break;
                    case "Robot 4":
                        isEnable = fieldConfig.Where(item => item.Key == "teamRobot4").FirstOrDefault();
                        if (isEnable.Value == null) break;
                        if (bool.Parse(isEnable.Value.ToString()) == true) RobotHandler.MoveRobotToCoordinate(robot4, new Point(x, y), h);
                        break;
                    case "Robot 5":
                        isEnable = fieldConfig.Where(item => item.Key == "teamRobot5").FirstOrDefault();
                        if (isEnable.Value == null) break;
                        if (bool.Parse(isEnable.Value.ToString()) == true) RobotHandler.MoveRobotToCoordinate(robot5, new Point(x, y), h);
                        break;
                    case "Robot G":
                        isEnable = fieldConfig.Where(item => item.Key == "teamRobotG").FirstOrDefault();
                        if (isEnable.Value == null) break;
                        if (bool.Parse(isEnable.Value.ToString()) == true) RobotHandler.MoveRobotToCoordinate(robotG, new Point(x, y), h);
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
