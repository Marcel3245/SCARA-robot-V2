using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Linq;


namespace SCARA_robot
{
    public partial class MainForm : Form
    {
        private readonly int[] baudrate = { 9600, 19200, 38400, 115200, 230400, 460800, 921600, 3860000 };
        private SerialPort Serial = new SerialPort();
        public SerialPort SerialPortConnection
        {
            get { return Serial; }
        }

        float A1, A2, A3, A4, flangeWidth;

        private bool autoscroll = false;

        private bool debugMode = false;

        private PathCreating pathForm = null;

        public MainForm()
        {
            InitializeComponent();
            InitializeBaudRates();
            UpdateUI(false);  // Set the UI to the initial state - disconnected
            InitializeControlEvents(); // To control SCARA manualy via Manual Control tab
        }

        #region Initialize Methods
        private void InitializeBaudRates()
        {
            // Add all possible baud rates to the ComboBox and set default to 9600
            foreach (var rate in baudrate)
            {
                comboBoxSBaudRate.Items.Add(rate);
            }
            comboBoxSBaudRate.SelectedItem = 9600;
        }
        #endregion

        #region COM Port Refresh
        private void UpdateCOMPorts()
        {
            // Get all existing COM Port names
            string[] Ports = SerialPort.GetPortNames();
            treeViewConnect.Nodes.Clear();
            foreach (var port in Ports.Distinct())
            {
                treeViewConnect.Nodes.Add(port);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateCOMPorts();
        }
        #endregion

        #region Connect / Disconnect Logic
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Disconnect")
            {
                DisconnectFromDevice();
                return;
            }

            // Try connecting to the selected COM port
            try
            {
                Serial.PortName = treeViewConnect.SelectedNode.Text; 
            }
            catch
            {
                MessageBox.Show("Error! No COM Port selected");
                return;
            }

            // Set baud rate based on user selection
            try
            {
                Serial.BaudRate = int.Parse(comboBoxSBaudRate.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Error! No Baudrate selected");
                return;
            }

            // Configure serial port settings
            Serial.Parity = Parity.None;
            Serial.DataBits = 8;
            Serial.ReceivedBytesThreshold = 1;
            Serial.StopBits = StopBits.One;
            Serial.Handshake = Handshake.None;
            Serial.WriteTimeout = 9600;

            // Try opening the serial port
            if (!Serial.IsOpen)
            {
                try
                {
                    Serial.Open();
                    Serial.DataReceived += Serial_DataReceived;  // Event for incoming data
                    timerCheckConnection.Start();
                }
                catch
                {
                    MessageBox.Show("The COM port is not accessible", "Error");
                    return;
                }

                // If the connection is successful, update the UI
                if (Serial.IsOpen)
                {
                    UpdateUI(true);
                    AppendTextToMonitor($"Successfully connected with: {Serial.PortName}");
                }
            }
        }

        private void DisconnectFromDevice()
        {
            if (Serial.IsOpen)
            {
                timerCheckConnection.Stop();  // Stop checking the connection
                Serial.Close();
                UpdateUI(false);
                AppendTextToMonitor("Successfully disconnected!");
            }
        }

        private void buttonDisconnectSettings_Click(object sender, EventArgs e)
        {
            DisconnectFromDevice();
        }
        #endregion

        #region UI Update Method
        private void UpdateUI(bool isConnected)
        {
            // Common method to update the UI based on connection status
            btnConnect.Text = isConnected ? "Disconnect" : "Connect";
            treeViewConnect.Enabled = !isConnected;
            btnRefresh.Enabled = !isConnected;
            tabPageM.Enabled = tabPageCC.Enabled = tabPageDT.Enabled = isConnected;
            
            // Settings Tab
            btnSHomePosition.Enabled = isConnected;
            comboBoxSBaudRate.Enabled = !isConnected;
            btnSDisconnect.Enabled = isConnected;
            textBoxSDeviceName.Text = isConnected ? Serial.PortName : string.Empty;
            panelS_Online.BackColor = isConnected ? Color.Lime : Color.Red;

            // Manual Control Tab
            panelMC_Online.BackColor = isConnected ? Color.Lime : Color.Red;

            // Coordinate Control Tab
            panelCC_Online.BackColor = isConnected ? Color.Lime : Color.Red;
        }
        #endregion

        #region Data Handling
        private string serialBuffer = "";

        private async void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (Serial.IsOpen)
            {
                string receivedData = Serial.ReadExisting();
                serialBuffer += receivedData;

                while (serialBuffer.Contains("\n"))
                {
                    int newlineIndex = serialBuffer.IndexOf("\n");
                    if (newlineIndex < 0 || newlineIndex >= serialBuffer.Length)
                    {
                        break; // Exit the loop if the index is invalid
                    }
                    if (newlineIndex + 1 > serialBuffer.Length)
                    {
                        break; // Ensure substring length is valid
                    }
                    string message = serialBuffer.Substring(0, newlineIndex).Trim();
                    serialBuffer = serialBuffer.Substring(newlineIndex + 1);

                    // Process the message asynchronously
                    await Task.Run(() => ProcessMessage(message));
                }
            }
        }


