using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace SCARA_robot
{
    public partial class PathCreating : Form
    {
        private MainForm mainForm;

        public List<string[]> path_data;
        string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SCARA_Robot");
        readonly string file = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SCARA_Robot"), "SavedPaths.txt");

        List<string> existingPathsNames = new List<string>();

        public PathCreating(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            TimerPathCreator.Start();
            path_data = new List<string[]>();

            // Selected node in the treeView -> Bold
            treeViewPCPath.AfterSelect += TreeViewPCPath_AfterSelect;
        }

        private void TimerPathCreator_Tick(object sender, EventArgs e)
        {
            if (!mainForm.SerialPortConnection.IsOpen)
            {
                this.Enabled = false;
            }
            else
            {
                this.Enabled = true;
            }
        }


        private void btnNodeDown_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewPCPath.SelectedNode;

            if (selectedNode == null)
            {
                MessageBox.Show("Please select a node to move.", "Move Down Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TreeNode selectedParentNode = selectedNode.Parent;

            if (selectedParentNode == null)
            {
                if (selectedNode.Index < treeViewPCPath.Nodes.Count - 1)
                {
                    int currentIndex = selectedNode.Index;
                    int desiredIndex = currentIndex + 1;

                    var storedCurrentPath_data = path_data[currentIndex];
                    
                    path_data.RemoveAt(currentIndex);
                    path_data.Insert(desiredIndex, storedCurrentPath_data);

                    treeViewPCPath.Nodes.RemoveAt(currentIndex);
                    treeViewPCPath.Nodes.Insert(desiredIndex, selectedNode);
                    treeViewPCPath.SelectedNode = selectedNode;
                }
                else
                {
                    MessageBox.Show("Cannot move the node down (it's already at the bottom).", "Move Down Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Moving child nodes is not supported by this method.", "Move Down Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            refreshTreeView();
        }



        private void btnNodeUp_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewPCPath.SelectedNode;

            if (selectedNode == null)
            {
                MessageBox.Show("Please select a node to move.", "Move Up Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TreeNode selectedParentNode = selectedNode.Parent;

            if (selectedParentNode == null)
            {
                if (selectedNode.Index -1 >= 0)
                {
                    int currentIndex = selectedNode.Index;
                    int desiredIndex = currentIndex - 1;

                    var storedCurrentPath_data = path_data[currentIndex];

                    path_data.RemoveAt(currentIndex);
                    path_data.Insert(desiredIndex, storedCurrentPath_data);

                    treeViewPCPath.Nodes.RemoveAt(currentIndex);
                    treeViewPCPath.Nodes.Insert(desiredIndex, selectedNode);
                    treeViewPCPath.SelectedNode = selectedNode;
                }
                else
                {
                    MessageBox.Show("Cannot move the node Up (it's already at the top).", "Move Down Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Moving child nodes is not supported by this method.", "Move Down Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            refreshTreeView();
        }

        private void btnPCAdd_Click(object sender, EventArgs e)
        {
            var variables = mainForm.ComputeIK();

            if (variables != null)
            {

                // Create a new list for the current variables
                var variablesList = new List<string>
                {
                    variables.Item1, // q1
                    variables.Item2, // z
                    variables.Item3, // q2
                    variables.Item4, // quill
                    variables.Item5, // flangeWidth
                    variables.Item6, // v
                    variables.Item7  // a
                };

                // Check if it's not tha same as previous one
                if (path_data.Count != 0)
                {
                    string previousQ1 = path_data[path_data.Count - 1][0];
                    string previousZ = path_data[path_data.Count - 1][1];
                    string previousQ2 = path_data[path_data.Count - 1][2];
                    string previousQuill = path_data[path_data.Count - 1][3];
                    string previousFlangeWidth = path_data[path_data.Count - 1][4];

                    if (previousQ1 == variablesList[0] && previousQ2 == variablesList[1] && previousZ == variablesList[2] &&
                        previousQuill == variablesList[3] && previousFlangeWidth == variablesList[4])
                    {
                        MessageBox.Show("Given vector is the same as previous one, it won't be added!");
                        return;
                    }
                }

                if (path_data.Count > 9)
                {
                    MessageBox.Show("To many path points, max amout of vectors is 10!");
                } else
                {
                    path_data.Add(variablesList.ToArray());
                    refreshTreeView();
                }
            }
            else
            {
                mainForm.AppendTextToMonitor("ComputeIK failed due to invalid input!");
            }
        }

        private void btnPCDelete_Click(object sender, EventArgs e)
        {
            if (btnPCLoad.Text == "Cancel")
            {
                if (treeViewPCPath.SelectedNode == null)
                {
                    MessageBox.Show("No path selected!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string deletePathName = treeViewPCPath.SelectedNode.Text; // Get selected path name

                var confirmResult = MessageBox.Show($"Are you sure you want to delete '{deletePathName}'?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    if (File.Exists(file))
                    {
                        // Read all lines and remove the selected path
                        var lines = File.ReadAllLines(file).Where(line => !line.StartsWith(deletePathName + "|")).ToList();

                        // Overwrite the file with the updated content
                        File.WriteAllLines(file, lines);

                        // Remove from TreeView
                        treeViewPCPath.SelectedNode.Remove();
                    }
                    else
                    {
                        MessageBox.Show("Saved paths file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (treeViewPCPath.SelectedNode != null)
                {
                    var confirmResult = MessageBox.Show("Are you sure you want to delete this node?",
                                                         "Confirm Delete",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        if (treeViewPCPath.SelectedNode.Parent != null)
                        {
                            // Remove from the array of path_data
                            path_data.RemoveAt(treeViewPCPath.SelectedNode.Parent.Index);
                            // Remove from treeView
                            TreeNode parentNode = treeViewPCPath.SelectedNode.Parent;
                            parentNode.Remove();
                        }
                        else
                        {
                            path_data.RemoveAt(treeViewPCPath.SelectedNode.Index);
                            treeViewPCPath.SelectedNode.Remove();
                        }

                        refreshTreeView();
                        mainForm.AppendTextToMonitor("Node deleted successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a node to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnPCRun_Click(object sender, EventArgs e)
        {
            if (btnPCLoad.Text == "Cancel")
            {
                if (treeViewPCPath.SelectedNode == null) return;

                string selectedPathName = treeViewPCPath.SelectedNode.Text; // Get selected path name
                path_data.Clear(); // Clear current path_data

                if (File.Exists(file))
                {
                    foreach (var line in File.ReadAllLines(file))
                    {
                        var parts = line.Split('|');
                        if (parts.Length > 1 && parts[0] == selectedPathName) // If name matches, load vectors
                        {
                            var vectors = parts.Skip(1) // Skip the path name
                                               .Where(segment => !string.IsNullOrEmpty(segment)) // Ensure non-empty segments
                                               .Select(segment => segment.Split(';')) // Convert each segment to an array
                                               .ToList();

                            path_data.AddRange(vectors);
                            break; 
                        }
                    }
                }

                btnPCLoad.Text = "Load";
                btnPCSave.Enabled = true;
                refreshTreeView();
            }
            else
            {
                if (path_data.Count == 0 || path_data.Count == 1)
                {
                    MessageBox.Show("No vectors available to compare.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Look for the same vectors in the row
                var previousVectors = path_data[0];
                List<int> sameVectorsIndexes = new List<int>();

                for (int i = 1; i < path_data.Count; i++)
                {
                    var vector = path_data[i];
                    if (previousVectors.SequenceEqual(vector))
                    {
                        sameVectorsIndexes.Add(i);
                    }
                    previousVectors = vector;
                }

                // Check if we found any duplicate indexes
                if (sameVectorsIndexes.Count > 0)
                {
                    string indexes = string.Join(", ", sameVectorsIndexes);
                    DialogResult dialogResult = MessageBox.Show(
                        $"Found duplicate vectors at indexes: {indexes}.\n" +
                        "Press 'Yes' to delete every second duplicate and continue, or 'No' to cancel.",
                        "Duplicate Vectors",
                        MessageBoxButtons.YesNo
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Sort indexes in descending order to prevent index shifting issues
                        sameVectorsIndexes.Sort((a, b) => b.CompareTo(a));

                        foreach (int index in sameVectorsIndexes)
                        {
                            treeViewPCPath.Nodes.RemoveAt(index);
                            path_data.RemoveAt(index);
                        }
                        refreshTreeView();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }

                // Proceed with writing data to serial connection
                mainForm.SerialPortConnection.WriteLine("StartS");
                foreach (var array in path_data)
                {
                    mainForm.SerialPortConnection.WriteLine($"PV;{string.Join(";", array)}"); // Join each array with a comma
                    Console.WriteLine($"PV;{string.Join(";", array)}");
                }
                mainForm.SerialPortConnection.WriteLine("EndS");
            }
        }



        private void btnPCClear_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this node?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                path_data.Clear();
                treeViewPCPath.Nodes.Clear();
            }
        }

        public void refreshTreeView()
        {
            treeViewPCPath.Nodes.Clear();

            for (int point = 0; point < path_data.Count; point++)
            {
                var vectorNode = treeViewPCPath.Nodes.Add($"Vector: {point + 1}");
                vectorNode.Nodes.Add($"Position data [α1: {path_data[point][0]}°; α2: {path_data[point][2]}°; z: {path_data[point][1]}mm]");
                vectorNode.Nodes.Add($"Tool data [quill: {path_data[point][3]}°; flangeWidth: {path_data[point][4]}mm]");
                vectorNode.Nodes.Add($"Motion data [rpm: {path_data[point][5]}r/min; rampLen: {path_data[point][6]}steps]");
            }
        }

        #region Visual Improvement
        private TreeNode previousNode = null;

        private void TreeViewPCPath_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (previousNode != null && previousNode != e.Node)
            {
                previousNode.BackColor = Color.Transparent; 
            }
            if (treeViewPCPath.SelectedNode.Parent == null)
            {
                e.Node.BackColor = Color.LightBlue;
            }
            previousNode = e.Node;
        }
        #endregion

        private void btnPCSave_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if (!File.Exists(file))
            {
                File.Create(file).Close();
            }

            string response = Microsoft.VisualBasic.Interaction.InputBox("Name your path", "Save the path:", "", 20, 20);

            if (String.IsNullOrEmpty(response) ||  path_data.Count == 0)
            {
                MessageBox.Show("Path had no name or no Vectors added! ", "Save error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (var line in File.ReadAllLines(file))
            {
                var pathName = line.Split('|')[0];
                if (pathName == response)
                {
                    MessageBox.Show("Path with this name already exists!", "Save Path Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            File.AppendAllLines(file, new[] { "" });
            File.AppendAllText(file, $"{response}|");
            for (int point = 0; point < path_data.Count; point++)
            {
                File.AppendAllText(file, $"{path_data[point][0]};{path_data[point][1]};{path_data[point][2]};{path_data[point][3]};{path_data[point][4]};{path_data[point][5]};{path_data[point][6]}|" );
            }
        }

        private void btnPCLoad_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if (!File.Exists(file))
            {
                File.Create(file).Close();
            }

            if (btnPCLoad.Text == "Load")
            {
                btnPCLoad.Text = "Cancel";
                btnPCSave.Enabled = false;
                if (File.Exists(file) && !String.IsNullOrEmpty(File.ReadAllText(file)))
                {
                    treeViewPCPath.Nodes.Clear();
                    foreach (var line in File.ReadAllLines(file))
                    {
                        if (!String.IsNullOrEmpty(line))
                        {
                            string pathName = line.Split('|')[0];
                            existingPathsNames.Add(pathName);

                            var vectorNode = treeViewPCPath.Nodes.Add($"{pathName}");
                        }
                    }
                }
            } else
            {
                btnPCLoad.Text = "Load";
                btnPCSave.Enabled = true;
                refreshTreeView();
                return;
            }
        }
    }
}



//Protocols:
//      StartS - Start Sending "For path creator, it means PC starts to send vectors, so Arduino listen"
//      PV - Path Vector "for confirmation data belongs to the path"
//      EndS - End Sending "Also for path creator, it means that PC sent entire path and arduino can start execute"
