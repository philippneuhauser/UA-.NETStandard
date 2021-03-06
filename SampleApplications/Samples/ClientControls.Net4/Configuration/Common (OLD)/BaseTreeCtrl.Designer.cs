/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

namespace Opc.Ua.Client.Controls
{
    partial class BaseTreeCtrl
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
            this.NodesTV = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // NodesTV
            // 
            this.NodesTV.AllowDrop = true;
            this.NodesTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NodesTV.Location = new System.Drawing.Point(0, 0);
            this.NodesTV.Name = "NodesTV";
            this.NodesTV.Size = new System.Drawing.Size(489, 397);
            this.NodesTV.TabIndex = 1;
            this.NodesTV.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.NodesTV_GiveFeedback);
            this.NodesTV.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.NodesTV_BeforeExpand);
            this.NodesTV.DoubleClick += new System.EventHandler(this.NodesTV_DoubleClick);
            this.NodesTV.DragDrop += new System.Windows.Forms.DragEventHandler(this.NodesTV_DragDrop);
            this.NodesTV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.NodesTV_AfterSelect);
            this.NodesTV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NodesTV_MouseDown);
            this.NodesTV.DragEnter += new System.Windows.Forms.DragEventHandler(this.NodesTV_DragEnter);
            this.NodesTV.DragOver += new System.Windows.Forms.DragEventHandler(this.NodesTV_DragOver);
            // 
            // BaseTreeCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NodesTV);
            this.Name = "BaseTreeCtrl";
            this.Size = new System.Drawing.Size(489, 397);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