        private void ProcessMessage(string message)
        {
            // Update the UI from the main thread
            if (InvokeRequired)
            {
                Invoke(new Action(() => ProcessMessage(message)));
                return;
            }

            if (debugMode)
            {
                Console.WriteLine(message);
            }

            if (message.StartsWith("ARA"))
            {
                ProcessAngleData(message);
            }
            else if (message.StartsWith("MCT") || 
                        message.StartsWith("STOP") || 
                        message.StartsWith("STOPALL") ||
                        message.StartsWith("MOVE") ||
                        message.StartsWith("PV") ||
                        message.StartsWith("StartS") ||
                        message.StartsWith("EndS") ||
                        string.IsNullOrEmpty(message))
            {
                return;
            }
            else if (message == "HOMEA")
            {
                UpdateUI(true);
                AppendTextToMonitor("Robot calibrated, and ready to use."); // Notify the user of completion
            }
            else
            {
                AppendTextToMonitor(message);
            }
        }

        public void AppendTextToMonitor(string text)
        {
            if (textBoxOutputMessage.InvokeRequired)
            {
                textBoxOutputMessage.Invoke(new MethodInvoker(delegate
                {
                    textBoxOutputMessage.AppendText(text + Environment.NewLine);
                        textBoxOutputMessage.ScrollToCaret();
                    
                }));
            }
            else
            {
                textBoxOutputMessage.AppendText(text + Environment.NewLine);
                    textBoxOutputMessage.ScrollToCaret();
            }
        }

        private void ProcessAngleData(string data)
        {
            try
            {
                // Remove the "ARA" prefix
                string angleData = data.Substring(4).Trim();

                // Split the angles based on semicolon 
                string[] angleParts = angleData.Split(';');

                if (angleParts.Length >= 5)
                {
                    if (float.TryParse(angleParts[0], NumberStyles.Float, CultureInfo.InvariantCulture, out  A1) &&
                        float.TryParse(angleParts[1], NumberStyles.Float, CultureInfo.InvariantCulture, out  A2) &&
                        float.TryParse(angleParts[2], NumberStyles.Float, CultureInfo.InvariantCulture, out  A3) &&
                        float.TryParse(angleParts[3], NumberStyles.Float, CultureInfo.InvariantCulture, out  A4) &&
                        float.TryParse(angleParts[4], NumberStyles.Float, CultureInfo.InvariantCulture, out  flangeWidth))
                    {
                        textBoxMCAngle1.Text = A1.ToString("0.00");
                        textBoxMCHeight.Text = A2.ToString("0.00");
                        textBoxMCAngle3.Text = A3.ToString("0.00");
                        textBoxMCAngle4.Text = A4.ToString("0.00");
                        textBoxMCWidthFlange.Text = flangeWidth.ToString("0.00");
                    }
                    else
                    {
                        AppendTextToMonitor("Error parsing one or more angles.");
                    }
                }
                else
                {
                    AppendTextToMonitor("Invalid data received. Expected 5 angles.");
                }
            }
            catch (Exception ex)
            {
                AppendTextToMonitor($"Error processing data: {ex.Message}");
            }
        }
        #endregion

