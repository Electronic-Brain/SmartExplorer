/* This script may not be reproduced or selling anywhere without prior written permission of Electronic Brain.
 * Project Developed by - 
 * Srejon Khan 
 * Game Programmer, Electronic Brain 
 * 
 * Ashikur Rahman 
 * Game Programmer,Electronic Brain
 * Email : support@electronicbrain.net 
 */

using System.Windows.Forms;

namespace SmartDLL
{
    public class SmartFileExplorer
    {
        #region variables
        public string filePath;
        public string fileName;
        public bool checkFileExists = true;
        public bool checkPathExists = false;
        public bool resultOK = false;
        #endregion

        /// <summary>
        /// Call this function for open explorer
        /// In Unity Editor, It will throw 2 errors because form classed are not unregistered when Unity Editor Stops. 
        /// But it won't throw any kind of error in Build.
        /// </summary>
        /// <param name="initialDir">InitialDirectory property represents the directory to be displayed when the open file dialog appears first time.</param>
        /// <param name="restoreDir">If RestoreDirectory property set to true that means the open file dialogg box restores the current directory before closing.</param>
        /// <param name="title">Title property is used to set or get the title of the open file dialog.</param>
        /// <param name="defExtension">DefaultExtn property represents the default file name extension.</param>
        /// <param name="filter">Filter represents the filter on an open file dialog that is used to filter the type of files to be loaded during the browse option</param>>
        public void OpenExplorer(string initialDir, bool restoreDir, string title, string defExtension, string filter)
        {
            resultOK = false;

            OpenFileDialog fileDia = new OpenFileDialog
            {
                InitialDirectory = initialDir,
                RestoreDirectory = restoreDir,
                Title = title,
                DefaultExt = defExtension,
                Filter = filter,
                CheckFileExists = checkFileExists,
                CheckPathExists = checkPathExists
            };

            if (fileDia.ShowDialog() == DialogResult.OK) //Check for Path
            {
                fileName = fileDia.FileName;
                filePath = fileDia.InitialDirectory;
                resultOK = true;
            }
        }
    }
}
