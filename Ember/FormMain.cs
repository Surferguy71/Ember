using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Ember
{
    public partial class FormMain : Form
    {
        // Will create a member of our class variable to keep track of
        // the current file path

        private string m_currentFilePath = string.Empty;
        public FormMain()
        {
            // This will run the Visual Studio code that MS VS generated/wrote
            InitializeComponent();

            // Will setup custom styling after the form is created
            SetupStyling();
        }

        // This is the constructor and it runs once when the form is loaded
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Let's setup our dialog box filters for text code files
            openFileDialogMain.Filter = "Text files (*.txt)|*.txt|C# Console files(*.cs)|*.cs|Python files(*.py)|*.py|C files(*.c)|*.c|C++ files(*.cpp)|*.cpp|HTML files(*.html)|*.html|CSS files(*.css)|*.css|JavaScript files(*.js)|*.js|HTM files(*.htm)|*.htm|Java files(*.java)|*.java|Rust files(*.rs|*.rs|All files(*.*)|*.*";
            saveFileDialogMain.Filter = "Text files (*.txt)|*.txt|C# Console files(*.cs)|*.cs|Python files(*.py)|*.py|C files(*.c)|*.c|C++ files(*.cpp)|*.cpp|HTML files(*.html)|*.html|CSS files(*.css)|*.css|JavaScript files(*.js)|*.js|HTM files(*.htm)|*.htm|Java files(*.java)|*.java|Rust files(*.rs)|*.rs|All files(*.*)|*.*";

            richTextBoxEditor.Focus();
        }

        // This is the code to setup our custom styling after the form has been created
        private void SetupStyling()
        {
            // Let's give the form a nice shade of blue for now
            this.BackColor = Color.AliceBlue;

            // Let's style the menu strip
            menuStripMainMenus.BackColor = Color.DarkCyan;
            menuStripMainMenus.ForeColor = Color.White;

            // Let's style the editor which is our rich text box
            richTextBoxEditor.BackColor = Color.LightSlateGray;
            richTextBoxEditor.ForeColor = Color.Violet;
            richTextBoxEditor.Font = new Font("Consolas", 12);
            richTextBoxEditor.AcceptsTab = true;
            richTextBoxEditor.WordWrap = true;

            // Let's style the status strip
            statusStripMain.BackColor = Color.SkyBlue;
            toolStripStatusLabelMain.BackColor = Color.LightYellow;
            toolStripStatusLabelMain.Text = "Type your code in here...";

            // Let's expand the window title to set it to this
            // When we type in the word this, it means the code behind for the 
            // form we are on
            this.Text = "Ember - Code Editor - Ready to Design";

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // The user raised an event to create a new file
            // As developers we need to handle this event
            // First let's clear the current text in the editor
            richTextBoxEditor.Clear();
            // Next let's reset the current file path
            m_currentFilePath = string.Empty;
            // Next let's set the current tile of the form to indicate a new file
            this.Text = "Ember - Code Editor - New File";
            // Now let's update the user to know what they are doing
            toolStripStatusLabelMain.Text = "New file created. Start typing your code!";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Let's close the application at the user's request
            // The User raised an event to close the application
            // As developers we need to handle this event
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // The user raised an event to open a file from the file menu
            // By cliclking on the open from our file menu

            // Let's create an open file dialog to allow the user to select a file
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    // Now let's try and read the user selected file and put it
                    // in the editor text box area
                    string filecontent = File.ReadAllText(openFileDialogMain.FileName);

                    // Read the content of the file and display it in the editor
                    richTextBoxEditor.Text = filecontent;

                    // Update the current file path to the opened file
                    m_currentFilePath = openFileDialogMain.FileName;

                    // Update the form title to reflect the opened file
                    this.Text = "Ember - Code Editor - " + Path.GetFileName(openFileDialogMain.FileName);

                    // Update the status label to inform the user
                    toolStripStatusLabelMain.Text = "File opened: " + Path.GetFileName(openFileDialogMain.FileName);
                }
                catch (Exception ex)
                {
                    // If trying to open an existing code file fails, an event is raised
                    // and we handle that event with code here
                    // Show an error message to the user
                    MessageBox.Show("Error opening file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }


        }
        // This method will handle the save event
        // When the user clicks on the save menu item

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Now let's check where we can save the file
            // If we have a current file path, we will save to that file
            if (string.IsNullOrEmpty(m_currentFilePath))
            {
                // Show a dialog to choose where to save this current code file in the editor
                if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
                {
                    m_currentFilePath = saveFileDialogMain.FileName;
                }
                else
                {
                    // If we are here, our user canceled the save, so do nothing
                    return;
                }

            }
            // Let's try to save the text in the editor to the file on storage
            try
            {

                File.WriteAllText(m_currentFilePath, richTextBoxEditor.Text);
                this.Text = "Ember - Code Editor - " + Path.GetFileName(m_currentFilePath);

                // Update the status label to inform the user
                toolStripStatusLabelMain.Text = "File saved: " + Path.GetFileName(m_currentFilePath);
            }
            // If there is an error raised by the system we handle it here
            catch (Exception ex)
            {
                // Show an error box to our user if the file cannot be saved
                MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }
        // This method will handle the save as event
        // When the user clicks on the save as menu item
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Now let's show the user the save dialog box even if we already have
            // a file path to save to

            if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    // Give the user option to save the text fie in a new location or same location
                    File.WriteAllText(saveFileDialogMain.FileName, richTextBoxEditor.Text);
                    // Update the current file path to the saved file
                    m_currentFilePath = saveFileDialogMain.FileName;
                    // Update the form title to reflect the saved file
                    this.Text = "Ember - Code Editor - " + Path.GetFileName(m_currentFilePath);
                    // Update the status label to inform the user
                    toolStripStatusLabelMain.Text = "File saved as: " + Path.GetFileName(m_currentFilePath);
                }

                // If there is an error raised by the system we handle it here
                catch (Exception ex)
                {
                    // Show an error box to our user if the file cannot be saved
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        // This method will handle the text changed event in the rich text box editor

        private void richTextBoxEditor_TextChanged(object sender, EventArgs e)
        {
            // This will update the status label to inform the user that they are typing
            toolStripStatusLabelMain.Text = "Typing...";
            // Optionally, we can also update the form title to reflect unsaved changes
            if (!string.IsNullOrEmpty(m_currentFilePath))
            {
                this.Text = "Ember - Code Editor - " + Path.GetFileName(m_currentFilePath) + " *";
            }
            else
            {
                this.Text = "Ember - Code Editor - New File *";
            }
            // Let's also update the status strip to show the number of lines in the code editor
            int lineCount = richTextBoxEditor.Lines.Length;

            // Let's count the number of characters in the editor
            int charCount = richTextBoxEditor.Text.Length;

            // Now let's update the status label to show the line and character count
            toolStripStatusLabelMain.Text = $"Lines: {lineCount} | Characters: {charCount}";
        }
    }// End of class FormMain

}// End of namespace Ember