        #region Connection Timer
        private void timerCheckConnection_Tick(object sender, EventArgs e)
        {
            if (!Serial.IsOpen)
            {
                timerCheckConnection.Stop();
                DisconnectFromDevice();
                UpdateUI(false);
                AppendTextToMonitor("Connection has been lost!");
            }
            // Ask arduino about angle 
            else
            {
                // Check if the serial line is free
                if (Serial.BytesToWrite == 0)
                {
                    Serial.WriteLine("ARQ");  // ARQ - Automatic Repeat Request
                }

                if (checkBoxCCParallel.Checked)
                {
                    textBoxCCQangle.Enabled = false;
                }
                else
                {
                    textBoxCCQangle.Enabled = true;
                }
            }
        }
        #endregion

        #region Settings Tab
        private void btnClearSerialMonitor_Click(object sender, EventArgs e)
        {
            textBoxOutputMessage.Clear();
        }

        private void btnToggleAutoscroll_Click(object sender, EventArgs e)
        {
            autoscroll = !autoscroll;

            if (autoscroll)
            {
                btnSToggleAutoscroll.BackColor = Color.Gray;
                btnSToggleAutoscroll.ForeColor = Color.White;
                btnSToggleAutoscroll.Font = new Font(btnSToggleAutoscroll.Font, FontStyle.Bold);
            }
            else
            {
                btnSToggleAutoscroll.BackColor = Color.Transparent;
                btnSToggleAutoscroll.ForeColor = SystemColors.ControlText;
                btnSToggleAutoscroll.Font = new Font(btnSToggleAutoscroll.Font, FontStyle.Regular);
            }

            Console.WriteLine($"Autoscroll is now: {autoscroll}");
        }

        private void btnSHomePosition_Click(object sender, EventArgs e)
        {
            // Send the HOMEQ command to the robot and block the UI
            Serial.WriteLine("HOMEQ");
            UpdateUI(false); 
        }

        private void textBoxSCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string command = textBoxSCommand.Text;
                if (command == "DebugMode")
                {
                    debugMode = !debugMode;
                    return;
                }

                if (!String.IsNullOrEmpty(command))
                {
                    Serial.WriteLine(command);
                    textBoxSCommand.Text = String.Empty;
                }
            }
        }

        #endregion

        #region Initialize Events
        private void InitializeControlEvents()
        {
            #region Settings
            btnSToggleAutoscroll.Click += btnToggleAutoscroll_Click; 
            btnSClearSerialMonitor.Click += btnClearSerialMonitor_Click;
            textBoxSCommand.KeyDown += textBoxSCommand_KeyDown;
            #endregion
            #region Manual Control
            btnMCJoint1L.MouseDown += (s, e) => {
                btnMCJoint1L.BackColor = Color.DimGray; 
                StartMotor("M1L");
            };
            btnMCJoint1L.MouseUp += (s, e) => {
                btnMCJoint1L.BackColor = Color.Transparent;
                StopMotor("M1");
            };

            btnMCJoint1R.MouseDown += (s, e) => {
                btnMCJoint1R.BackColor = Color.DimGray;
                StartMotor("M1R");
            };
            btnMCJoint1R.MouseUp += (s, e) => {
                btnMCJoint1R.BackColor = Color.Transparent;
                StopMotor("M1");
            };

            btnMCJoint2L.MouseDown += (s, e) => {
                btnMCJoint2L.BackColor = Color.DimGray;
                StartMotor("M2R");
            };
            btnMCJoint2L.MouseUp += (s, e) => {
                btnMCJoint2L.BackColor = Color.Transparent;
                StopMotor("M2");
            };

            btnMCJoint2R.MouseDown += (s, e) => {
                btnMCJoint2R.BackColor = Color.DimGray;
                StartMotor("M2L");
            };
            btnMCJoint2R.MouseUp += (s, e) => {
                btnMCJoint2R.BackColor = Color.Transparent;
                StopMotor("M2");
            };

            btnMCJoint3L.MouseDown += (s, e) => {
                btnMCJoint3L.BackColor = Color.DimGray;
                StartMotor("M3L");
            };
            btnMCJoint3L.MouseUp += (s, e) => {
                btnMCJoint3L.BackColor = Color.Transparent;
                StopMotor("M3");
            };

            btnMCJoint3R.MouseDown += (s, e) => {
                btnMCJoint3R.BackColor = Color.DimGray;
                StartMotor("M3R");
            };
            btnMCJoint3R.MouseUp += (s, e) => {
                btnMCJoint3R.BackColor = Color.Transparent;
                StopMotor("M3");
            };

            btnMCJoint4L.MouseDown += (s, e) => {
                btnMCJoint4L.BackColor = Color.DimGray;
                StartMotor("M4L");
            };
            btnMCJoint4L.MouseUp += (s, e) => {
                btnMCJoint4L.BackColor = Color.Transparent;
                StopMotor("M4");
            };

            btnMCJoint4R.MouseDown += (s, e) => {
                btnMCJoint4R.BackColor = Color.DimGray;
                StartMotor("M4R");
            };
            btnMCJoint4R.MouseUp += (s, e) => {
                btnMCJoint4R.BackColor = Color.Transparent;
                StopMotor("M4");
            };

            btnMCFlangeO.MouseDown += (s, e) => {
                btnMCFlangeO.BackColor = Color.DimGray;
                StartMotor("GrOPN"); // Gripper Open
            };
            btnMCFlangeO.MouseUp += (s, e) => {
                btnMCFlangeO.BackColor = Color.Transparent;
                StopMotor("G5");
            };

            btnMCFlangeC.MouseDown += (s, e) => {
                btnMCFlangeC.BackColor = Color.DimGray;
                StartMotor("GrCLS"); // Gripper Close
            };
            btnMCFlangeC.MouseUp += (s, e) => {
                btnMCFlangeC.BackColor = Color.Transparent;
                StopMotor("G5");
            };



            SetPlaceholder(textBoxMCAcceleration, "1-100");
            SetPlaceholder(textBoxMCRPM, "1-200");

            // Attach event handlers for Acceleration textbox
            textBoxMCAcceleration.Enter += (sender, e) => ClearPlaceholder((TextBox)sender, "1-100");
            textBoxMCAcceleration.Leave += (sender, e) => SetPlaceholder((TextBox)sender, "1-100");

            // Attach event handlers for RPM textbox
            textBoxMCRPM.Enter += (sender, e) => ClearPlaceholder((TextBox)sender, "1-200");
            textBoxMCRPM.Leave += (sender, e) => SetPlaceholder((TextBox)sender, "1-200");
            #endregion
            #region Coordinate Control
            SetPlaceholder(textBoxCCAcceleration, "1-100");
            SetPlaceholder(textBoxCCRPM, "1-200");

            SetPlaceholder(textBoxCCXaxis, "x");
            SetPlaceholder(textBoxCCYaxis, "y");
            SetPlaceholder(textBoxCCZaxis, "z");

            SetPlaceholder(textBoxCCQangle, "-90");
            SetPlaceholder(textBoxCCFWidth, "45");

            // Attach event handlers for Acceleration textbox
            textBoxCCAcceleration.Enter += (sender, e) => ClearPlaceholder((TextBox)sender, "1-100");
            textBoxCCAcceleration.Leave += (sender, e) => SetPlaceholder((TextBox)sender, "1-100");

            // Attach event handlers for RPM textbox
            textBoxCCRPM.Enter += (sender, e) => ClearPlaceholder((TextBox)sender, "1-200");
            textBoxCCRPM.Leave += (sender, e) => SetPlaceholder((TextBox)sender, "1-200");

            // Attach event handlers for x textbox
            textBoxCCXaxis.Enter += (sender, e) => ClearPlaceholder((TextBox)sender, "x");
            textBoxCCXaxis.Leave += (sender, e) => SetPlaceholder((TextBox)sender, "x");

            // Attach event handlers for y textbox
            textBoxCCYaxis.Enter += (sender, e) => ClearPlaceholder((TextBox)sender, "y");
            textBoxCCYaxis.Leave += (sender, e) => SetPlaceholder((TextBox)sender, "y");

            // Attach event handlers for z textbox
            textBoxCCZaxis.Enter += (sender, e) => ClearPlaceholder((TextBox)sender, "z");
            textBoxCCZaxis.Leave += (sender, e) => SetPlaceholder((TextBox)sender, "z");

            // Attach event handlers for Quill Angle textbox
            textBoxCCQangle.Enter += (sender, e) => ClearPlaceholder((TextBox)sender, "-90");
            textBoxCCQangle.Leave += (sender, e) => SetPlaceholder((TextBox)sender, "-90");

            // Attach event handlers for Flange Spread textbox
            textBoxCCFWidth.Enter += (sender, e) => ClearPlaceholder((TextBox)sender, "0-70");
            textBoxCCFWidth.Leave += (sender, e) => SetPlaceholder((TextBox)sender, "0-70");
            #endregion
        }
        #endregion

        #region Manual Control Tab
        // Check if the insput parameters are valid
        private (bool isValid, float acceleration, float RPM) isMCAccelerationRPMValid()
        {
            bool isValidAcceleration = float.TryParse(textBoxMCAcceleration.Text, out float acceleration) && !(acceleration < 1 || acceleration > 100);
            bool isValidRPM = float.TryParse(textBoxMCRPM.Text, out float RPM) && !(RPM < 1 || RPM > 200);

            bool allValid = true;
            string labelError = "Wrong values are:";

            if (!isValidAcceleration)
            {
                panelMCAcceleration.BackColor = Color.LightCoral;
                textBoxMCAcceleration.Text = "1-100";
                labelError += " acceleration";
                allValid = false;
            }
            else
            {
                panelMCAcceleration.BackColor = Color.WhiteSmoke;
            }

            if (!isValidRPM)
            {
                panelMCRPM.BackColor = Color.LightCoral;
                textBoxMCRPM.Text = "1-200";
                labelError += " RPM";
                allValid = false;
            }
            else
            {
                panelMCRPM.BackColor = Color.WhiteSmoke;
            }

            if (allValid == false)
            {
                AppendTextToMonitor(labelError);
                return (false, 0f, 0f);
            }

            return (true, acceleration, RPM); // Return a tuple with the valid flag, acceleration, and RPM.
        }


        private void StartMotor(string command)
        {
            var ValidAccelerationRPM = isMCAccelerationRPMValid();

            if (ValidAccelerationRPM.Item1)
                if (Serial.IsOpen)
                {
                    string motor = $"{command[0]}{command[1]}";  
                    char direction = command[2];
                    Serial.WriteLine($"MCT;{motor};{direction};{ValidAccelerationRPM.Item3};{ValidAccelerationRPM.Item2}"); // MCT - Motor Control Turn
                    Console.WriteLine($"MCT;{motor};{direction};{ValidAccelerationRPM.Item3};{ValidAccelerationRPM.Item2}");
                }
                else
                {
                    return;
                }
        }

        private void StopMotor(string motorId)
        {
            if (Serial.IsOpen && isMCAccelerationRPMValid().Item1)
            {
                Serial.WriteLine($"STOP;{motorId}"); // Example command: STOP;M1 (Motor 1 Stop)
                //Console.WriteLine($"STOP;{motorId}");
                // AppendTextToMonitor($"Motor stop command sent: {motorId}");
            }
        }

        private void btnMCAdd_Click(object sender, EventArgs e)
        {
            if (pathForm == null || pathForm.IsDisposed)
            {
                MessageBox.Show("Path Creator is currently closed. Please open it to proceed.");
                return;
            }
            else
            {
                var ValidAccelerationRPM = isMCAccelerationRPMValid();
                if (ValidAccelerationRPM.Item1)
                {
                    panelMCAcceleration.BackColor = Color.LightBlue;
                    panelMCRPM.BackColor = Color.LightBlue;
                    DialogResult dialogResult = MessageBox.Show("Is it a RPM and Acceleration you want to add?", 
                        "Warning message", MessageBoxButtons.YesNo);

                    panelMCAcceleration.BackColor = Color.WhiteSmoke;
                    panelMCRPM.BackColor = Color.WhiteSmoke;
                    
                    if (dialogResult == DialogResult.Yes)
                    {

                        var variablesList = new List<string>
                            {
                                $"{(A1):F2}", // q1
                                $"{(A2):F2}", // z
                                $"{(A3):F2}", // q2
                                $"{(A4):F2}",
                                $"{(flangeWidth):F2}",
                                $"{(ValidAccelerationRPM.Item2):F2}", // v
                                $"{(ValidAccelerationRPM.Item3):F2}"  // a
                            };

                        if (pathForm.path_data.Count != 0)
                        {
                            string previousQ1 = pathForm.path_data[pathForm.path_data.Count - 1][0];
                            string previousZ = pathForm.path_data[pathForm.path_data.Count - 1][1];
                            string previousQ2 = pathForm.path_data[pathForm.path_data.Count - 1][2];

                            if (previousQ1 == variablesList[0] && previousQ2 == variablesList[1] && previousZ == variablesList[2])
                            {
                                MessageBox.Show("Given vector is the same as previous one, it won't be added!");
                                return;
                            }
                        }
                        pathForm.path_data.Add(variablesList.ToArray());
                        pathForm.refreshTreeView();
                    }
                }
            }
        }
        #endregion

        #region Coordinate Control
        public Tuple<string, string, string, string, string, string, string> ComputeIK()
        {
            // Parameters of the SCARA robot
            int L1 = 260; // Length of Joint1
            int L2 = 165; // Length of Joint2

            // Input data
            List<float> coordinates = new List<float>(new float[3]);
            List<double> tool = new List<double>(new double[2]);
            List<float> motionParameters = new List<float>(new float[2]);

            // Try parsing inputs
            bool isValidX = float.TryParse(textBoxCCXaxis.Text, out float x);
            bool isValidY = float.TryParse(textBoxCCYaxis.Text, out float y);
            bool isValidZ = float.TryParse(textBoxCCZaxis.Text, out float z);
            coordinates[0] = x;
            coordinates[1] = -y;
            coordinates[2] = z;

            bool isValidQuill = float.TryParse(textBoxCCQangle.Text, out float QuillAngle) && !(QuillAngle < -150 || QuillAngle > 150);
            bool isValidFlange = float.TryParse(textBoxCCFWidth.Text, out float FlangeWidth) && !(FlangeWidth < 0 || FlangeWidth > 53);
            tool[0] = QuillAngle;
            tool[1] = FlangeWidth;

            bool isValidRPM = float.TryParse(textBoxCCRPM.Text, out float RPM) && !(RPM < 1|| RPM > 200);
            bool isValidAcceleration = float.TryParse(textBoxCCAcceleration.Text, out float acceleration) && !(acceleration < 1 || acceleration > 100);
            motionParameters[0] = RPM;
            motionParameters[1] = acceleration;

            // Output data
            double q1;
            double q2;

            // Check input data 
            #region Wrong-value Message
            string labelError = "Wrong values are";
            bool allValid = true;

            // Check each input validity and set corresponding UI feedback
            if (!isValidX)
            {
                labelError += ", x";
                allValid = false;
                panelCCXaxis.BackColor = Color.LightCoral;
                textBoxCCXaxis.Text = "x";
            }
            else
            {
                panelCCXaxis.BackColor = Color.WhiteSmoke;
            }

            if (!isValidY)
            {
                labelError += ", y";
                allValid = false;
                panelCCYaxis.BackColor = Color.LightCoral;
                textBoxCCYaxis.Text = "y";
            }
            else
            {
                panelCCYaxis.BackColor = Color.WhiteSmoke;
            }

            if (!isValidZ)
            {
                labelError += ", z";
                allValid = false;
                panelCCZaxis.BackColor = Color.LightCoral;
                textBoxCCZaxis.Text = "z";
            }
            else
            {
                panelCCZaxis.BackColor = Color.WhiteSmoke;
            }

            if (!isValidQuill)
            {
                labelError += ", QuillAngle";
                allValid = false;
                panelCCQangle.BackColor = Color.LightCoral;
                textBoxCCQangle.Text = "-90";
            }
            else
            {
                panelCCQangle.BackColor = Color.WhiteSmoke;
            }

            if (!isValidFlange)
            {
                labelError += ", FlangeWidth";
                allValid = false;
                panelCCFspread.BackColor = Color.LightCoral;
                textBoxCCFWidth.Text = "45";
            }
            else
            {
                panelCCFspread.BackColor = Color.WhiteSmoke;
            }

            if (!isValidRPM)
            {
                labelError += ", RPM";
                allValid = false;
                panelCCRPM.BackColor = Color.LightCoral;
                textBoxCCRPM.Text = "1-200";
            }
            else
            {
                panelCCRPM.BackColor = Color.WhiteSmoke;
            }

            if (!isValidAcceleration)
            {
                labelError += ", Acceleration";
                allValid = false;
                panelCCAcceleration.BackColor = Color.LightCoral;
                textBoxCCAcceleration.Text = "1-100";
            }
            else
            {
                panelCCAcceleration.BackColor = Color.WhiteSmoke;
            }

            if (!allValid)
            {
                MessageBox.Show(labelError);
                return null; // Return null if validation fails
            }
            #endregion

            // Check Limits
            double C = (Math.Pow(coordinates[0], 2) + Math.Pow(coordinates[1], 2) - Math.Pow(L1, 2) - Math.Pow(L2, 2))/(2*L1*L2);
            if (!(-1 <= C && C <= 1))
            {
                MessageBox.Show("Outside the range of the SCARA robot in xy!");
                return null;
            }
            if (coordinates[2] < 0 || coordinates[2] > 330)
            {
                MessageBox.Show("Outside the range of the SCARA robot in height!");
                return null;
            }

            // Calculate Inverse Kinematics for I and II
            if (coordinates[1] >= 0)
            {
                q2 = Math.Acos(C);
                q1 = Math.Atan2(coordinates[1], coordinates[0]) - Math.Atan2(L2 * Math.Sin(q2), L1 + L2 * Math.Cos(q2));

                q1 *= 180 / Math.PI;
                q2 *= 180 / Math.PI;
            }
            else
            {
                // Calculate Inverse Kinematics for III and IV 
                q2 = -Math.Acos(C);
                q1 = Math.Atan2(coordinates[1], coordinates[0]) - Math.Atan2(L2 * Math.Sin(q2), L1 + L2 * Math.Cos(q2));

                q1 *= 180 / Math.PI;
                q2 *= 180 / Math.PI;
            }

            // Check limits again for outcome angles
            if ((q1 > 140 || q1 < -140) || (q2 > 130 || q2< -130))
            {
                MessageBox.Show("Given coordinates are outside of the range of joints, check the picture!");
                return null;
            }

            // Parallel quill check box
            string formattedQuill;
            if (checkBoxCCParallel.Checked)
            {
                tool[0] = q2 - q1 + Math.Atan(coordinates[1] / coordinates[0]);
                formattedQuill = tool[0].ToString("0.00");
            } else
            {
                formattedQuill = tool[0].ToString("0.00");
            }


            string formattedQ1 = q1.ToString("0.00");
            string formattedQ2 = q2.ToString("0.00");
            string formattedZ = coordinates[2].ToString("0.00");

            string formattedRPM = motionParameters[0].ToString("0.00");
            string formattedAcceleration = motionParameters[1].ToString("0.00");

            string formattedFlangeWidth = tool[1].ToString("0.00");

            // Return the results as a Tuple
            return Tuple.Create(formattedQ1, formattedZ, formattedQ2, formattedQuill, formattedFlangeWidth,
                formattedRPM, formattedAcceleration);
        }

        private void runMotors(string q1, string z, string q2, string quill, string flangeWidth, string V, string A)
        {
            // AppendTextToMonitor($"Moving robot by vector: {q1}; {q2}; {z}; {quill}; {flangeWidth}; {V}; {A}");
            Serial.WriteLine($"MOVE;{q1};{z};{q2};{quill};{flangeWidth};{V};{A}");
        }

        private void btnCCExecute_Click(object sender, EventArgs e)
        {
            var ikResults = ComputeIK();
            if (ikResults != null) // Check if ComputeIK returned valid results
            {
                // Deconstruct the tuple into individual strings
                string q1 = ikResults.Item1;
                string z = ikResults.Item2;
                string q2 = ikResults.Item3;
                string quill = ikResults.Item4;
                string flangeWidth = ikResults.Item5;
                string V = ikResults.Item6;
                string A = ikResults.Item7;

                // Call runMotors with the deconstructed values
                runMotors(q1, z, q2, quill, flangeWidth, V, A);
            }
        }


        private CoordinateControlHelp hintsForm;

        private void btnCCHint_Click(object sender, EventArgs e)
        {
            if (hintsForm == null || hintsForm.IsDisposed)
            {
                hintsForm = new CoordinateControlHelp(); 
                hintsForm.Show(); 
            }
            else
            {
                hintsForm.BringToFront(); 
            }
        }

        private void btnCCPath_Click(object sender, EventArgs e)
        {
            if (pathForm == null || pathForm.IsDisposed)
            {
                pathForm = new PathCreating(this);
                pathForm.Show();
            }
            else
            {
                pathForm.BringToFront();
            }
        }
        #endregion

        #region Visual Improvement
        private void ClearPlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black; 
            }
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void textBoxMCVelocity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Motor Stop
        private void stopMotors()
        {
            Serial.WriteLine("STOPALL; M1; M2; M3; M4");
        }
        private void btnSEStop_Click(object sender, EventArgs e)
        {
            stopMotors();
        }
        private void btnMCEStop_Click(object sender, EventArgs e)
        {
            stopMotors();
        }
        private void btnCCEStop_Click(object sender, EventArgs e)
        {
            stopMotors();
        }
        #endregion
    }

}








//Protocols:
//    ARQ - Automatic Repeat reQuest "Ask Arduino to get angle values of the motors "   PC -> Arduino
//    ARA - Automatic Repeat Answer "Respond of the Arduino with the angles"   [A1; A2; Height; A3; AG]    Arduino -> Pc
//    MCT - Motor Control Turn "To control each motor Left/Right"   [Motor; Direction; RPM; Acceleration]  PC -> Arduino
//    STOP "To stop given motor"    [Motor]     PC -> Arduino
//    MOVE "Move robot to given posi-tion, so execute the coordinates " [MOVE, q1, q2, z, quill, flangeWidth, V, A] PC -> Arduino
//    STOPALL "To stop all the motors (emergency button) - no matter what robot or software is doing it has to be executed first!"
//    HOMEQ - Home reQuest "To calibrate and set robot in starting position - until it's not done Arduino won't respond"    PC -> Arduino
//    HOMEA - Home Answer "Arduino answer that is done with calibrating and it's ready to work"

//    WAIT "Wait to execute movement of motors" Arduino -> PC
//    READY "Ready to take new instructions" Arduino -> PC
//    Vector "When execute movement to one coordinate point in Coordiante Control"


// Debug mode:
//      debugMode = true "display all data in the background"
//      testMode = true "Do not rotate motors, only write the commends"